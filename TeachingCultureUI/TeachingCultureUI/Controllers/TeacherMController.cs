﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TeachingCultureUI.Controllers
{
    public class TeacherMController : Controller
    {
        // 教师管理控制器
        public IActionResult Index()
        {
            return View();
        }
        // 教师管理控制器
        public IActionResult TeacherShow()
        {
            return View();
        }
    }
}
