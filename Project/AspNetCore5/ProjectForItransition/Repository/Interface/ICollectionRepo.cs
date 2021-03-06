using System.Collections.Generic;
using ProjectForItransition.Models.Collection;
using ProjectForItransition.Models.Item;

namespace ProjectForItransition.Repository.Interface
{
    public interface ICollectionRepo
    {
        bool SaveChange();
        ContentCollection GetCollectionById(int id);
        List<ContentCollection> GetAllCollections();
        void CreateCollection(ContentCollection collection);
        void UpdateCollection(ContentCollection collection);
        void DeleteCollection(ContentCollection collection);
        List<ContentCollection> GetAllUserCollections(string userId);
        IEnumerable<ContentItem> FreeTextOnDescription(string search);
        IEnumerable<ContentItem> FreeTextOnNameCollection(string search);
    }
}
