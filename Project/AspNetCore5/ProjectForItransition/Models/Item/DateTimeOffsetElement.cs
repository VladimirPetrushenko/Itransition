using System;
using System.Collections.Generic;

namespace ProjectForItransition.Models.Item
{
    public class DateTimeOffsetElement : IComparable
    {
        public int Id { get; set; }
        public DateTimeOffset Value { get; set; }
        public ContentItem Item { get; set; }
        public static List<DateTimeOffsetElement> CreateListDateTimeOffsetElementWithValue(DateTimeOffset[] values)
        {
            List<DateTimeOffsetElement> dateTimeOffsetElements = new ();
            if (values == null)
                return dateTimeOffsetElements;
            foreach (var item in values)
            {
                dateTimeOffsetElements.Add(new DateTimeOffsetElement { Value = item });
            }
            return dateTimeOffsetElements;
        }
        public int CompareTo(object obj)
        {
            if (obj is not DateTimeOffsetElement date)
                throw new Exception("Can't compare two objects");
            return this.Value.CompareTo(date.Value);
        }
    }
}
