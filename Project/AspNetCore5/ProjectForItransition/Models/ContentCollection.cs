﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectForItransition.Models
{
    public class ContentCollection
    {
        public int Id { get; set; }
        [MaxLength(60)]
        public string Name { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Description { get; set; }
        public Topic Topic { get; set; }
        public List<ContentItem> Items { get; set; } = new List<ContentItem>();

        public List<NameField> NameElements { get; set; } = new List<NameField>();

        internal ContentCollection where(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }

    public enum Topic
    {
        Alcohol,
        Books,
        Movie,
        Food
    }
}
