using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using Task5.Data;

namespace Task5
{
    public class PaintHub : Hub
    {
        private readonly ISqlMessageRepo _repository;

        public PaintHub(ISqlMessageRepo repository)
        {
            _repository = repository;
        }

        public async Task Send(string message)
        {
            _repository.CreateMessage(message);
            await this.Clients.Others.SendAsync("Send", message);
        }

        public override async Task OnConnectedAsync()
        {
            await this.Clients.Caller.SendAsync("Send", _repository.GetAllMessages());
        }
    }
}
