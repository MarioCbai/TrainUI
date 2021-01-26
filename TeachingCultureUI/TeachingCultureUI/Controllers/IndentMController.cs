using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TeachingCultureUI.Controllers
{
    public class IndentMController : CookisHelper
    {
        public static string Str { get; set; }  //链接字符串
        // 订单管理
        public IActionResult Orderoperation()   //订单显示页面
        {
            ViewBag.Str = Str;
            return View();
        }
        public IActionResult Reimburse(int id)    //申请退款页面
        {
            ViewBag.Str = Str;
            ViewBag.Id = id;
            ViewBag.Name = GetValue("ConsumerName");
            return View();
        }
        public IActionResult AddOrders()   //添加订单页面
        {
            ViewBag.Str = Str;
            ViewBag.Name = GetValue("ConsumerName");
            return View();
        }
        public IActionResult EditIndex(int id) //订单编辑页面
        {
            ViewBag.Str = Str;
            return View();
        }
        public IActionResult OrderAudit()   //订单审核页面
        {
            ViewBag.Str = Str;
            return View();
        }
        public IActionResult CheckIndex(int id)   //订单审核页面(修改审核状态)
        {
            ViewBag.Str = Str;
            ViewBag.Auditor = GetValue("ConsumerName");
            return View();
        }
        public IActionResult SelOrder()   //查看订单所有信息页面
        {
            ViewBag.Str = Str;
            return View();
        }
        public IActionResult RefundOrderShow()   //退款订单详情页
        {
            ViewBag.Str = Str;
            return View();
        }
        public IActionResult RefundOrderAudit(int id)   //退款审核页
        {
            ViewBag.Str = Str;
            ViewBag.Verifier = GetValue("ConsumerName");
            return View();
        }
        public IActionResult DetailsSelrefundOrder(int id)   //点击查看退款订单
        {
            ViewBag.Str = Str;
            return View();
        }

    }
}
