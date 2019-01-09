using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleApi.Models;

namespace SimpleApi.Services
{
    public interface IItemService
    {
        Item AddItem(Item item);
        Dictionary<string, Item> GetItem();
    }
}
