using LetsGoBootstrap.Models;
using LetsGoBootstrap.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsGoBootstrap.ViewComponents
{
    public class VistorContactUs:ViewComponent
    {
        private IContactRepository _contactUsRepository = null;
        public VistorContactUs(IContactRepository contactUsRepository)
        {
            _contactUsRepository = contactUsRepository;

        }

        public IViewComponentResult Invoke()
        {
            var vistorContactUs = new VistorContactUsViewModel();
            return View(vistorContactUs);
        }
    }
}
