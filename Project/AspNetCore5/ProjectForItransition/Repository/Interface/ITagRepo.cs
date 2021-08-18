using ProjectForItransition.Models.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectForItransition.Repository.Interface
{
    public interface ITagRepo
    {
        string[] GetAllDistinctTags();
        string[] GetAllTags();
        IEnumerable<ContentItem> FreeTextOnNameTags(string search);
    }
}
