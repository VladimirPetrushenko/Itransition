using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectForItransition.Models.Item
{
    public class OptionElement
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public static List<OptionElement> CreateListSelectElementWithValue(string[] values)
        {
            List<OptionElement> strings = new();
            if (values == null)
                return strings;
            foreach (var item in values)
            {
                strings.Add(new OptionElement { Value = item });
            }
            return strings;
        }
        public int CompareTo(object obj)
        {
            if (obj is not OptionElement str)
                throw new Exception("Can't compare two objects");
            return this.Value.CompareTo(str.Value);
        }
    }
}
