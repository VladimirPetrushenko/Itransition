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
            CheckCollectionForNull(collection);

            _context.Add(collection);
        }

        private static void CheckCollectionForNull(ContentCollection collection)
        {
            if (collection == null)
            {
                throw new ArgumentException(nameof(collection));
            }
        }

        public void DeleteCollection(ContentCollection collection)
        {
            CheckCollectionForNull(collection);
            _context.Collections.Remove(collection);
        }

        public List<ContentCollection> GetAllCollections()
        {
            return _context.Collections
                            .Include(x => x.NameElements)
                            .Include(x=>x.Image)
                            .Include(x=> x.Items)
                            .ToList();
        }

        public ContentCollection GetCollectionById(int id)
        {
            _context.IntegerElements.ToList();
            _context.StringElements.ToList();
            _context.MarkdownElements.ToList();
            _context.CheckboxElements.ToList();
            _context.DateTimeOffsetElements.ToList();
            _context.Tags.ToList();
            return _context.Collections
                .Include(x => x.NameElements)
                .Include(x => x.Items)
                .Include(x => x.Image)
                .FirstOrDefault(x => x.Id == id);
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
            if (userId == null)
            {
                throw new ArgumentException();
            }
            return _context.Collections.Include(x => x.NameElements)
                .Where(x => x.UserId == userId)
                .Include(x => x.Items)
                .Include(x => x.Image)
                .ToList();
        }

        public IEnumerable<ContentItem> FreeTextOnDescription(string search)
        {
            _context.Tags.ToList();
            var collection = _context.Collections
                .Where(x => EF.Functions.FreeText(x.Description, search))
                .Include(x => x.Items).ToList();
            List<ContentItem> items = new List<ContentItem>();
            collection.ForEach(x => { items.AddRange(x.Items.ToList()); });
            return items;
        }

        public IEnumerable<ContentItem> FreeTextOnNameCollection(string search)
        {
            _context.Tags.ToList();
            var collection = _context.Collections
                .Where(x => EF.Functions.FreeText(x.Name, search))
                .Include(x => x.Items).ToList();
            List<ContentItem> items = new List<ContentItem>();
            collection.ForEach(x => { items.AddRange(x.Items.ToList()); });
            return items;
        }
    }
}
