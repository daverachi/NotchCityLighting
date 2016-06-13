﻿using NotchCityLighting.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NotchCityLighting.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILookupService _lookupService;
        public HomeController(ILookupService lookupService)
        {
            _lookupService = lookupService;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Light()
        {
            return View(_lookupService.GetLights());
        }
    }
}