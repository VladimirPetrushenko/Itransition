using System.Collections.Generic;
using ProjectForItransition.Models.Collection;
using ProjectForItransition.Models.Item;

namespace ProjectForItransition.ViewModels.Items
{
    public class ShowItemModel
    {
        public ContentItem Item { get; set; }
        public List<NameField> Fields { get; set; }
        public int CollectionId { get; set; }
        public string[] AllTags { get; set; }
    }
}
