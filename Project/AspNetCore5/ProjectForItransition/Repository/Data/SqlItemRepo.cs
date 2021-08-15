using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ProjectForItransition.Models.Item;
using ProjectForItransition.Repository.Interface;

namespace ProjectForItransition.Repository.Data
{
    public class SqlItemRepo : IItemRepo
    {
        private readonly ApplicationDbContext _context;
        public SqlItemRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public void CreateItem(ContentItem item, int collectionId)
        {
            var collection = _context.Collections.Where(col => col.Id == collectionId).FirstOrDefault();
            if(collection==null)
                throw new ArgumentException();
            collection.Items.Add(item);
        }

        public void DeleteItem(ContentItem item)
        {
            _context.Items.Remove(item);
        }

        public List<ContentItem> GetAllItem()
        {
            return _context.Items.Include(x=> x.Tags).ToList();
        }

        public ContentItem GetItemById(int itemId)
        {
            return _context.Items
                .Where(x => x.Id == itemId)
                .Include(x => x.IntegerElements)
                .Include(x => x.StringElements)
                .Include(x => x.MarkdownElements)
                .Include(x => x.CheckboxElements)
                .Include(x => x.DateTimeElements)
                .Include(x => x.Tags)
                .Include(x => x.Collection)
                .Include(x => x.Likes)
                .Include(x => x.Comments)
                .FirstOrDefault();
        }

        public bool SaveChange()
        {
            return _context.SaveChanges() >= 0;
        }

        public void UpdateItem(ContentItem item)
        {
            // nothing
        }
    }
}
