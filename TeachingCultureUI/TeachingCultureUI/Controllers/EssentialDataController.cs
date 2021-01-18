using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TeachingCultureUI.Controllers
{
    public class EssentialDataController : Controller
    {
        // 基本数据管理控制器

        //来源管理
        /// <summary>
        /// 来源管理显示页面
        /// </summary>
        /// <returns></returns>
        public IActionResult SourceShow()
        {
            
            return View();
        }
        /// <summary>
        /// 来源管理添加页面
        /// </summary>
        /// <returns></returns>
        public IActionResult SourceAdd()
        {
            return View();
        }
        /// <summary>
        /// 来源管理修改页面
        /// </summary>
        /// <returns></returns>
        public IActionResult SourceUpt(int id)
        {
            ViewBag.Id = id;
            return View();
        }
        //教师类别管理
        /// <summary>
        /// 教师类别管理显示页面
        /// </summary>
        /// <returns></returns>
        public IActionResult TeacherSortShow()
        {
            return View();
        }
        /// <summary>
        /// 教师类别管理添加页面
        /// </summary>
        /// <returns></returns>
        public IActionResult TeacherSortAdd()
        {
            return View();
        }

        /// <summary>
        /// 教师类别管理修改页面
        /// </summary>
        /// <returns></returns>
        public IActionResult TeacherSortUpt(int id)
        {
            ViewBag.Id = id;
            return View();
        }
        //教师水平级别管理
        /// <summary>
        /// 教师水平级别显示页面
        /// </summary>
        /// <returns></returns>
        public IActionResult TeacherLevelShow()
        {
            return View();
        }
        /// <summary>
        /// 教师水平级别添加页面
        /// </summary>
        /// <returns></returns>
        public IActionResult TeacherLevelAdd()
        {
            return View();
        }
        /// <summary>
        /// 教师水平级别修改页面
        /// </summary>
        /// <returns></returns>
        public IActionResult TeacherLevelUpt(int id)
        {
            ViewBag.Id = id;
            return View();
        }

        //教师教学风格管理
        /// <summary>
        /// 教师教学风格显示页面
        /// </summary>
        /// <returns></returns>
        public IActionResult TeacherStyleShow()
        {
            return View();
        }
        /// <summary>
        /// 教师教学风格添加页面
        /// </summary>
        /// <returns></returns>
        public IActionResult TeacherStyleAdd()
        {
            return View();
        }
        /// <summary>
        /// 教师教学风格修改页面
        /// </summary>
        /// <returns></returns>
        public IActionResult TTeacherStyleUpt(int id)
        {
            ViewBag.Id = id;
            return View();
        }

        //课时类型管理
        /// <summary>
        /// 课时类型管理显示页面
        /// </summary>
        /// <returns></returns>
        public IActionResult ClassTypeShow()
        {
            return View();
        }
        /// <summary>
        /// 课时类型管理添加页面
        /// </summary>
        /// <returns></returns>
        public IActionResult ClassTypeAdd()
        {
            return View();
        }
        /// <summary>
        /// 课时类型管理修改页面
        /// </summary>
        /// <returns></returns>
        public IActionResult ClassTypeUpt()
        {
            return View();
        }

        //班型管理
        /// <summary>
        /// 班型管理修改页面
        /// </summary>
        /// <returns></returns>
        public IActionResult ClasstypeManagementShow()
        {
            return View();
        }

        //价格级别管理
        /// <summary>
        /// 价格级别管理显示页面
        /// </summary>
        /// <returns></returns>
        public IActionResult PriceLevelShow()
        {
            return View();
        }
        /// <summary>
        /// 价格级别管理添加页面
        /// </summary>
        /// <returns></returns>
        public IActionResult PriceLevelAdd()
        {
            return View();
        }
        /// <summary>
        /// 价格级别管理修改页面
        /// </summary>
        /// <returns></returns>
        public IActionResult PriceLevelUpt()
        {
            return View();
        }
    }
}
