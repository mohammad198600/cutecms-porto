﻿using cutecms_porto.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cutecms_porto.Areas.Identity.Controllers
{
    public class ErrorController : BaseController
    {
        #region Methods
        // GET: Identity/Error
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult NotFound()
        {
            return View();
        }
        public ActionResult NotTranslated()
        {
            return View();
        }
        public ActionResult NotPublished()
        {
            return View();
        }
        public ActionResult IvalidToken()
        {
            return View();
        }
        #endregion Methods
    }
}