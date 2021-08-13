using AspDotNetWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspDotNetWebApplication.Data.Interfaces
{
    public interface IProductRepo
    {
        IEnumerable<Product> GetAllProducts();
    }
}
