using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectForItransition.Models.Item
{
    public class Comment
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public DateTime Date { get; set; }
        public string Value { get; set; }

        public ContentItem Item { get; set; }
    }
}
