using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ProjectForItransition.Models.Item;
using ProjectForItransition.Repository.Interface;

namespace ProjectForItransition.Repository.Data
{
    public class SqlTagRepo : ITagRepo
    {
        private readonly ApplicationDbContext _context;
        public SqlTagRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<ContentItem> FreeTextOnNameTags(string search)
        {
            var tags = _context.Tags
                .Where(x => EF.Functions.FreeText(x.Name, search))
                .Include(x => x.Item)
                .Include(x => x.Item.Collection)
                .ToList();
            List<ContentItem> items = new List<ContentItem>();
            tags.ForEach(x => items.Add(x.Item));
            return items.Distinct();
        }

        public string[] GetAllDistinctTags()
        {
            return _context.Tags.Where(x => x.Item != null).Select(x => x.Name).Distinct().ToArray();
        }

        public string[] GetAllTags()
        {
            return _context.Tags.Where(x => x.Item != null).Select(x => x.Name).ToArray();
        }
    }
}
