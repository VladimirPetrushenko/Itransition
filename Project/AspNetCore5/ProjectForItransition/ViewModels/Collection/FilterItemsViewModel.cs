using System;
using System.Linq;
using ProjectForItransition.Models;
using ProjectForItransition.Models.Collection;

namespace ProjectForItransition.ViewModels.Collection
{
    public class FilterItemsViewModel
    {
        public int? CollectionId { get; set; }
        public string NameForFilter { get; set; }
        public string[] TagsForFilter { get; set; }
        public SortState sort { get; set; }
    }

    public static class FilterByNameAndTagsExtinsion
    {
        public static void FilterByNameAndTags(this FilterItemsViewModel source, ContentCollection collection)
        {
            if (!string.IsNullOrEmpty(source.NameForFilter))
                collection.Items = collection.Items.Where(x => x.Name.ToLower().Contains(source.NameForFilter.ToLower())).ToList();
            if (source.TagsForFilter != null)
            {
                foreach (var tag in source.TagsForFilter.Select(x=>x.ToLower().Trim()))
                {
                    collection.Items = collection.Items
                        .Where(x => x.Tags
                            .Select(t => t.Name.ToLower().Contains(tag))
                            .Contains(true))
                        .ToList();
                }
            }
        }
    }
}
