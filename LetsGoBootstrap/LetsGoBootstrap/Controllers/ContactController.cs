using LetsGoBootstrap.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsGoBootstrap.Controllers
{
    public class ContactController:Controller
    {
        private IContactRepository _contactRepository = null;
        public ContactController(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}
