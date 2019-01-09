using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleApi.Models;

namespace SimpleApi.Services
{
    public class ItemService : IItemService
    {
        private readonly Dictionary<string, Item> _items;
        public ItemService()
        {
            _items = new Dictionary<string, Item>();
        }
        public Item AddItem(Item item)
        {
            _items.Add(item.Name, item);
            return item;
            //throw new NotImplementedException();
        }

        public Dictionary<string, Item> GetItem()
        {
            return _items;
            //throw new NotImplementedException();
        }
    }
}
