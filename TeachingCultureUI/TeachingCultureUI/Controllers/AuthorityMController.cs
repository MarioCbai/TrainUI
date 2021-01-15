using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TeachingCultureUI.Controllers
{
    public class AuthorityMController : Controller
    {
        // 权限管理登录首页控制器
        //用户角色显示
        public IActionResult CRUDUser()
        {
            return View();
        }
    }
}
