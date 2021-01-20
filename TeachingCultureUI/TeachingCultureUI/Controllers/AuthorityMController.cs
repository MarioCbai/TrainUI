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

        #region 首页
        [Route("/AuthorityM/HomePage")]
        public IActionResult HomePage()
        {
            return View();
        }
        #endregion


        #region 权限管理控制器


        // 权限管理控制器

        //角色编辑
        [Route("/AuthorityM/UptPart")]
        public IActionResult UptPart(int id)
        {
            ViewBag.id = id;
            return View();
        }


        //角色查看
        [Route("/AuthorityM/SelPart")]
        public IActionResult SelPart(int id)
        {
            ViewBag.id = id;
            return View();
        }


        //权限树显示
        [Route("/AuthorityM/Powder")]
        public IActionResult Powder()
        {
            return View();
        }

        //编辑用户信息
        [Route("/AuthorityM/UptUser")]
        public IActionResult UptUser(int id)
        {
            ViewBag.Handlers = GetValue("ConsumerName");
            ViewBag.id = id;
            return View();
        }

        //查看用户信息
        [Route("/AuthorityM/LookUser")]
        public IActionResult LookUser(int id)
        {
            ViewBag.id = id;
            return View();
        }

        //用户添加
        [Route("/AuthorityM/AddUser")]
        public IActionResult AddUser()
        {
            ViewBag.Handlers= GetValue("ConsumerName");
            return View();
        }
 
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
            //int YZM = dt.Page_Load(pone);

            return Json(1234);
        }
        //保存密码
        [Route("/AuthorityM/bc")]
        public void bc(string ConsumerIPhone, string ConsumerPwd)
        {
  
            AddCookie("Phone",ConsumerIPhone, (10 * 365 * 24 * 60 * 60));
            AddCookie("Pwd", ConsumerPwd, (10 * 365 * 24 * 60 * 60));
        }
        //删除
        [Route("/AuthorityM/Sc")]
        public void Sc()
        {
            DeleteCookie("Phone");
            DeleteCookie("Pwd");
        }
        //菜单导航
        public IActionResult Cs()
        {
            return View();
        }
        //找回密码
        public IActionResult RetrievePassword()
        {
            ViewBag.Phone = GetValue("Phone");
            return View();
        }

        //权限管理-角色类表
        public IActionResult CRUDPart()
        {
            return View();
        }
        //添加角色视图
        public IActionResult AddCRUDPart()
        {
            return View();
        }
        //保存登录的用户名
        [Route("/AuthorityM/CC")]
        public void BC(string ConsumerName)
        {
            AddCookie("ConsumerName", ConsumerName);//当前登录用户名    
        }

        #endregion
    }
}
