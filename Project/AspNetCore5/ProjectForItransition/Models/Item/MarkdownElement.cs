using System;
using System.Collections.Generic;

namespace ProjectForItransition.Models.Item
{
    public class MarkdownElement : IComparable
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public static List<MarkdownElement> CreateListMarkdownElementWithValue(string[] values)
        {
            List<MarkdownElement> markdowns = new List<MarkdownElement>();
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
            MarkdownElement mrkd = obj as MarkdownElement;
            if (mrkd == null)
                throw new Exception("Can't compare two objects");
            return this.Value.CompareTo(mrkd.Value);
        }
    }
}
