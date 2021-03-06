using ProjectForItransition.Models.Collection;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectForItransition.Models.Item
{
    public class ContentItem
    {
        public int Id { get; set; }
        [MaxLength(800)]
        public string Name { get; set; }
        public List<Tag> Tags { get; set; }
        public List<IntegerElement> IntegerElements { get; set; } = new List<IntegerElement>();
        public List<StringElement> StringElements { get; set; } = new List<StringElement>();
        public List<MarkdownElement> MarkdownElements { get; set; } = new List<MarkdownElement>();
        public List<DateTimeOffsetElement> DateTimeElements { get; set; } = new List<DateTimeOffsetElement>();
        public List<CheckboxElement> CheckboxElements { get; set; } = new List<CheckboxElement>(); 
        public List<ItemOption> ItemOptions { get; set; } = new List<ItemOption>(); 
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public virtual List<Like> Likes { get; set; } = new List<Like>();
        public virtual ContentCollection Collection { get; set; }
    }

    public static class ContentItemExtinsion
    {
        public static void CopyTo(this ContentItem source, ContentItem destination)
        {
            destination.Name = source.Name;
            destination.Tags = source.Tags;
            destination.CheckboxElements = source.CheckboxElements;
            destination.DateTimeElements = source.DateTimeElements;
            destination.StringElements = source.StringElements;
            destination.MarkdownElements = source.MarkdownElements;
            destination.IntegerElements = source.IntegerElements;
            destination.ItemOptions = source.ItemOptions;
        }
    }
}
