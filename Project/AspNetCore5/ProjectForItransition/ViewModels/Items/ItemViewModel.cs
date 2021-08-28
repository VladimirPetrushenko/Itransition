using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectForItransition.ViewModels.Items
{
    public abstract class ItemViewModel
    {
        [Required]
        public string Name { get; set; }
        public string[] Tags { get; set; }
        public int[] Checkboxes { get; set; }
        public DateTimeOffset[] Datetimes { get; set; }
        public int[] Integers { get; set; }
        public string[] Markdowns { get; set; }
        public string[] Strings { get; set; }
        public int[] Options { get; set; }
    }
}
