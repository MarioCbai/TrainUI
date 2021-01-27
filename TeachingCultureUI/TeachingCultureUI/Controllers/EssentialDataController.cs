using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TeachingCultureUI.Controllers
{
    public class EssentialDataController : Controller
    {

        public static string Str { get; set; }  //链接字符串
        // 基本数据管理控制器

        //来源管理
        /// <summary>
        /// 来源管理显示页面
        /// </summary>
        /// <returns></returns>
        [CheckUser]
        public IActionResult SourceShow()
        {
            ViewBag.SourceShow = Str;
            return View();
        }
        /// <summary>
        /// 来源管理添加页面
        /// </summary>
        [CheckUser]
        public IActionResult SourceAdd()
        {
            ViewBag.SourceAdd = Str;
            return View();
        }
        /// <summary>
        /// 来源管理修改页面
        /// </summary>
        [CheckUser]
        public IActionResult SourceUpt(int id)
        {
            ViewBag.Id = id;
            ViewBag.SourceUpt = Str;
            return View();
        }
        //教师类别管理
        /// <summary>
        /// 教师类别管理显示页面
        /// </summary>
        [CheckUser]
        public IActionResult TeacherSortShow()
        {
            ViewBag.TeacherSortShow = Str;
            return View();
        }
        /// <summary>
        /// 教师类别管理添加页面
        /// </summary>
        [CheckUser]
        public IActionResult TeacherSortAdd()
        {
            ViewBag.TeacherSortAdd = Str;
            return View();
        }

        /// <summary>
        /// 教师类别管理修改页面
        /// </summary>
        [CheckUser]
        public IActionResult TeacherSortUpt(int id)
        {
            ViewBag.TeacherSortUpt = Str;
            ViewBag.Id = id;
            return View();
        }
        //教师水平级别管理
        /// <summary>
        /// 教师水平级别显示页面
        /// </summary>
        [CheckUser]
        public IActionResult TeacherLevelShow()
        {
            ViewBag.TeacherLevelShow = Str;
            return View();
        }
        /// <summary>
        /// 教师水平级别添加页面
        /// </summary>
        [CheckUser]
        public IActionResult TeacherLevelAdd()
        {
            ViewBag.TeacherLevelAdd = Str;
            return View();
        }
        /// <summary>
        /// 教师水平级别修改页面
        /// </summary>
        [CheckUser]
        public IActionResult TeacherLevelUpt(int id)
        {
            ViewBag.TeacherLevelUpt = Str;
            ViewBag.Id = id;
            return View();
        }

        //教师教学风格管理
        /// <summary>
        /// 教师教学风格显示页面
        /// </summary>
        [CheckUser]
        public IActionResult TeacherStyleShow()
        {
            ViewBag.TeacherStyleShow = Str;
            return View();
        }
        /// <summary>
        /// 教师教学风格添加页面
        /// </summary>
        [CheckUser]
        public IActionResult TeacherStyleAdd()
        {
            ViewBag.TeacherStyleAdd = Str;
            return View();
        }
        /// <summary>
        /// 教师教学风格修改页面
        /// </summary>
        [CheckUser]
        public IActionResult TTeacherStyleUpt(int id)
        {
            ViewBag.TTeacherStyleUpt = Str;
            ViewBag.Id = id;
            return View();
        }

        //课时类型管理
        /// <summary>
        /// 课时类型管理显示页面
        /// </summary>
        [CheckUser]
        public IActionResult ClassTypeShow()
        {
            ViewBag.ClassTypeShow = Str;
            return View();
        }
        /// <summary>
        /// 课时类型管理添加页面
        /// </summary>
        [CheckUser]
        public IActionResult ClassTypeAdd()
        {
            ViewBag.ClassTypeAdd = Str;
            return View();
        }
        /// <summary>
        /// 课时类型管理修改页面
        /// </summary>
        [CheckUser]
        public IActionResult ClassTypeUpt(int id)
        {
            ViewBag.ClassTypeUpt = Str;
            ViewBag.Id = id;
            return View();
        }

        //班型管理
        /// <summary>
        /// 班型管理修改页面
        /// </summary>
        [CheckUser]
        public IActionResult ClasstypeManagementShow()
        {
            ViewBag.ClasstypeManagementShow = Str;
            return View();
        }

        //价格级别管理
        /// <summary>
        /// 价格级别管理显示页面
        /// </summary>
        [CheckUser]
        public IActionResult PriceLevelShow()
        {
            ViewBag.PriceLevelShow = Str;
            return View();
        }
        /// <summary>
        /// 价格级别管理添加页面
        /// </summary>
        [CheckUser]
        public IActionResult PriceLevelAdd()
        {
            ViewBag.PriceLevelAdd = Str;
            return View();
        }
        /// <summary>
        /// 价格级别管理修改页面
        /// </summary>
        [CheckUser]
        public IActionResult PriceLevelUpt(int id)
        {
            ViewBag.PriceLevelUpt = Str;
            ViewBag.Id = id;
            return View();
        }

        //定价管理
        /// <summary>
        /// 定价管理显示页面
        /// </summary>
        [CheckUser]
        public IActionResult PricingManagementShow()
        {
            ViewBag.PricingManagementShow = Str;
            return View();
        }

    }
}
