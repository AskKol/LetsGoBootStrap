using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsGoBootstrap.Controllers
{
    public class ProductController:Controller
    {
        public ProductController()
        {

        }

        public ViewResult Index()
        {
            ViewBag.ProductTabClass = "active";
            return View();

        }
    }
}
