using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectForItransition.Models.Item
{
    public class MarkdownElement : IComparable
    {
        public int Id { get; set; }
        [MaxLength(1600)]
        public string Value { get; set; }
        public ContentItem Item { get; set; }
        public static List<MarkdownElement> CreateListMarkdownElementWithValue(string[] values)
        {
            List<MarkdownElement> markdowns = new();
            if (values == null)
                return markdowns;
            foreach (var item in values)
            {
                markdowns.Add(new MarkdownElement { Value = item });
            }
            return markdowns;
        }
        public int CompareTo(object obj)
        {
            if (obj is not MarkdownElement mrkd)
                throw new Exception("Can't compare two objects");
            return this.Value.CompareTo(mrkd.Value);
        }
    }
}
