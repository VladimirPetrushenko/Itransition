using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectForItransition.Models.Item
{
    public class CheckboxElement : IComparable
    {
        public int Id { get; set; }
        public bool Value { get; set; }
        public ContentItem Item { get; set; }
        public static List<CheckboxElement> CreateListCheckboxElementWithValue(bool[] values)
        {
            List<CheckboxElement> checkboxElements = new();
            if (values == null)
                return checkboxElements;
            foreach (var item in values)
            {
                checkboxElements.Add(new CheckboxElement { Value = item });
            }
            return checkboxElements;
        }
        public int CompareTo(object obj)
        {
            if (obj is not CheckboxElement box)
                throw new Exception("Can't compare two objects");
            return this.Value.CompareTo(box.Value);
        }
        public static List<CheckboxElement> CreateListCheckboxElementFromIntArray(int[] checkboxes)
        {
            if (checkboxes == null)
                return CreateListCheckboxElementWithValue(Array.Empty<bool>());
            bool[] box = new bool[checkboxes.Max()];
            foreach (var index in checkboxes)
                box[index - 1] = true;
            return CreateListCheckboxElementWithValue(box);
        }
    }
}
