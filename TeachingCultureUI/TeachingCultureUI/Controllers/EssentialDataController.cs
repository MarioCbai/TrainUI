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

        //来源管理
        /// <summary>
        /// 来源管理显示
        /// </summary>
        /// <returns></returns>
        public IActionResult SourceShow()
        {
            return View();
        }

        public IActionResult SourceAdd()
        {
            return View();
        }
    }
}
