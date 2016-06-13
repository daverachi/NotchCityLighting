using NotchCityLighting.Core.Interfaces;
using NotchCityLighting.Web.ViewModelExtensions;
using NotchCityLighting.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NotchCityLighting.Web.Controllers
{
    public class AdminController : Controller
    {
        private readonly ILookupService _lookupService;
        private readonly IAdminService _adminService;
        public AdminController(ILookupService lookupService, IAdminService adminService)
        {
            _lookupService = lookupService;
            _adminService = adminService;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateLight(LightDO light = null)
        {
            if(light != null)
            {
                if(_adminService.CreateLight(light.ToLight()))
                {
                    RedirectToAction("Light", "Home");
                }
            }
            return View(light);
        }
    }
}