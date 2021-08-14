using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ProjectForItransition.Models.Collection
{
    public class NameField
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public TypeField Type { get; set; }

        public static List<NameField> CreateListNameFieldWithNamesAndTypes(string[] names, TypeField[] types)
        {
            if (names.Count() != types.Count())
                throw new ArgumentException("The number of species and names does not match");
            List<NameField> nameFields = new List<NameField>();
            for (int i = 0; i < names.Length; i++)
            {
                nameFields.Add(new NameField { Name = names[i], Type = types[i] });
            }
            return nameFields;
        }
    }
}
