using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectForItransition.Models.Item
{
    public class Tag : IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static List<Tag> CreateTagsListFromString(string values)
        {
            List<Tag> tags = new List<Tag>();
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
            List<Tag> tags = new List<Tag>();
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
            Tag t = obj as Tag;
            if (t == null)
                throw new Exception("Can't compare two objects");
            return this.Name.CompareTo(t.Name);
        }
    }
}
