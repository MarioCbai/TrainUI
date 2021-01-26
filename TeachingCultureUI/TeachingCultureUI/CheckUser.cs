using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 
namespace TeachingCultureUI
{
    public class CheckUser : ActionFilterAttribute 
    {

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            int  filter =Convert.ToInt32(context.HttpContext.Session.GetInt32("Rnumber"));
            if (filter==0)
            {
                context.Result = new RedirectResult("/AuthorityM/Register");
            }
            base.OnActionExecuting(context);
        }
    }
}
