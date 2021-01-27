using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TeachingCultureUI.Controllers
{
    public class InstitutionMController : Controller
    {
        public static string Str { get; set; }  //链接字符串
        // 机构管理管理控制器

        public IActionResult Index()
        {
            ViewBag.Str = Str;
            return View();
        }
        #region 机构管理
        //机构管理显示
        [CheckUser]
        [Route("/Institution/OrganizationShow")]
        public IActionResult OrganizationShow()
        {
            ViewBag.Str = Str;
            return View();
        }
        //添加机构管理信息
        [CheckUser]
        public IActionResult AddOrganes()
        {
            ViewBag.Str = Str;
            return View();
        }
        //修改机构管理信息
        [CheckUser]
        public IActionResult UpdateOrganes(int orgid)
        {
            ViewBag.Str = Str;
            ViewBag.orgid = orgid;
            return View();
        }
        #endregion
        #region 班级管理
        [Route("/Institution/ClassManagementShow")]
        [CheckUser]
        public IActionResult ClassManagementShow()
        {
            ViewBag.Str = Str;
            return View();
        }
        //班级添加管理信息
        [CheckUser]
        public IActionResult AddClassRooms()
        {
            ViewBag.Str = Str;
            return View();
        }
        //班级管理修改
        [CheckUser]
        public IActionResult ModifyClassRoomMod(int id)
        {
            ViewBag.Str = Str;
            ViewBag.id = id;
            return View();
        }
        //班级管理删除
        [CheckUser]
        public IActionResult DeleteClassRoomMod()
        {
            ViewBag.Str = Str;
            return View();
        }
        #endregion
        #region 课时包
        //课时包显示
        [CheckUser]
        public IActionResult GetHourTableMods()
        {
            ViewBag.Str = Str;
            return View();
        }
        //课时包管理修改
        [CheckUser]
        public IActionResult ModifyIdHourTableMods(int id)
        {
            ViewBag.Str = Str;
            ViewBag.ids = id;
            return View();
        }
        #endregion

    }
}
