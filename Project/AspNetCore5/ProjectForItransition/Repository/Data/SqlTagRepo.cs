using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectForItransition.Data;
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

        public string[] GetAllDistinctTags()
        {
            return _context.Tags.Select(x => x.Name).Distinct().ToArray();
        }

        public string[] GetAllTags()
        {
            return _context.Tags.Select(x => x.Name).ToArray();
        }
    }
}
