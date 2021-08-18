using System.Collections.Generic;
using ProjectForItransition.Models.Collection;

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
        List<ContentCollection> FreeTextOnDescription(string search);
    }
}
