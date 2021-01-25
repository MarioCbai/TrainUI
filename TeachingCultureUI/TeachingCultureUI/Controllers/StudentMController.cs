using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TeachingCultureUI.Controllers
{
    public class StudentMController : CookisHelper
    {
        public static string Str { get; set; }  //链接字符串
        // 学员管理控制器


        #region 意向学员

        //申请试听课
        public IActionResult AddTrial(int id)
        {
            ViewBag.id = id;
            return View();
        }

        //意向学员显示
        public IActionResult IntentionShow()
        {
            return View();
        }

        //修改家长信息
        [Route("/StudentM/UptParent")]
        public IActionResult UptParent(int id)
        {
            ViewBag.id = id;
            return View();
        }

        //显示家长信息
        [Route("/StudentM/Patriarch")]
        public IActionResult Patriarch(int id)
        {
            ViewBag.id = id;
            return View();
        }

        //添加意向学员信息
        [Route("/StudentM/StudentAdd")]
        public IActionResult StudentAdd()
        {
            ViewBag.zixun = GetValue("ConsumerName");
            return View();
        }
        #endregion
        //添加家长信息
        [Route("/StudentM/PatriarchAdd")]
        public IActionResult PatriarchAdd(int Id)
        {
            ViewBag.id = Id;
            return View();
        }
  
    }
}
