using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task5.Data
{
    public interface ISqlMessageRepo
    {
        public bool CreateMessage(string message);
        public string GetAllMessages();
    }
}
