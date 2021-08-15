using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace ProjectForItransition.Models.Collection
{
    public class ImageField
    {
        [Key]
        public int Id { get; set; }
        public string PublicId { get; set; }
    }
}
