using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsGoBootstrap.Controllers
{
    public class HomeController:Controller
    {
        /// <summary>
        /// The home/ landing page of the website
        /// </summary>
        /// <returns>A view</returns>
        public ViewResult Index()
        {
            return View();
        }
    }
}
