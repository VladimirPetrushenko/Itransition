using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectForItransition
{
    public class NameFieldsAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value is string[] n)
            {
                foreach (var item in n)
                {
                    if (item == null)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
