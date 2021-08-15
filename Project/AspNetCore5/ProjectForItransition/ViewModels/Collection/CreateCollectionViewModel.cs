using Microsoft.AspNetCore.Http;
using ProjectForItransition.Models.Collection;

namespace ProjectForItransition.ViewModels.Collection
{
    public class CreateCollectionViewModel
    {
        public string[] Names { get; set; }
        public TypeField[] Types { get; set; }
        public IFormFile ImageInput { get; set; }
    }
}
