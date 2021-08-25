using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectForItransition.Models.Item
{
    public class StringElement : IComparable
    {
        public int Id { get; set; }
        [MaxLength(800)]
        public string Value { get; set; }
        public ContentItem Item { get; set; }
        public static List<StringElement> CreateListStringElementWithValue(string[] values)
        {
            List<StringElement> strings = new();
            if (values == null)
                return strings;
            foreach (var item in values)
            {
                strings.Add(new StringElement { Value = item });
            }
            return strings;
        }
        public int CompareTo(object obj)
        {
            if (obj is not StringElement str)
                throw new Exception("Can't compare two objects");
            return this.Value.CompareTo(str.Value);
        }
    }
}
