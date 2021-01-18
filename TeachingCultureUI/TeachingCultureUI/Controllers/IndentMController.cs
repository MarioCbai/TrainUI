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
        public IActionResult Orderoperation()   //订单管理
        {
            return View();
        }
        public IActionResult Reimburse(int id)    //申请退款
        {
            ViewBag.Id = id;
            return View();
        }
        public IActionResult AddOrders(int id)   //添加订单
        {
            return View();
        }
        public IActionResult SelectStudent(int id)  //显示要选择的学员
        {
            return View();
        }
        public IActionResult OrderAudit()   //订单审核
        {
            return View();
        }
        public IActionResult CheckIndex(int id)   //订单审核页面
        {
            return View();
        }
        public IActionResult SelOrder()   //查询订单所有信息
        {
            return View();
        }
        public IActionResult RefundOrderShow()   //退款订单 
        {
            return View();
        }
        public IActionResult RefundOrderAudit(int id)   //退款审核
        {
            return View();
        }
        public IActionResult DetailsSelrefundOrder(int id)   //查看退款订单
        {
            return View();
        }

    }
}
