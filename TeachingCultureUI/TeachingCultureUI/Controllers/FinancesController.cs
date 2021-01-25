using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TeachingCultureUI.Controllers
{
    public class FinancesController : Controller
    {
        public static string Str { get; set; }  //链接字符串
        // 财务管理控制器
        public IActionResult AgencyAccount()
        {
            return View();
        }
        //充值金额页面
        public IActionResult OrganizationUpt(int id)
        {
            ViewBag.Id = id;
            return View();
        }

        public IActionResult OrganizationEidt(int id)
        {
            ViewBag.Id = id;
            return View();
        }

        public IActionResult Institutions()
        {
            return View();
        }
    }
}
