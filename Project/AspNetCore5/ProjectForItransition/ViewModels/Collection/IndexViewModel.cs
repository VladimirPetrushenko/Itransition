using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectForItransition.Models;

namespace ProjectForItransition.ViewModels.Collection
{
    public class IndexViewModel
    {
        public IEnumerable<ContentItem> Items { get; set; }
        public IEnumerable<ContentCollection> Collections { get; set; }
        public List<TagCloudViewModel> Tags { get; set; }
    }

    public class TagCloudViewModel
    {
        public string Name { get; set; }
        public int Count { get; set; }
    }
}
