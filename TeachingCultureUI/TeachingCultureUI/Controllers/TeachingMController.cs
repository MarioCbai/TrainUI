﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TeachingCultureUI.Controllers
{
    public class TeachingMController : Controller
    {
        // 教学管理控制器
        public IActionResult Index()
        {
            return View();
        }
    }
}
