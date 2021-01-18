using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TeachingCultureUI.Controllers
{
    public class InstitutionMController : Controller
    {
        // 机构管理管理控制器

        public IActionResult Index()
        {
            return View();
        }
        #region 机构管理
        //机构管理显示
        [Route("/Institution/OrganizationShow")]
        public IActionResult OrganizationShow()
        {
            return View();
        }
        //添加机构管理信息
        public IActionResult AddOrganes()
        {
            return View();
        }
        //修改机构管理信息
        public IActionResult UpdateOrganes(int orgid)
        {
            ViewBag.orgid = orgid;
            return View();
        }
        #endregion
        #region 班级管理
        [Route("/Institution/ClassManagementShow")]
        public IActionResult ClassManagementShow()
        {
            return View();
        }
        public IActionResult AddClassRooms()
        {
            return View();
        }
        //班级管理修改
        public IActionResult ModifyClassRoomMod(int id)
        {
            ViewBag.id = id;
            return View();
        }
        //班级管理删除
        public IActionResult DeleteClassRoomMod()
        {            
            return View();
        }
        #endregion

    }
}
