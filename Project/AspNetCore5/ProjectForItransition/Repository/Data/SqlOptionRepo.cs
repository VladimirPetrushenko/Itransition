using ProjectForItransition.Models.Item;
using ProjectForItransition.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectForItransition.Repository.Data
{
    public class SqlOptionRepo : IOptionRepo
    {
        private readonly ApplicationDbContext _context;
        public SqlOptionRepo(ApplicationDbContext context)
        {
            _context = context;
        }
        public OptionElement GetOptionElementById(int itemId)
        {
            return _context.OptionElements.Where(x => x.Id == itemId).FirstOrDefault();
        }
    }
}
