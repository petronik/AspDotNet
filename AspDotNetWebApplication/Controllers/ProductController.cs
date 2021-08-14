using AspDotNetWebApplication.Data.Interfaces;
using AspDotNetWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspDotNetWebApplication.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepo _productRepo;
        private readonly IVendorRepo _vendorRepo;

        public ProductController(IProductRepo prodRepo, IVendorRepo vendorRepo)
        {
            _productRepo = prodRepo;
            _vendorRepo = vendorRepo;
        }
        public IActionResult Index()
        {
            var vendors = _vendorRepo.GetAllVendors();
            var list = _productRepo.GetAllProducts()
                .Select(p =>
                {
                    p.Vendor = vendors
                                    .Where(v => v.V_code == p.V_code)
                                    .FirstOrDefault() ?? new Vendor { 
                                        V_name = "n/a"
                                    };
                    return p;
                })
                .ToList();
            return View(list);
        }
    }
}
