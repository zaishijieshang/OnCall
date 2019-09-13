using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OnCall.Web.Controllers
{
    using OnCall.Web.Domain.Infrastructure.DP;
    using OnCall.Web.Domain.Entity;
    using OnCall.Web.Domain.Repository.Systems;
    public class SysRoleController : BaseController
    {
        private readonly IUnitOfWorkFactory _uowFactory;
        private readonly ISysRoleRepository _SysRoleRepository;

        public SysRoleController(IUnitOfWorkFactory uowFactory, ISysRoleRepository SysRoleRepository)
        {
            _uowFactory = uowFactory;
            _SysRoleRepository = SysRoleRepository;
        }
        public IActionResult Index()
        {
            return View("~/Views/Systems/SysRole/Index.cshtml");
        }
        public IActionResult Edit()
        {
            return View("~/Views/Systems/SysRole/Edit.cshtml");
        }
        public async Task<IActionResult> PageData(int page, int limit, string RoleName)
        {
            string msg = string.Empty;
            int code = 0;
            int total = 0;
            string sWhere = string.Empty;
            IEnumerable<ESysRole> list = null;
            try
            {
                var param = new Dapper.DynamicParameters();
                if (!string.IsNullOrEmpty(RoleName))
                {
                    sWhere += " and RoleName like @RoleName";
                    param.Add("RoleName", string.Format("%{0}%", RoleName));
                }

                total = await _SysRoleRepository.GetTotalCount(sWhere, param);
                list = await _SysRoleRepository.GetPageAsync(page, limit, sWhere, param);
            }
            catch (Exception ex)
            {
                code = -1;
                msg = ex.Message;
            }
            return Ok(new { code = code, msg = msg, count = total, data = list });
        }

        public async Task<IActionResult> CerateOrEdit([FromBody]ESysRole eSysRole)
        {
            bool flag = false;
            try
            {
                if (eSysRole.RoleID == 0)
                {
                    using (var uow = _uowFactory.Create())
                    {
                        flag = await _SysRoleRepository.AddAsync(eSysRole);
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
                        flag = await _SysRoleRepository.UpdateAsync(eSysRole);
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
                        flag = await _SysRoleRepository.DeleteAsync(ID);
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
                        flag = await _SysRoleRepository.DeletesAsync(IDS);
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