using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TeachingCultureUI.Controllers
{
    public class StudentMController : CookisHelper
    {
        // 学员管理控制器
        public static string Str { get; set; }  //链接字符串

        //审核视图
        [CheckUser]
        public IActionResult AuditS(int id)
        {
            ViewBag.Str = Str;
            ViewBag.id = id;
            return View();
        }

        //查看视图
        [CheckUser]
        public IActionResult AuditSS(int id)
        {
            ViewBag.Str = Str;
            ViewBag.id = id;
            return View();
        }
        [CheckUser]
        public IActionResult AuditSSS(int id)
        {
            ViewBag.Str = Str;
            ViewBag.id = id;
            return View();
        }

        [CheckUser]
        //正式课
        public IActionResult ApplyFormallessons()
        {
            ViewBag.Str = Str;
            return View();
        }
        [CheckUser]

        //试听课
        public IActionResult TrialClass()
        {
            ViewBag.Str = Str;
            return View();
        }


        [CheckUser]
        //全部学员
        public IActionResult StudentShow()
        {
            ViewBag.Str = Str;
            return View(); 
        }
        [CheckUser]
        //学员详情信息
        public IActionResult StudentDeatil(int id)
        {
            ViewBag.Str = Str;
            ViewBag.id = id;
            return View();
        }


        #region 正式学员
        [CheckUser]
        //正式学员显示
        public IActionResult OrderShow()
        {
            ViewBag.Str = Str;
            return View();
        }

        #endregion



        #region 意向学员
        [CheckUser]
        //申请试听课
        public IActionResult AddTrial(int id)
        {
            ViewBag.Str = Str;
            ViewBag.id = id;
            return View();
        }
        [CheckUser]
        //意向学员显示
        public IActionResult IntentionShow()
        {
            ViewBag.Str = Str;
            return View();
        }
        [CheckUser]
        //修改家长信息
        [Route("/StudentM/UptParent")]
        public IActionResult UptParent(int id)
        {
            ViewBag.Str = Str;
            ViewBag.id = id;
            return View();
        }
        [CheckUser]
        //显示家长信息
        [Route("/StudentM/Patriarch")]
        public IActionResult Patriarch(int id)
        {
            ViewBag.Str = Str;
            ViewBag.id = id;
            return View();
        }
        [CheckUser]
        //添加意向学员信息
        [Route("/StudentM/StudentAdd")]
        public IActionResult StudentAdd()
        {
            ViewBag.Str = Str;
            ViewBag.zixun = GetValue("ConsumerName");
            return View();
        }
        #endregion
        [CheckUser]
        //添加家长信息
        [Route("/StudentM/PatriarchAdd")]
        public IActionResult PatriarchAdd(int Id)
        {
            ViewBag.Str = Str;
            ViewBag.id = Id;
            return View();
        }
  
    }
}
