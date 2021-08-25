using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ProjectForItransition.Models.Item
{
    public class Tag : IComparable
    {
        public int Id { get; set; }
        [MaxLength(800)]
        public string Name { get; set; }
        public ContentItem Item { get; set; }

        public static List<Tag> CreateTagsListFromString(string values)
        {
            List<Tag> tags = new();
            if (string.IsNullOrEmpty(values))
                return tags;
            foreach (var tag in values.Split(" ").Select(x => x.Trim()))
            {
                tags.Add(new Tag { Name = tag });
            }
            return tags;
        }
        public static List<Tag> CreateTagsListFromArrayString(string[] values)
        {
            List<Tag> tags = new();
            if (values == null)
                return tags;
            foreach (var tag in values.Select(x => x.Trim()))
            {
                tags.Add(new Tag { Name = tag });
            }
            return tags;
        }
        public int CompareTo(object obj)
        {
            if (obj is not Tag t)
                throw new Exception("Can't compare two objects");
            return this.Name.CompareTo(t.Name);
        }
    }
}
