using Microsoft.AspNetCore.Http;
using ProjectForItransition.Models.Collection;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectForItransition.ViewModels.Collection
{
    public class UpdateCollectionViewModel : CollectionViewModel
    {
        public int CollectionId { get; set; }
        public ContentCollection Collection { get; set; }
    }
}
