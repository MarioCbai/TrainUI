using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

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
        #region 认证信息
        //添加教师管理信息
        public IActionResult TeacherAddPic()
        {
            return View();
        }
        public string AddPic()
        {
            var uploadfile = Request.Form.Files[0];
            String name = uploadfile.FileName;//文件名称
            var path = Directory.GetCurrentDirectory();//文件夹绝对路径
            string fullPath = path + @"/wwwroot/Imgs/" + name;//图片绝对路径
            string filePath = @"/Imgs/" + name;//文件相对路径,需要保存到数据库
            using (FileStream fs = System.IO.File.Create(fullPath))
            {
                //复制文件,保存文件至Img文件夹
                uploadfile.CopyTo(fs);
                fs.Flush();
            }
            var dataJson = new
            {
                result = filePath,
                code = 0
            };
            return JsonConvert.SerializeObject(dataJson);
        }
        #endregion
        #region 教学信息
        //添加教学管理信息
        public IActionResult TeachModAdd()
        {
            return View();
        }
        //编辑教学管理信息
        public IActionResult ModifyTeachMod(int id)
        {
            ViewBag.id=id;
            return View();
        }
        #endregion
    }
}