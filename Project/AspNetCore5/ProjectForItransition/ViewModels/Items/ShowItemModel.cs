using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectForItransition.Models;

namespace ProjectForItransition.ViewModels.Items
{
    public class ShowItemModel
    {
        public ContentItem Item { get; set; }
        public List<NameField> Fields { get; set; }
        public int CollectionId { get; set; }
    }
}
