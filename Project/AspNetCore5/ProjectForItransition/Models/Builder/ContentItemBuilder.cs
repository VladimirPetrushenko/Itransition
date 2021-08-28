using ProjectForItransition.Models.Builder.Interface;
using ProjectForItransition.Models.Collection;
using ProjectForItransition.Models.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectForItransition.Models.Builder
{
    public class ContentItemBuilder : IContentItemBuilder
    {
        private readonly ContentItem _item;
        public ContentItemBuilder()
        {
            _item = new ContentItem();
        }
        public ContentItem Build()
        {
            return _item;
        }

        public IContentItemBuilder SetCheckboxElements(int[] checkboxes)
        {
            _item.CheckboxElements = CheckboxElement.CreateListCheckboxElementFromIntArray(checkboxes);
            return this;
        }

        public IContentItemBuilder SetCollection(ContentCollection collection)
        {
            _item.Collection = collection;
            return this;
        }

        public IContentItemBuilder SetComments(List<Comment> comments)
        {
            _item.Comments = comments;
            return this;
        }

        public IContentItemBuilder SetDateTimeElements(DateTimeOffset[] datetimes)
        {
            _item.DateTimeElements = DateTimeOffsetElement.CreateListDateTimeOffsetElementWithValue(datetimes);
            return this;
        }

        public IContentItemBuilder SetId(int id)
        {
            _item.Id = id;
            return this;
        }

        public IContentItemBuilder SetIntegerElements(int[] integers)
        {
            _item.IntegerElements = IntegerElement.CreateListIntegerElementWithValue(integers);
            return this;
        }

        public IContentItemBuilder SetLikes(List<Like> likes)
        {
            _item.Likes = likes;
            return this;
        }

        public IContentItemBuilder SetMarkdownElements(string[] markdowns)
        {
            _item.MarkdownElements = MarkdownElement.CreateListMarkdownElementWithValue(markdowns);
            return this;
        }

        public IContentItemBuilder SetName(string name)
        {
            _item.Name = name;
            return this;
        }

        public IContentItemBuilder SetOptionElements(List<OptionElement> optionElements)
        {
            _item.OptionElements = optionElements;
            return this;
        }

        public IContentItemBuilder SetStringElements(string[] strings)
        {
            _item.StringElements = StringElement.CreateListStringElementWithValue(strings);
            return this;
        }

        public IContentItemBuilder SetTags(string[] tags)
        {
            _item.Tags = Tag.CreateTagsListFromArrayString(tags);
            return this;
        }
    }
}
