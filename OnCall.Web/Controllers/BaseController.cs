using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnCall.Web.Code.Util;

namespace OnCall.Web.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
        public BaseController()
        {
            //ViewBag.WebTitle = ConfigurationUtil.GetSection("WebSite:WebTitle");
            //ViewBag.WebTitle = "On Call";
        }
    }
}