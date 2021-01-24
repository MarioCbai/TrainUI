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


        #region 意向学员
        //意向学员显示
        public IActionResult IntentionShow()
        {
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
        public IActionResult PatriarchAdd(int StudentId)
        {
            return View();
        }
    }
}
