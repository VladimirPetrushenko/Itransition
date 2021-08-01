using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task6
{
    public class TiktactoeHub : Hub
    {
        private static List<Client> _clients = new List<Client>();
        private static List<string> _tagName = new List<string>();

        private object _syncRoot = new object();

        public void RegisterClient()
        {
            lock (_syncRoot)
            {
                var client = _clients.FirstOrDefault(x => x.ConnectionID == Context.ConnectionId);
                if (client == null)
                {
                    client = new Client
                    {
                        ConnectionID = Context.ConnectionId,
                    };
                    _clients.Add(client);
                }
                client.IsPlaying = false;
            }
        }

        public async Task Games(string ConnectionID)
        {
            List<string> tagGames = new List<string>();
            List<string> gameNames = new List<string>();
            List<int> ids = new List<int>();
            foreach (var client in _clients.Where(x => x.TagGame != null && !x.IsPlaying && x.LookingForOpponent))
            {
                gameNames.Add(client.GameName);
                tagGames.Add(client.TagGame);
                ids.Add(_clients.IndexOf(client));
            }
            if(ConnectionID==null)
                await Clients.Client(Context.ConnectionId).SendAsync("SetAllGames", tagGames, gameNames, ids, _tagName);
            else
            {
                var client = _clients.FirstOrDefault(x => x.ConnectionID == ConnectionID);
                await Clients.Client(client.Opponent.ConnectionID).SendAsync("SetAllGames", tagGames, gameNames, ids, _tagName);
            }
        }
        public async Task CreateGame(string gameName, string tagName)
        {
            RegisterClient();
            var player = _clients.FirstOrDefault(x => x.ConnectionID == Context.ConnectionId);

            if (_tagName.FirstOrDefault(x => x == tagName) == null)
                _tagName.Add(tagName);

            player.LookingForOpponent = true;
            player.TagGame = tagName;
            player.GameName = gameName;
            player.IsPlaying = false;

            List<string> tagGames = new List<string>();
            List<string> gameNames = new List<string>();
            List<int> ids = new List<int>();
            foreach (var client in _clients.Where(x => x.TagGame != null && !x.IsPlaying && x.LookingForOpponent))
            {
                gameNames.Add(client.GameName);
                tagGames.Add(client.TagGame);
                ids.Add(_clients.IndexOf(client));
            }

            await Clients.Client(Context.ConnectionId).SendAsync("NoOpponent");
            await Clients.All.SendAsync("AppendenGame", tagGames, gameNames, ids, _tagName);
        }

        public async Task FindOpponent(string playerId)
        {
            if (playerId == null)
                return;
            int id = Convert.ToInt32(playerId);
            if (id>=_clients.Count)
                return;
            RegisterClient();
            var player = _clients.FirstOrDefault(x => x.ConnectionID == Context.ConnectionId);
            
            player.LookingForOpponent = true;
            var opponent = _clients[(int)id];

            await ConnectOpponent(player, opponent);
            await Clients.All.SendAsync("RemoveGame", id);
        }

        private async Task ConnectOpponent(Client player, Client opponent)
        {
            player.IsPlaying = true;
            player.LookingForOpponent = false;
            opponent.IsPlaying = true;
            opponent.LookingForOpponent = false;

            player.Opponent = opponent;
            opponent.Opponent = player;

            await Clients.Client(player.ConnectionID).SendAsync("FoundOpponent", "O");
            await Clients.Client(opponent.ConnectionID).SendAsync("FoundOpponent", "X");

            await Clients.Client(player.ConnectionID).SendAsync("WaitingForMarkerPlacement", true);
            await Clients.Client(opponent.ConnectionID).SendAsync("WaitingForMarkerPlacement", false);
        }

        public async Task Send(object cell, string player)
        {
            var client = _clients.FirstOrDefault(x => x.ConnectionID == Context.ConnectionId);
            await this.Clients.Client(client.Opponent.ConnectionID).SendAsync("Drawing", cell, player);
            await this.Clients.Client(client.ConnectionID).SendAsync("Drawing", cell, player);
            await this.Clients.Client(client.Opponent.ConnectionID).SendAsync("WaitingForMarkerPlacement", false);
            await Clients.Client(client.ConnectionID).SendAsync("WaitingForMarkerPlacement", true);
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            var client = _clients.FirstOrDefault(x => x.ConnectionID == Context.ConnectionId);
            if (client != null && client.Opponent != null)
            {
                await Clients.Client(client.Opponent.ConnectionID).SendAsync("RestartGame");
                await Games(client.Opponent.ConnectionID);
            }
            await base.OnDisconnectedAsync(exception);
        }

        public async Task RestartRound()
        {
            await Clients.Client(Context.ConnectionId).SendAsync("RestartGame");
        }
        public override async Task OnConnectedAsync()
        {
            await Clients.Client(Context.ConnectionId).SendAsync("RestartGame");
            await Games(null);
        }
        public async Task Winner(string text)
        {
            await Clients.Client(Context.ConnectionId).SendAsync("WinnerGame", text);
        }
    }
    public class Client
    {
        public string GameName { get; set; }
        public Client Opponent { get; set; }
        public bool IsPlaying { get; set; }
        public bool WaitingForMove { get; set; }
        public bool LookingForOpponent { get; set; }

        public string TagGame { get; set; }

        public string ConnectionID { get; set; }

    }
}
