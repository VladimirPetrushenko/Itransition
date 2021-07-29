using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task5.Models;

namespace Task5.Data
{
    public class SqlMessageRepo : ISqlMessageRepo
    {
        private readonly ApplicationContext _context;

        public SqlMessageRepo(ApplicationContext context)
        {
            _context = context;
        }

        public bool CreateMessage(string message)
        {
            if (message == null)
            {
                throw new ArgumentException(nameof(SqlMessageRepo));
            }
            var remove = _context.Messages.FirstOrDefault();
            if (remove != null)
                _context.Messages.Remove(remove);
            _context.Messages.Add(new Message { Value = message });
            return _context.SaveChanges() >= 0;
        }

        public string GetAllMessages()
        {
            var m = String.Empty;
            try
            {
                m = _context.Messages.FirstOrDefault().Value;
            }
            catch (Exception e)
            {

                throw;
            }
            return m;
        }
    }
}
