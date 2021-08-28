using ProjectForItransition.Models.Builder.Interface;
using ProjectForItransition.Models.Collection;
using ProjectForItransition.Models.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectForItransition.Models.Builder
{
    public class ContentCollectionBuilder : IContentCollectionBuilder
    {
        private readonly ContentCollection _collection;
        public ContentCollectionBuilder()
        {
            _collection = new ContentCollection();
        }
        public ContentCollection Build()
        {
            return _collection;
        }

        public IContentCollectionBuilder SetDescription(string description)
        {
            _collection.Description = description;
            return this;
        }

        public IContentCollectionBuilder SetId(int id)
        {
            _collection.Id = id;
            return this;
        }

        public IContentCollectionBuilder SetImage(ImageField image)
        {
            _collection.Image = image;
            return this;
        }

        public IContentCollectionBuilder SetItems(List<ContentItem> items)
        {
            _collection.Items = items;
            return this;
        }

        public IContentCollectionBuilder SetName(string name)
        {
            _collection.Name = name;
            return this;
        }

        public IContentCollectionBuilder SetNameElements(List<NameField> nameElements)
        {
            _collection.NameElements = nameElements;
            return this;
        }

        public IContentCollectionBuilder SetNameElements(string[] nameFields, TypeField[] types)
        {
            _collection.NameElements = nameFields == null ? new List<NameField>()
                : NameField.CreateListNameFieldWithNamesAndTypes(nameFields, types);
            return this;
        }

        public IContentCollectionBuilder SetSelectElements(List<SelectElement> selectElements)
        {
            _collection.SelectElements = selectElements;
            return this;
        }

        public IContentCollectionBuilder SetSelectElements(string[] selectField, string[] options, int[] countSelect)
        {
            _collection.SelectElements = selectField == null ? new List<SelectElement>() 
                : SelectElement.CreateListSelectElementWithNameAndOption(selectField, options, countSelect);
            return this;
        }

        public IContentCollectionBuilder SetTopic(Topic topic)
        {
            _collection.Topic = topic;
            return this;
        }

        public IContentCollectionBuilder SetUserId(string userId)
        {
            _collection.UserId = userId;
            return this;
        }

        public IContentCollectionBuilder SetUserName(string userName)
        {
            _collection.UserName = userName;
            return this;
        }        
    }
}
