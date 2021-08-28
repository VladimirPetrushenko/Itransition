using ProjectForItransition.Models.Collection;
using ProjectForItransition.Models.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectForItransition.Models.Builder.Interface
{
    public interface IContentItemBuilder
    {
        IContentItemBuilder SetId(int id);
        IContentItemBuilder SetName(string name);
        IContentItemBuilder SetTags(string[] tags);
        IContentItemBuilder SetIntegerElements(int[] integers);
        IContentItemBuilder SetStringElements(string[] strings);
        IContentItemBuilder SetMarkdownElements(string[] markdowns);
        IContentItemBuilder SetDateTimeElements(DateTimeOffset[] datetimes);
        IContentItemBuilder SetCheckboxElements(int[] checkboxes);
        IContentItemBuilder SetOptionElements(List<OptionElement> optionElements);
        IContentItemBuilder SetComments(List<Comment> comments);
        IContentItemBuilder SetLikes(List<Like> likes);
        IContentItemBuilder SetCollection(ContentCollection collection);
        ContentItem Build();
    }
}
