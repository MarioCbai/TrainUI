using System;
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
            return View();
        }
        //课堂管理查看
        //TeachingM/SelClassRoom
        [Route("/TeachingM/SelClassRoom")]
        public IActionResult SelClassRoom(string Name)
        {
            AddCookie("Name", Name);
            ViewBag.Name = GetValue("Name");  //学生
            return View();
        }
        //课堂管理申请退课
        //TeachingM/ApplyDropClass
        [Route("/TeachingM/ApplyDropClass")]
        public IActionResult ApplyDropClass()
        {
            return View();
        }
        //课堂管理申请返还课
        //TeachingM/ApplyReturn
        public IActionResult ApplyReturn()
        {
            return View();
        }
        //课堂管理显示
        //TeachingM/ClassRoomShow
        [Route("/TeachingM/ClassRoomShow")]
        public IActionResult ClassRoomShow()
        {
            ViewBag.ConsumerName = GetValue("ConsumerName");
            return View();
        }
        //退课申请单
        //DropApplyShow()
        [Route("/TeachingM/DropApplyShow")]
        public IActionResult DropApplyShow()
        {
            return View();
        }
        //返还课查看
        //SelRetuenClass()
        [Route("/TeachingM/SelRetuenClass")]
        public IActionResult SelRetuenClass()
        {
            return View();
        }
        //返还课审核
        //AuditRetuenClass()
        [Route("/TeachingM/AuditRetuenClass")]
        public IActionResult AuditRetuenClass()
        {
            return View();
        }
    }
}
