﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomePage.Controllers
{
    public class FeedBackController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
