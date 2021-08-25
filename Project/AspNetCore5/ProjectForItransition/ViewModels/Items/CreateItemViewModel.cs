using System;
using System.ComponentModel.DataAnnotations;
using ProjectForItransition.Models.Collection;
using ProjectForItransition.Models.Item;

namespace ProjectForItransition.ViewModels.Items
{
    public class CreateItemViewModel
    {
        public int CollectionId { get; set; }
        public ContentCollection Collection { get; set; }
        public string[] AllTags { get; set; }
        [Required]
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
    }
    
}
