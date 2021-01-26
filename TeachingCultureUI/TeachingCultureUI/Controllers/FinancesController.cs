﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TeachingCultureUI.Controllers
{
    public class FinancesController : CookisHelper
    {
        public static string Str { get; set; }  //链接字符串
        // 财务管理控制器
        public IActionResult AgencyAccount()
        {
            ViewBag.AgencyAccount = Str;
            return View();
        }
        //充值金额页面
        public IActionResult OrganizationUpt(int id)
        {
            ViewBag.Name = GetValue("ConsumerName");
            ViewBag.Id = id;
            ViewBag.OrganizationUpt = Str;
            return View();
        }

        public IActionResult OrganizationEidt(int id)
        {
            ViewBag.OrganizationEidt = Str;
            ViewBag.Id = id;
            return View();
        }

        public IActionResult Institutions()
        {
            ViewBag.Institutions = Str;
            ViewBag.TName = GetValue("ConsumerName");
            return View();
        }
    }
}
