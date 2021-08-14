using System.Collections.Generic;
using ProjectForItransition.Models.Item;

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
