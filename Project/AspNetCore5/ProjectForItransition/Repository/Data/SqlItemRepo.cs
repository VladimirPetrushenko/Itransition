using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectForItransition.Data;
using ProjectForItransition.Models;
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
            _context.Tags.ToList();
            return _context.Items.ToList();
        }

        public ContentItem GetItemById(int itemId)
        {
            _context.IntegerElements.ToList();
            _context.StringElements.ToList();
            _context.MarkdownElements.ToList();
            _context.CheckboxElements.ToList();
            _context.DateTimeOffsetElements.ToList();
            _context.Tags.ToList();
            return _context.Items.Where(x => x.Id == itemId).FirstOrDefault();
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
