using AspDotNetWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspDotNetWebApplication.Data.Interfaces
{
    public interface IItemRepo
    {
        IEnumerable<Item> GetAllItems();
        Item GetItemById(int id); //Read
        void CreateItem(Item input); //Create
        void UpdateItem(Item input); //Update
        void DeleteItem(int id); //Delete
        bool SaveChanges();
    }
}
