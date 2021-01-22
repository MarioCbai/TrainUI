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
        #region 教师管理
        //教师管理显示
        public IActionResult GetTeacher()
        {
            return View();
        }
        //添加教师管理信息
        public IActionResult TeacherAdd()
        {
            return View();
        }
        //修改教师管理信息
        public IActionResult ModifyTeacher(int teacherid)
        {
            ViewBag.teacherid = teacherid;
            return View();
        }
        //删除教师管理信息
        public IActionResult DeleteTeacher()
        {
            return View();
        }
        #endregion

    }
}
