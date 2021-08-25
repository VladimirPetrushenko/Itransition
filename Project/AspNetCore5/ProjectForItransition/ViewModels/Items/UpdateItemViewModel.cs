using System;
using ProjectForItransition.Models.Item;

namespace ProjectForItransition.ViewModels.Items
{
    public class UpdateItemViewModel
    {
        public int? CollectionId { get; set; }
        public int? ItemId { get; set; }
        public string Name { get; set; }
        public string[] Tags { get; set; }
        public int[] Checkboxes { get; set; }
        public DateTimeOffset[] Datetimes { get; set; }
        public int[] Integers { get; set; }
        public string[] Markdowns { get; set; }
        public string[] Strings { get; set; }
    }

    public static class UpdateItemViewModelExtinsion
    {
        public static ContentItem CreateContentItem(this UpdateItemViewModel model)
        {
            ContentItem item = new()
            {
                Name = model.Name,
                Tags = Tag.CreateTagsListFromArrayString(model.Tags),
                CheckboxElements = CheckboxElement.CreateListCheckboxElementFromIntArray(model.Checkboxes),
                DateTimeElements = DateTimeOffsetElement.CreateListDateTimeOffsetElementWithValue(model.Datetimes),
                StringElements = StringElement.CreateListStringElementWithValue(model.Strings),
                MarkdownElements = MarkdownElement.CreateListMarkdownElementWithValue(model.Markdowns),
                IntegerElements = IntegerElement.CreateListIntegerElementWithValue(model.Integers)
            };
            return item;
        }
        public static void CopyTo(this ContentItem source, ContentItem destination)
        {
            destination.Name = source.Name;
            destination.Tags = source.Tags;
            destination.CheckboxElements = source.CheckboxElements;
            destination.DateTimeElements = source.DateTimeElements;
            destination.StringElements = source.StringElements;
            destination.MarkdownElements = source.MarkdownElements;
            destination.IntegerElements = source.IntegerElements;
        }
    }

}
