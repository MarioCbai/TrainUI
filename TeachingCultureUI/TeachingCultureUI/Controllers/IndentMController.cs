using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TeachingCultureUI.Controllers
{
    public class IndentMController : Controller
    {
        // 订单管理
        public IActionResult Index()
        {
            return View();
        }
    }
}
