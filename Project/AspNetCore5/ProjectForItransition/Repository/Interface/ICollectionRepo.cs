using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectForItransition.Models;

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
    }
}
