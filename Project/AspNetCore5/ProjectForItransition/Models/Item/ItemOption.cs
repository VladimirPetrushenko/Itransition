using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectForItransition.Models.Item
{
    public class ItemOption
    {
        public int Id { get; set; }
        public ContentItem Item {get;set;}
        public OptionElement Option { get; set; }
    }
}
