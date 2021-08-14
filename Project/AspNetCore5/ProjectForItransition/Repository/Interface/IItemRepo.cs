using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectForItransition.Models;

namespace ProjectForItransition.Repository.Interface
{
    public interface IItemRepo
    {
        bool SaveChange();
        ContentItem GetItemById(int itemId);
        List<ContentItem> GetAllItem();
        void CreateItem(ContentItem item, int collectionId);
        void UpdateItem(ContentItem item);
        void DeleteItem(ContentItem item);
    }
}
