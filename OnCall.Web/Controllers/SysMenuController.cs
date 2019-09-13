using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OnCall.Web.Controllers
{
    using OnCall.Web.Domain.Entity;
    using OnCall.Web.Domain.Infrastructure.DP;
    using OnCall.Web.Domain.Repository.Systems;

    public class SysMenuController : BaseController
    {
        private readonly IUnitOfWorkFactory _uowFactory;
        private readonly ISysMenuRepository _SysMenuRepository;

        public SysMenuController(IUnitOfWorkFactory uowFactory, ISysMenuRepository SysMenuRepository)
        {
            _uowFactory = uowFactory;
            _SysMenuRepository = SysMenuRepository;
        }
        public IActionResult Index()
        {
            return View("~/Views/Systems/SysMenu/Index.cshtml");
        }
        public IActionResult Edit()
        {
            return View("~/Views/Systems/SysMenu/Edit.cshtml");
        }
        public async Task<IActionResult> PageData(int page, int limit, string MenuTitle)
        {
            string msg = string.Empty;
            int code = 0;
            int total = 0;
            string sWhere = string.Empty;
            IEnumerable<ESysMenu> list = null;
            try
            {
                var param = new Dapper.DynamicParameters();
                if (!string.IsNullOrEmpty(MenuTitle))
                {
                    sWhere += " and MenuTitle like @MenuTitle";
                    param.Add("MenuTitle", string.Format("%{0}%", MenuTitle));
                }

                total = await _SysMenuRepository.GetTotalCount(sWhere, param);
                list = await _SysMenuRepository.GetPageAsync(page, limit, sWhere, param);
            }
            catch (Exception ex)
            {
                code = -1;
                msg = ex.Message;
            }
            return Ok(new { code = code, msg = msg, count = total, data = list });
        }

        public async Task<IActionResult> CerateOrEdit([FromBody]ESysMenu eSysMenu)
        {
            bool flag = false;
            try
            {
                if (eSysMenu.MenuID == 0)
                {
                    using (var uow = _uowFactory.Create())
                    {
                        flag = await _SysMenuRepository.AddAsync(eSysMenu);
                        uow.SaveChanges();
                    }
                    if (flag)
                    {
                        return Ok(new { status = true, message = "success" });
                    }
                    else
                    {
                        return Ok(new { status = false, message = "error" });
                    }
                }
                else
                {
                    using (var uow = _uowFactory.Create())
                    {
                        flag = await _SysMenuRepository.UpdateAsync(eSysMenu);
                        uow.SaveChanges();
                    }
                    if (flag)
                    {
                        return Ok(new { status = true, message = "success" });
                    }
                    else
                    {
                        return Ok(new { status = false, message = "error" });
                    }
                }
            }
            catch (Exception ex)
            {
                return Ok(new { status = false, message = ex.Message });
            }
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int ID)
        {
            try
            {
                if (ID > 0)
                {
                    bool flag = false;
                    using (var uow = _uowFactory.Create())
                    {
                        flag = await _SysMenuRepository.DeleteAsync(ID);
                        uow.SaveChanges();
                    }
                    if (flag)
                    {
                        return Ok(new { status = true, message = "success" });
                    }
                    else
                    {
                        return Ok(new { status = false, message = "error" });
                    }
                }
                else
                {
                    return Ok(new { status = false, message = "del error" });
                }
            }
            catch (Exception ex)
            {
                return Ok(new { status = false, message = ex.Message });
            }
        }

        [HttpPost]
        public async Task<IActionResult> Deletes(string IDS)
        {
            try
            {
                if (!string.IsNullOrEmpty(IDS) && IDS.Length > 0)
                {
                    bool flag = false;
                    using (var uow = _uowFactory.Create())
                    {
                        flag = await _SysMenuRepository.DeletesAsync(IDS);
                        uow.SaveChanges();
                    }
                    if (flag)
                    {
                        return Ok(new { status = true, message = "success" });
                    }
                    else
                    {
                        return Ok(new { status = false, message = "error" });
                    }
                }
                else
                {
                    return Ok(new { status = false, message = "dels error" });
                }
            }
            catch (Exception ex)
            {
                return Ok(new { status = false, message = ex.Message });
            }
        }
    }


}