using System;
using System.ComponentModel.DataAnnotations;
using ProjectForItransition.Models.Collection;
using ProjectForItransition.Models.Item;

namespace ProjectForItransition.ViewModels.Items
{
    public class CreateItemViewModel : ItemViewModel
    {
        public int CollectionId { get; set; }
        public ContentCollection Collection { get; set; }
        public string[] AllTags { get; set; }
    }
}
