using System;
using System.Collections.Generic;

namespace ProjectForItransition.Models.Item
{
    public class IntegerElement : IComparable
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public ContentItem Item { get; set; }
        public static List<IntegerElement> CreateListIntegerElementWithValue(int[] values)
        {
            List<IntegerElement> integers = new List<IntegerElement>();
            if (values == null)
                return integers;
            foreach (var item in values)
            {
                integers.Add(new IntegerElement { Value = item });
            }
            return integers;
        }

        public int CompareTo(object obj)
        {
            IntegerElement integer = obj as IntegerElement;
            if (integer == null)
                throw new Exception("Can't compare two objects");
            return this.Value.CompareTo(integer.Value);
        }
    }
}
