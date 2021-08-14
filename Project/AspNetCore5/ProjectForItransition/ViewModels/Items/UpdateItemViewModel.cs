using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectForItransition.Models;

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
            ContentItem item = new ContentItem();
            item.Name = model.Name;
            item.Tags = Tag.CreateTagsListFromArrayString(model.Tags);
            item.CheckboxElements = CheckboxElement.CreateListCheckboxElementFromIntArray(model.Checkboxes);
            item.DateTimeElements = DateTimeOffsetElement.CreateListDateTimeOffsetElementWithValue(model.Datetimes);
            item.StringElements = StringElement.CreateListStringElementWithValue(model.Strings);
            item.MarkdownElements = MarkdownElement.CreateListMarkdownElementWithValue(model.Markdowns);
            item.IntegerElements = IntegerElement.CreateListIntegerElementWithValue(model.Integers);
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
