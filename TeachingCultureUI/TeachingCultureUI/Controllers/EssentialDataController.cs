using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TeachingCultureUI.Controllers
{
    public class EssentialDataController : Controller
    {
        // 基本数据管理控制器
        public IActionResult Index()
        {
            return View();
        }
    }
}
