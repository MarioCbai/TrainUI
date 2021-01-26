﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TeachingCultureUI.Controllers
{
    public class TeachingMController : CookisHelper
    {
        public static string Str { get; set; }  //链接字符串      
        // 教学管理控制器
        public IActionResult Index()
        {
            ViewBag.Str = Str;
            return View();
        }
        //课堂管理查看
        //TeachingM/SelClassRoom
        [Route("/TeachingM/SelClassRoom")]
        public IActionResult SelClassRoom(string Name)
        {
            ViewBag.Str = Str;
            AddCookie("Name", Name);
            ViewBag.Name = GetValue("Name");  //学生
            return View();
        }
        //课堂管理申请退课
        //TeachingM/ApplyDropClass
        [Route("/TeachingM/ApplyDropClass")]
        public IActionResult ApplyDropClass()
        {
            ViewBag.ConsumerName = GetValue("ConsumerName");
            ViewBag.Str = Str;
            return View();
        }
        //课堂管理申请返还课
        //TeachingM/ApplyReturn
        public IActionResult ApplyReturn()
        {
            ViewBag.ConsumerName = GetValue("ConsumerName");
            ViewBag.Str = Str;
            return View();
        }
        //课堂管理显示
        //TeachingM/ClassRoomShow
        [Route("/TeachingM/ClassRoomShow")]
        public IActionResult ClassRoomShow()
        {
            ViewBag.Str = Str;
            ViewBag.ConsumerName = GetValue("ConsumerName");
            return View();
        }
        //退课申请单
        //DropApplyShow()
        [Route("/TeachingM/DropApplyShow")]
        public IActionResult DropApplyShow()
        {
            ViewBag.ConsumerName = GetValue("ConsumerName");
            ViewBag.Str = Str;
            return View();
        }
        //返还课查看
        //SelRetuenClass()
        [Route("/TeachingM/SelRetuenClass")]
        public IActionResult SelRetuenClass()
        {
            ViewBag.Str = Str;
            return View();
        }
        //返还课审核
        //AuditRetuenClass()
        [Route("/TeachingM/AuditRetuenClass")]
        public IActionResult AuditRetuenClass()
        {
            ViewBag.Str = Str;
            ViewBag.name = GetValue("ConsumerName");
            return View();
        }
        //SelCourse（）
        //排课申请查看
        public IActionResult SelCourse()
        {
            ViewBag.Str = Str;
            return View();
        }
    }
}
