using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TeachingCultureUI.Controllers
{
    public class IndentMController : Controller
    {
        // 订单管理
        public IActionResult Orderoperation()   //订单显示页面
        {
            return View();
        }
        public IActionResult Reimburse(int id)    //申请退款页面
        {
            ViewBag.Id = id;
            return View();
        }
        public IActionResult AddOrders()   //添加订单页面
        {
            return View();
        }
        public IActionResult EditIndex(int id) //订单编辑页面
        {
            return View();
        }
        public IActionResult OrderAudit()   //订单审核页面
        {
            return View();
        }
        public IActionResult CheckIndex(int id)   //订单审核页面(修改审核状态)
        {
            return View();
        }
        public IActionResult SelOrder()   //查看订单所有信息页面
        {
            return View();
        }
        public IActionResult RefundOrderShow()   //退款订单详情页
        {
            return View();
        }
        public IActionResult RefundOrderAudit(int id)   //退款审核页
        {
            return View();
        }
        public IActionResult DetailsSelrefundOrder(int id)   //全部退款订单
        {
            return View();
        }

    }
}
