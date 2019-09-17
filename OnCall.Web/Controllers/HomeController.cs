using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnCall.Web.Code.Extensions;
using OnCall.Web.Code.Login;
using OnCall.Web.Domain.Entity;
using OnCall.Web.Models;

namespace OnCall.Web.Controllers
{
    public class HomeController : BaseController
    {

        private ILoginManager _LoginManager;

        public HomeController(ILoginManager LoginManager)
        {
            ViewBag.WebTitle = "On Call";
            _LoginManager = LoginManager;
        }
        public IActionResult Index()
        {
            ViewBag.LoginUserName = _LoginManager.LoginAccountName();
            ViewBag.UserMenus = BuilderMenu();
            return View();
        }

        protected string BuilderMenu()
        {
            StringBuilder html = new StringBuilder();
            IEnumerable<VMenu> listMenu = _LoginManager.GetLoginUserMenu();
            if (listMenu != null)
            {
                var parentMenu = GetMeunsByParent(listMenu);
                int i = 0;
                string isFirst = "layui-nav-itemed";
                foreach (var item in parentMenu)
                {
                    if (i > 0) isFirst = "";

                    html.AppendFormat("<li class=\"layui-nav-item {0}\"><a href=\"javascript:;\" lay-tips=\"{1}\" lay-direction=\"2\"><i class=\"layui-icon {2}\"></i><cite>{1}</cite></a><dl class=\"layui-nav-child\">",
                      isFirst, item.MenuTitle, item.Style);

                    var childMenu = GetMeunsByParent(listMenu, item.MenuID);
                    foreach (var itemchild in childMenu)
                    {
                        html.AppendFormat("<dd><a lay-href=\"{0}\">{1}</a></dd>", itemchild.MenuUrl, itemchild.MenuTitle);
                    }
                    html.Append("</dl></li>");
                    i++;
                }
            }

            return html.ToString();
        }

        private List<VMenu> GetMeunsByParent(IEnumerable<VMenu> list, int parentId = 0)
        {
            List<VMenu> relist = new List<VMenu>();
            foreach (VMenu item in list)
            {
                if (item.ParentID == parentId)
                {
                    relist.Add(item);
                }
            }

            return relist;
        }


        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
