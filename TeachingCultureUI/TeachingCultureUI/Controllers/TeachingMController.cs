using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TeachingCultureUI.Controllers
{
    public class TeachingMController : Controller
    {
        // 教学管理控制器
        public IActionResult Index()
        {
            return View();
        }
        //课堂管理查看
        //TeachingM/SelClassRoom
        public IActionResult SelClassRoom()
        {
       
            return View();
        }
        //课堂管理申请退课
        //TeachingM/ApplyDropClass
        public IActionResult ApplyDropClass()
        {
            return View();
        }
        //课堂管理申请返还课
        //TeachingM/ApplyReturn
        public IActionResult ApplyReturn()
        {
            return View();
        }
        //课堂管理显示
        //TeachingM/ClassRoomShow
        public IActionResult ClassRoomShow()
        {
            return View();
        }
    }
}
