using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TeachingCultureUI.Register;

namespace TeachingCultureUI.Controllers
{
    public class AuthorityMController : CookisHelper
    {
        RegisterHelper dt = new RegisterHelper();
        // 权限管理控制器
        //用户显示
        [Route("/AuthorityM/CRUDUser")]
        public IActionResult CRUDUser()
        {
            return View();
        }
        //登录页面
        public IActionResult Register()
        {

            ViewBag.Phone = GetValue("Phone");
            ViewBag.Pwd = GetValue("Pwd");
            return View();
        }
        //验证码的发送
        [Route("/AuthorityM/Authcode")]
        public IActionResult Authcode(string pone = null)
        {
            //int YZM=dt.Page_Load(pone);

            return Json(1234);
        }
        //保存密码
        [Route("/AuthorityM/bc")]
        public void bc(string ConsumerIPhone, string ConsumerPwd)
        {
            AddCookie("Phone", ConsumerIPhone);
            AddCookie("Pwd", ConsumerPwd);
        }
        //删除
        [Route("/AuthorityM/Sc")]
        public void Sc()
        {
            DeleteCookie("Phone");
            DeleteCookie("Pwd");
        }
    }
}
