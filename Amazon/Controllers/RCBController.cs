﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Amazon.Controllers
{
    public class RCBController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
