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

    public class SysRoleAlarmLevelController : BaseController
    {
        private readonly IUnitOfWorkFactory _uowFactory;
        private readonly ISysRoleAlarmLevelRepository _SysRoleAlarmLevelRepository;

        public SysRoleAlarmLevelController(IUnitOfWorkFactory uowFactory, ISysRoleAlarmLevelRepository SysRoleAlarmLevelRepository)
        {
            _uowFactory = uowFactory;
            _SysRoleAlarmLevelRepository = SysRoleAlarmLevelRepository;
        }
        public IActionResult Index()
        {
            return View("~/Views/Systems/SysRoleAlarmLevel/Index.cshtml");
        }
        public IActionResult Edit()
        {
            return View("~/Views/Systems/SysRoleAlarmLevel/Edit.cshtml");
        }
        public async Task<IActionResult> GetAlarmLevelByRole(int RoleID)
        {
            string msg = string.Empty;
            bool status = false;
            List<string> roleAlarmLevel = new List<string>();
            IEnumerable<string> alarmLevel = null;
            try
            {
                var list = await _SysRoleAlarmLevelRepository.GetAlarmLevelByRoleID(RoleID);
                foreach (var item in list)
                {
                    roleAlarmLevel.Add(item.AlarmLevel);
                }
                alarmLevel = await _SysRoleAlarmLevelRepository.GetAlarmLevel();
                status = true;
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return Ok(new { status = status, roleAlarmLevel = roleAlarmLevel, alarmLevels = alarmLevel });
        }



        public async Task<IActionResult> CerateOrEdit(int RoleID, string AlarmLevels)//[FromBody]ESysRoleAlarmLevel eSysRoleAlarmLevel
        {
            bool flag = false;
            try
            {

                if (!string.IsNullOrEmpty(AlarmLevels) && RoleID > 0)
                {
                    using (var uow = _uowFactory.Create())
                    {
                        await _SysRoleAlarmLevelRepository.DeleteAsync(RoleID);

                        foreach (string item in AlarmLevels.Split(','))
                        {
                            flag = await _SysRoleAlarmLevelRepository.AddAsync(new ESysRoleAlarmLevel { AlarmLevel = item, RoleID = RoleID });
                        }

                        uow.SaveChanges();
                    }
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
                        flag = await _SysRoleAlarmLevelRepository.DeleteAsync(ID);
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

        //[HttpPost]
        //public async Task<IActionResult> Deletes(string IDS)
        //{
        //    try
        //    {
        //        if (!string.IsNullOrEmpty(IDS) && IDS.Length > 0)
        //        {
        //            bool flag = false;
        //            using (var uow = _uowFactory.Create())
        //            {
        //                flag = await _SysRoleAlarmLevelRepository.DeletesAsync(IDS);
        //                uow.SaveChanges();
        //            }
        //            if (flag)
        //            {
        //                return Ok(new { status = true, message = "success" });
        //            }
        //            else
        //            {
        //                return Ok(new { status = false, message = "error" });
        //            }
        //        }
        //        else
        //        {
        //            return Ok(new { status = false, message = "dels error" });
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(new { status = false, message = ex.Message });
        //    }
        //}
    }

}