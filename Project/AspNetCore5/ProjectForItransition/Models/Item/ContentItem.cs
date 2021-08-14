using ProjectForItransition.Models.Collection;
using System.Collections.Generic;

namespace ProjectForItransition.Models.Item
{
    public class ContentItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Tag> Tags { get; set; }

        public List<IntegerElement> IntegerElements { get; set; } = new List<IntegerElement>();
        public List<StringElement> StringElements { get; set; } = new List<StringElement>();
        public List<MarkdownElement> MarkdownElements { get; set; } = new List<MarkdownElement>();
        public List<DateTimeOffsetElement> DateTimeElements { get; set; } = new List<DateTimeOffsetElement>();
        public List<CheckboxElement> CheckboxElements { get; set; } = new List<CheckboxElement>();

        public virtual ContentCollection Collection { get; set; }
    }
}
