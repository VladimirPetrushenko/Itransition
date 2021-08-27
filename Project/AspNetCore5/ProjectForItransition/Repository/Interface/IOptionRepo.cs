using ProjectForItransition.Models.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectForItransition.Repository.Interface
{
    public interface IOptionRepo
    {
        OptionElement GetOptionElementById(int itemId);
    }
}
