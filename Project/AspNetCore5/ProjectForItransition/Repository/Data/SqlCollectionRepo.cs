using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using ProjectForItransition.Repository.Interface;
using ProjectForItransition.Models.Collection;
using ProjectForItransition.Models.Item;

namespace ProjectForItransition.Repository.Data
{
    public class SqlCollectionRepo : ICollectionRepo
    {
        private readonly ApplicationDbContext _context;
        public SqlCollectionRepo(ApplicationDbContext context)
        {
            _context = context;
        }
        public void CreateCollection(ContentCollection collection)
        {
             _context.Add(collection);
        }


        public void DeleteCollection(ContentCollection collection)
        {
            _context.Collections.Remove(collection);
        }

        public List<ContentCollection> GetAllCollections()
        {
            return _context.Collections
                    .Include(x => x.NameElements)
                    .Include(x=>x.Image)
                    .Include(x=> x.Items)
                    .Include(x => x.SelectElements)
                    .ToList();
        }

        public ContentCollection GetCollectionById(int id)
        {
            LoadItemCustomFields();
            LoadTags();
            return _context.Collections
                .Include(x => x.NameElements)
                .Include(x => x.Items)
                .Include(x => x.Image)
                .Include(x => x.SelectElements)
                .FirstOrDefault(x => x.Id == id);
        }

        private void LoadItemCustomFields()
        {
            _ = _context.IntegerElements.ToList();
            _ = _context.StringElements.ToList();
            _ = _context.MarkdownElements.ToList();
            _ = _context.CheckboxElements.ToList();
            _ = _context.DateTimeOffsetElements.ToList();
            _ = _context.OptionElements.ToList();
        }

        public bool SaveChange()
        {
            return _context.SaveChanges() >= 0;
        }

        public void UpdateCollection(ContentCollection collection)
        {
            // nothing
        }

        public List<ContentCollection> GetAllUserCollections(string userId)
        {
            return _context.Collections.Include(x => x.NameElements)
                .Where(x => x.UserId == userId)
                .Include(x => x.Items)
                .Include(x => x.Image)
                .ToList();
        }

        public IEnumerable<ContentItem> FreeTextOnDescription(string search)
        {
            LoadTags();
            var collection = _context.Collections
                .Where(x => EF.Functions.FreeText(x.Description, search))
                .Include(x => x.Items).ToList();
            List<ContentItem> items = new();
            collection.ForEach(x => { items.AddRange(x.Items.ToList()); });
            return items;
        }

        public IEnumerable<ContentItem> FreeTextOnNameCollection(string search)
        {
            LoadTags();
            var collection = _context.Collections
                .Where(x => EF.Functions.FreeText(x.Name, search))
                .Include(x => x.Items).ToList();
            List<ContentItem> items = new();
            collection.ForEach(x => { items.AddRange(x.Items.ToList()); });
            return items;
        }

        private void LoadTags()
        {
            _ = _context.Tags.ToList();
        }
    }
}
