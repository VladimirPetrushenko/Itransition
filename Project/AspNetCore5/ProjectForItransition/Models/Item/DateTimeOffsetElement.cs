using System;
using System.Collections.Generic;

namespace ProjectForItransition.Models.Item
{
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
}
