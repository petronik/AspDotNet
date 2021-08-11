using AspDotNetWebApplication.Data.Interfaces;
using AspDotNetWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspDotNetWebApplication.Data.MockRepo
{
    public class MockItemRepo : IItemRepo
    {
        private static List<Item> _items = new List<Item>
        {
            new Item{ Id = 101, Name = "Boiled Water", Price = 15.55},
            new Item{ Id = 102, Name = "Fresh Stones", Price = 19.99},
            new Item{ Id = 101, Name = "Boiled Water", Price = 2.22}
        };
        public void CreateItem(Item input)
        {
            _items.Add(input);
        }

        public void DeleteItem(int id)
        {
            var itemToDelete = _items.FirstOrDefault(i => i.Id == id);
            if (itemToDelete != null)
                _items.Remove(itemToDelete);
        }

        public IEnumerable<Item> GetAllItems()
        {
            return _items;
        }

        public Item GetItemById(int id)
        {            
            return _items.FirstOrDefault(i => i.Id == id);
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateItem(Item input)
        {
            var itemToUpdate = _items.FirstOrDefault(i => i.Id == input.Id);
            if(itemToUpdate != null)
            {
                itemToUpdate = input;
            }
        }
    }
}
