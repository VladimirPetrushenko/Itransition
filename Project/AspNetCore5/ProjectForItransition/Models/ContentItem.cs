using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectForItransition.Models
{
    public class ContentItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Tag> Tags { get; set; }

        public List<IntegerElement> IntegerElements { get; set; } = new List<IntegerElement>();
        public List<StringElement> StringElements { get; set; } = new List<StringElement>();
        public List<MarkdownElement> MarkdownElements { get; set; } = new List<MarkdownElement>();
        public List<DateTimeOffsetElement> DateTimeElements { get; set; } = new List<DateTimeOffsetElement>();
        public List<CheckboxElement> CheckboxElements { get; set; } = new List<CheckboxElement>();

        public virtual ContentCollection Collection { get; set; }
    }

    public class Tag : IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static List<Tag> CreateTagsListFromString(string values)
        {
            List<Tag> tags = new List<Tag>();
            if (string.IsNullOrEmpty(values))
                return tags;
            foreach (var tag in values.Split(" ").Select(x=>x.Trim()))
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

    public enum SortState
    {
        ItemName,
        ItemName_desc, 
        Tags,
        Tags_desc,
        Date,
        Date_desc,
        Integer,
        Integer_desc,
        String,
        String_desc,
        Markdown,
        Markdown_desc,
        Checkbox,
        Checkbox_desc
    }
}
