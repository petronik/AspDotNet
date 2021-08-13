﻿using AspDotNetWebApplication.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspDotNetWebApplication.Controllers
{
    public class VendorController : Controller
    {
        private readonly IVendorRepo _vendorRepo;

        public VendorController(IVendorRepo vendorRepo)
        {
            _vendorRepo = vendorRepo;
        }
        public IActionResult Index()
        {
            return View(_vendorRepo.GetAllVendors() );
        }
    }
}
