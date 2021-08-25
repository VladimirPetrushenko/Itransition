using Microsoft.AspNetCore.Http;
using ProjectForItransition.Models.Collection;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectForItransition.ViewModels.Collection
{
    public class CreateCollectionViewModel
    {
        [Required]
        public string Name { get; set; }
        public Topic Topic { get; set; }
        [MaxLength(800)]
        public string Description { get; set; }
        public string UserName { get; set; }
        [NameFieldsAttribute]
        public string[] NameFields { get; set; }
        public TypeField[] Types { get; set; }
        public IFormFile ImageInput { get; set; }
    }
}
