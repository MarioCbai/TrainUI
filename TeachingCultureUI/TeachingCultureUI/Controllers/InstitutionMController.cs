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
        //机构管理显示
        public IActionResult OrganizationShow()
        {
            return View();
        }
        public IActionResult ClassManagementShow()
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
    }
}
