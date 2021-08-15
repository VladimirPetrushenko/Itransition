using ProjectForItransition.Models.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectForItransition.Repository.Interface
{
    public interface ILikeRepo
    {
        bool SaveChange();
        void CreateLike(Like like);
        void RemoveLike(Like like);
    }
}
