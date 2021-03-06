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
            collection.Items.Add(item);
        }

        public void DeleteItem(ContentItem item)
        {
            _context.Items.Remove(item);
        }

        public IEnumerable<ContentItem> FreeTextOnComment(string search)
        {
            LoadTags();
            var comments = _context.Comment
                .Where(x => EF.Functions.FreeText(x.Value, search) && x.Item != null)
                .Include(x => x.Item)
                .Include(x => x.Item.Collection)
                .ToList();
            List<ContentItem> items = new();
            comments.ForEach(x => items.Add(x.Item));
            return items;
        }

        public IEnumerable<ContentItem> FreeTextOnMarkdown(string search)
        {
            LoadTags();
            var markdowns = _context.MarkdownElements
                .Where(x => EF.Functions.FreeText(x.Value, search) && x.Item != null)
                .Include(x => x.Item)
                .Include(x => x.Item.Collection)
                .ToList();
            List<ContentItem> items = new();
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
            LoadTags();
            var strings = _context.StringElements
                .Where(x => EF.Functions.FreeText(x.Value, search) && x.Item != null)
                .Include(x => x.Item)
                .Include(x => x.Item.Collection)
                .ToList();
            List<ContentItem> items = new();
            strings.ForEach(x => items.Add(x.Item));
            return items;
        }

        private void LoadTags()
        {
            _ = _context.Tags.ToList();
        }

        public List<ContentItem> GetAllItem()
        {
            return _context.Items
                .Include(x => x.Collection)
                .Include(x => x.Tags)
                .Where(x => x.Collection != null)
                .ToList();
        }

        public ContentItem GetItemById(int itemId)
        {
            _ = _context.OptionElements.ToList();
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
                .Include(x => x.ItemOptions)
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
