using Microsoft.AspNetCore.SignalR;
using ProjectForItransition.Models.Item;
using ProjectForItransition.Repository.Interface;
using ProjectForItransition.ViewModels.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectForItransition
{
    public class ItemHub : Hub
    {
        private readonly IItemRepo _itemRepo;
        private readonly ILikeRepo _likeRepo;

        public ItemHub(IItemRepo itemRepo, ILikeRepo likeRepo)
        {
            _itemRepo = itemRepo;
            _likeRepo = likeRepo;
        }

        public async Task Like(string itemId, string userName)
        {
            var item = _itemRepo.GetItemById(int.Parse(itemId));
            CheckLikes(userName, item);

            _itemRepo.UpdateItem(item);
            _itemRepo.SaveChange();
            
            var likeCount = item.Likes?.Count;
            var userLike = item.Likes?.Where(x => x.UserName == userName).Count();

            await this.Clients.All.SendAsync("Likes", likeCount, userLike);
        }

        private void CheckLikes(string userName, ContentItem item)
        {
            if (!item.Likes.Where(x => x.UserName == userName).Any())
            {
                item.Likes.Add(new Like { UserName = userName });
            }
            else
            {
                _likeRepo.RemoveLike(item.Likes.Where(x => x.UserName == userName).First());
            }
        }

        public async Task Comments(string itemId, string userName, string comment)
        {
            var item = _itemRepo.GetItemById(int.Parse(itemId));
            if (comment != null)
                item.Comments.Add(new Comment { Date = DateTime.Now, UserName = userName, Value = comment });

            _itemRepo.UpdateItem(item);
            _itemRepo.SaveChange();

            await this.Clients.All.SendAsync("Comments", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), userName, comment);
        }
    }
}
