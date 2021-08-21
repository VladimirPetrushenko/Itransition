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

        public IEnumerable<ContentItem> FreeTextOnComment(string search)
        {
            _context.Tags.ToList();
            var comments = _context.Comment
                .Where(x => EF.Functions.FreeText(x.Value, search))
                .Include(x => x.Item)
                .Include(x => x.Item.Collection)
                .ToList();
            List<ContentItem> items = new List<ContentItem>();
            comments.ForEach(x => items.Add(x.Item));
            return items;
        }

        public IEnumerable<ContentItem> FreeTextOnMarkdown(string search)
        {
            _context.Tags.ToList();
            var markdowns = _context.MarkdownElements
                .Where(x => EF.Functions.FreeText(x.Value, search))
                .Include(x => x.Item)
                .Include(x => x.Item.Collection)
                .ToList();
            List<ContentItem> items = new List<ContentItem>();
            markdowns.ForEach(x => items.Add(x.Item));
            return items;
        }

        public IEnumerable<ContentItem> FreeTextOnNameItem(string search)
        {
            var items = _context.Items
                .Where(x => EF.Functions.FreeText(x.Name, search))
                .Include(x => x.Collection)
                .Include(x => x.Tags)
                .ToList();
            return items;
        }

        public IEnumerable<ContentItem> FreeTextOnString(string search)
        {
            _context.Tags.ToList();
            var strings = _context.StringElements
                .Where(x => EF.Functions.FreeText(x.Value, search))
                .Include(x => x.Item)
                .Include(x => x.Item.Collection)
                .ToList();
            List<ContentItem> items = new List<ContentItem>();
            strings.ForEach(x => items.Add(x.Item));
            return items;
        }

        public List<ContentItem> GetAllItem()
        {
            return _context.Items
                .Include(x => x.Collection)
                .Include(x => x.Tags)
                .ToList();
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
