using ProjectForItransition.Models.Collection;
using ProjectForItransition.Models.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectForItransition.Models.Builder.Interface
{
    public interface IContentCollectionBuilder
    {
        IContentCollectionBuilder SetId(int id);
        IContentCollectionBuilder SetName(string name);
        IContentCollectionBuilder SetUserId(string userId);
        IContentCollectionBuilder SetUserName(string userName);
        IContentCollectionBuilder SetDescription(string description);
        IContentCollectionBuilder SetImage(ImageField image);
        IContentCollectionBuilder SetTopic(Topic topic);
        IContentCollectionBuilder SetItems(List<ContentItem> items);
        IContentCollectionBuilder SetNameElements(List<NameField> nameElements);
        IContentCollectionBuilder SetNameElements(string[] nameFields, TypeField[] types);
        IContentCollectionBuilder SetSelectElements(List<SelectElement> selectElements);
        IContentCollectionBuilder SetSelectElements(string[] selectField, string[] options, int[] countSelect);
        ContentCollection Build();
    }
}
