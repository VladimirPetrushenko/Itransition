using ProjectForItransition.Models.Collection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectForItransition.ViewModels.Collection
{
    public class ShowCollectionViewModel
    {
        public ContentCollection Collection { get; set; }
        public string[] AllTags { get; set; }
        public string NameForFilter { get; set; }
        public string[] FilterTags { get; set; }
        public bool Filtration { get; set; }

        public ShowCollectionViewModel(ContentCollection collection, string[] allTags, bool filtration)
        {
            Collection = collection;
            AllTags = allTags;
            Filtration = filtration;
        }

        public ShowCollectionViewModel(ContentCollection collection, string[] allTags, string nameForFilter, string[] filterTags, bool filtration)
        {
            Collection = collection;
            AllTags = allTags;
            NameForFilter = nameForFilter;
            FilterTags = filterTags;
            Filtration = filtration;
        }
    }
}
