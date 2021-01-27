using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TeachingCultureUI.Register;

namespace TeachingCultureUI.Controllers
{
    public class AuthorityMController : CookisHelper
    {
        //private readonly string _logger;

        public static string Str { get; set; }  //链接字符串


        RegisterHelper dt = new RegisterHelper();
        [CheckUser]
        #region 首页
        [Route("/AuthorityM/HomePage")]
        public IActionResult HomePage()
        {
            ViewBag.Str = Str;
            ViewBag.Phone = GetValue("Phone");
            return View();
        }
        #endregion


        #region 权限管理控制器


        // 权限管理控制器

        //角色编辑
        [CheckUser]
        [Route("/AuthorityM/UptPart")]
        public IActionResult UptPart(int id)
        {
            ViewBag.Str = Str;
            ViewBag.id = id;
            return View();
        }


        //角色查看
        [CheckUser]
        [Route("/AuthorityM/SelPart")]
        public IActionResult SelPart(int id)
        {
            ViewBag.id = id;
            ViewBag.Str = Str;
            return View();
        }


        [CheckUser]
        [Route("/AuthorityM/Powder")]
        public IActionResult Powder(int id)
        {
            ViewBag.id = id;
            ViewBag.Str = Str;
            return View();
        }

        //编辑用户信息
        [CheckUser]
        [Route("/AuthorityM/UptUser")]
        public IActionResult UptUser(int id)
        {
            ViewBag.Handlers = GetValue("ConsumerName");
            ViewBag.id = id;
            ViewBag.Str = Str;
            return View();
        }

        //查看用户信息
        [CheckUser]
        [Route("/AuthorityM/LookUser")]
        public IActionResult LookUser(int id)
        {
            ViewBag.Str = Str;
            ViewBag.id = id;
            return View();
        }

        //用户添加
        [CheckUser]
        [Route("/AuthorityM/AddUser")]
        public IActionResult AddUser()
        {
            ViewBag.Str = Str;
            ViewBag.Handlers= GetValue("ConsumerName");
            return View();
        }

        //用户显示
        [CheckUser]
        [Route("/AuthorityM/CRUDUser")]
        public IActionResult CRUDUser()
        {

            ViewBag.Str = Str;
            return View();
        }
        //登录页面
        public IActionResult Register(int i)
        {
            HttpContext.Session.GetInt32("Rnumber");
            if (i!=0)
            {
                HttpContext.Session.SetInt32("Rnumber",i);
            }
            ViewBag.Str = Str;
            ViewBag.Phone = GetValue("Phone");
            ViewBag.Pwd = GetValue("Pwd");            
            return View();
        }
        //验证码的发送
       
        [Route("/AuthorityM/Authcode")]
        public IActionResult Authcode(string pone = null)
        {
            ViewBag.Str = Str;
            //int YZM = dt.Page_Load(pone);

            return Json(1234);
        }
        //保存密码
        [CheckUser]
        [Route("/AuthorityM/bc")]
        public void bc(string ConsumerIPhone, string ConsumerPwd)
        {
            ViewBag.Str = Str;

            AddCookie("Phone",ConsumerIPhone, (10 * 365 * 24 * 60 * 60));
            if (ConsumerPwd!= null)
            {
                AddCookie("Pwd", ConsumerPwd, (10 * 365 * 24 * 60 * 60));
            }          
        }
        //删除
        [CheckUser]
        [Route("/AuthorityM/Sc")]
        public void Sc()
        {
            ViewBag.Str = Str;
            DeleteCookie("Phone");
            DeleteCookie("Pwd");
        }
        //菜单导航
        [CheckUser]
        public IActionResult Cs()
        {
            ViewBag.Str = Str;
            ViewBag.Phone = GetValue("zhanghao");
            return View();
        }
        //找回密码
        [CheckUser]
        public IActionResult RetrievePassword()
        {
            ViewBag.Str = Str;
            ViewBag.Phone = GetValue("zhanghao");
            return View();
        }

        //权限管理-角色类表
        [CheckUser]
        public IActionResult CRUDPart()
        {
            ViewBag.Str = Str;
            return View();
        }
        //添加角色视图
        [CheckUser]
        public IActionResult AddCRUDPart()
        {
            ViewBag.Str = Str;
            return View();
        }
        //保存登录的用户名
       
        [Route("/AuthorityM/CC")]
        public void BC(string ConsumerName,string zhanghao)
        {
            ViewBag.Str = Str;
            AddCookie("ConsumerName", ConsumerName);//当前登录用户名    
            AddCookie("zhanghao", zhanghao);//当前登录账号  
        }
        //添加快速导航数据
        [CheckUser]
        public IActionResult DH()
        {
            ViewBag.Str = Str;
            ViewBag.Phone = GetValue("Phone");
            return View();
        }
        //删除快速导航数据
        [CheckUser]
        public IActionResult Shan()
        {
            ViewBag.Str = Str;
            ViewBag.Phone = GetValue("Phone");
            return View();
        }
        #endregion
    }
}
