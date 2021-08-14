using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectForItransition.Models.Item
{
    public class CheckboxElement : IComparable
    {
        public int Id { get; set; }
        public bool Value { get; set; }
        public static List<CheckboxElement> CreateListCheckboxElementWithValue(bool[] values)
        {
            List<CheckboxElement> checkboxes = new List<CheckboxElement>();
            if (values == null)
                return checkboxes;
            foreach (var item in values)
            {
                checkboxes.Add(new CheckboxElement { Value = item });
            }
            return checkboxes;
        }
        public int CompareTo(object obj)
        {
            CheckboxElement box = obj as CheckboxElement;
            if (box == null)
                throw new Exception("Can't compare two objects");
            return this.Value.CompareTo(box.Value);
        }
        public static List<CheckboxElement> CreateListCheckboxElementFromIntArray(int[] checkboxes)
        {
            if (checkboxes == null)
                return CreateListCheckboxElementWithValue(new bool[0]);
            bool[] box = new bool[checkboxes.Max()];
            foreach (var index in checkboxes)
                box[index - 1] = true;
            return CreateListCheckboxElementWithValue(box);
        }
    }
}
