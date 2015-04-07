﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webshop.Models;
using Webshop_BusinessLayer.Repositories;
using Webshop_BusinessLayer.Services;

namespace Webshop.Controllers
{
    public class CataloogController : Controller
    {
        //public IGenericRepository<ProgrammingFramework> frameworkRepository;
        //public IGenericRepository<Webshop.Models.OperatingSystem> OSRepository;
        // GET: Cataloog

        private IProductService ps;
        public CataloogController(IProductService ps)
        {
            this.ps = ps;
        }
        public ActionResult Index()
        {
            return View(ps.GetAllDevices());
        }
        public ActionResult Detail(int Id)
        {
            return View(ps.GetDeviceById(Id));
        }
    }
}