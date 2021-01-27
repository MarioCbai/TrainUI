using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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
        [CheckUser]
        public IActionResult SelClassRoom(string Name)
        {
            ViewBag.Str = Str;  

            ViewBag.Name = Name;  //学生
            return View();
        }
        //课堂管理申请退课
        //TeachingM/ApplyDropClass
        [Route("/TeachingM/ApplyDropClass")]
        [CheckUser]
        public IActionResult ApplyDropClass()
        {
            ViewBag.ConsumerName = GetValue("ConsumerName");
            ViewBag.Str = Str;
            return View();
        }
        //课堂管理申请返还课
        //TeachingM/ApplyReturn
        [CheckUser]
        public IActionResult ApplyReturn()
        {
            ViewBag.ConsumerName = GetValue("ConsumerName");
            ViewBag.Str = Str;
            return View();
        }
        //课堂管理显示
        //TeachingM/ClassRoomShow
        [Route("/TeachingM/ClassRoomShow")]
        [CheckUser]
        public IActionResult ClassRoomShow()
        {
            ViewBag.Str = Str;
            ViewBag.ConsumerName = GetValue("ConsumerName");
            return View();
        }
        //退课申请单
        //DropApplyShow()
        [Route("/TeachingM/DropApplyShow")]
        [CheckUser]
        public IActionResult DropApplyShow()
        {
            ViewBag.ConsumerName = GetValue("ConsumerName");
            ViewBag.Str = Str;
            return View();
        }
        //返还课查看
        //SelRetuenClass()
        [Route("/TeachingM/SelRetuenClass")]
        [CheckUser]
        public IActionResult SelRetuenClass()
        {
            ViewBag.Str = Str;
            return View();
        }
        //返还课审核
        //AuditRetuenClass()
        [Route("/TeachingM/AuditRetuenClass")]
        [CheckUser]
        public IActionResult AuditRetuenClass()
        {
            ViewBag.Str = Str;
            ViewBag.name = GetValue("ConsumerName");
            return View();
        }
        //SelCourse（）
        //排课申请查看
        [CheckUser]
        public IActionResult SelCourse()
        {
            ViewBag.Str = Str;
            return View();
        }

        //申请试听课
        [CheckUser]
        public IActionResult AddTrial(int id,int AuditionID,int banxing,int ywlx,int kslx,int xd,int nj,int xk,string zt)
        {
            ViewBag.Str = Str;
            ViewBag.id = id;
            ViewBag.AuditionID = AuditionID;

            //班型
            ViewBag.banxing = banxing;
            //业务类型
            ViewBag.ywlx = ywlx;
            //课时类型
            ViewBag.kslx = kslx;
            //学段
            ViewBag.xd = xd;
            //年级
            ViewBag.nj = nj;
            //学科
            ViewBag.xk = xk;
            //上课主题
            ViewBag.zt = zt;
            return View();
        }
    }
}
