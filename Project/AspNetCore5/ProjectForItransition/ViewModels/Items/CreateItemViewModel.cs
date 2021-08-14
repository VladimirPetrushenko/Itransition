using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectForItransition.Models;

namespace ProjectForItransition.ViewModels.Items
{
    public class CreateItemViewModel
    {
        public int? CollectionId { get; set; }
        public string Name { get; set; }
        public string[] Tags { get; set; }
        public int[] Checkboxes { get; set; }
        public DateTimeOffset[] Datetimes { get; set; }
        public int[] Integers { get; set; }
        public string[] Markdowns { get; set; }
        public string[] Strings { get; set; }
    }

    public static class CreateItemViewModelExtinsion
    {
        public static ContentItem CreateContentItem(this CreateItemViewModel model)
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
    }
    
}
