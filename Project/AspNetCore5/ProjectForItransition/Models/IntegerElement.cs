using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectForItransition.Models
{
    public class IntegerElement : IComparable
    {
        public int Id { get; set; }
        public int Value { get; set; }
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
    public class StringElement : IComparable
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public static List<StringElement> CreateListStringElementWithValue(string[] values)
        {
            List<StringElement> strings = new List<StringElement>();
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
            StringElement str = obj as StringElement;
            if (str == null)
                throw new Exception("Can't compare two objects");
            return this.Value.CompareTo(str.Value);
        }
    }
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
    public class DateTimeOffsetElement : IComparable
    {
        public int Id { get; set; }
        public DateTimeOffset Value { get; set; }
        public static List<DateTimeOffsetElement> CreateListDateTimeOffsetElementWithValue(DateTimeOffset[] values)
        {
            List<DateTimeOffsetElement> dates = new List<DateTimeOffsetElement>();
            if (values == null)
                return dates;
            foreach (var item in values)
            {
                dates.Add(new DateTimeOffsetElement { Value = item });
            }
            return dates;
        }
        public int CompareTo(object obj)
        {
            DateTimeOffsetElement date = obj as DateTimeOffsetElement;
            if (date == null)
                throw new Exception("Can't compare two objects");
            return this.Value.CompareTo(date.Value);
        }
    }
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
            if(checkboxes==null)
                return CreateListCheckboxElementWithValue(new bool[0]);
            bool[] box = new bool[checkboxes.Max()];
            foreach (var index in checkboxes)
                box[index - 1] = true;
            return CreateListCheckboxElementWithValue(box);
        }
    }
}
