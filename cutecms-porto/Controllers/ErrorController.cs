﻿using cutecms_porto.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cutecms_porto.Controllers
{
    public class ErrorController : BaseController
    {
        #region Methods
        // GET: Error
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
        public ActionResult InvalidToken()
        {
            return View();
        }
        public ActionResult CatchAll()
        {
            return View();
        }
        #endregion Methods
    }
}