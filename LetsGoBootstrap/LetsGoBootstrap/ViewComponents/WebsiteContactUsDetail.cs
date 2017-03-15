using LetsGoBootstrap.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsGoBootstrap.ViewComponents
{
    public class WebsiteContactUsDetail:ViewComponent
    {
        private readonly IContactRepository _contactRepository = null;

        public WebsiteContactUsDetail(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public IViewComponentResult Invoke()
        {
            var websiteContactDetail = _contactRepository.GetContact(null,null).First();
            return View(websiteContactDetail);
        }
    }
}
