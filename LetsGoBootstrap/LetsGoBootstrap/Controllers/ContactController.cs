using LetsGoBootstrap.Models;
using LetsGoBootstrap.ViewModels;
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
            ViewBag.ContactTabClass = "active";
            ViewBag.Address = "active";
            return View();
        }

        [HttpPost]
        public ActionResult Index(VistorContactUsViewModel aModel)
        {
            ViewBag.ContactTabClass = "active";
            ViewBag.ContactUs = "active";
            if (ModelState.IsValid)
            {
                try
                {
                    var aContact = new Contact() {
                        FirstName=aModel.FirstName,
                        LastName=aModel.LastName,
                        Email=aModel.Email,
                        Message=aModel.Message
                    };
                    _contactRepository.SendMessage()
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return View(aModel);
        }
    }
}
