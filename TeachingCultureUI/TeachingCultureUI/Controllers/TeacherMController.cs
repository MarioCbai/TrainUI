using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TeachingCultureUI.Controllers
{
    public class TeacherMController : Controller
    {
        // 教师管理控制器
        public IActionResult Index()
        {
            return View();
        }
        // 教师管理控制器
        public IActionResult TeacherShow()
        {
            return View();
        }
        //添加教师管理信息
        public IActionResult AddTeacher()
        {
            return View();
        }
        //反填教师管理信息
        public IActionResult ModifyIdTeacher()
        {
            return View();
        }
        //修改教师管理信息
        public IActionResult ModifyTeacher()
        {
            return View();
        }
        //删除教师管理信息
        public IActionResult DeleteTeacher()
        {
            return View();
        }
    }
}
