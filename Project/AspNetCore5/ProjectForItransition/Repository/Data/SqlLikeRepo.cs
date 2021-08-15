using ProjectForItransition.Models.Item;
using ProjectForItransition.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectForItransition.Repository.Data
{
    public class SqlLikeRepo : ILikeRepo
    {
        private readonly ApplicationDbContext _context;
        public SqlLikeRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public void CreateLike(Like like)
        {
            _context.Likes.Add(like);
        }

        public void RemoveLike(Like like)
        {
            _context.Likes.Remove(like);
        }

        public bool SaveChange()
        {
            return _context.SaveChanges() >= 0;
        }
    }
}
