﻿using GiftService.Bll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace GiftService.Web.Controllers
{
    public class BaseController : Controller
    {
        protected BllFactory _bllFactory = null;

        protected BllFactory Factory
        {
            get
            {
                return BllFactory.Current;
            }
        }
    }
}