using ProjectForItransition.Models.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectForItransition.Models.Collection
{
    public class SelectElement
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<OptionElement> OptionElements { get; set; } = new List<OptionElement>();
        public static List<SelectElement> CreateListSelectElementWithNameAndOption(string[] SelectField, string[] Options, int[] CountSelect)
        {
            List<SelectElement> selects = new();
            var n = 0;
            for (int i = 0; i < SelectField.Length; i++)
            {
                SelectElement select = new() { Name = SelectField[i] };
                for (int j = 0; j < CountSelect[i]; j++, n++)
                {
                    var opt = new OptionElement { Value = Options[n] };
                    select.OptionElements.Add(opt);
                }
                selects.Add(select);
            }
            return selects;
        }
    }
}
