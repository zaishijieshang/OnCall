using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OnCall.Web.Controllers
{
    using OnCall.Web.Domain.Entity;
    using OnCall.Web.Domain.Enum;
    using OnCall.Web.Domain.Infrastructure.DP;
    using OnCall.Web.Domain.Repository.Systems;
    using OnCall.Web.Models;
    using System.Text;

    public class SysRoleAlarmLevelController : BaseController
    {
        private readonly IUnitOfWorkFactory _uowFactory;
        private readonly ISysRoleAlarmLevelRepository _SysRoleAlarmLevelRepository;
        private readonly ISysAlarmLevelRepository _SysAlarmLevelRepository;

        public SysRoleAlarmLevelController(IUnitOfWorkFactory uowFactory, ISysRoleAlarmLevelRepository SysRoleAlarmLevelRepository, ISysAlarmLevelRepository SysAlarmLevelRepository)
        {
            _uowFactory = uowFactory;
            _SysRoleAlarmLevelRepository = SysRoleAlarmLevelRepository;
            _SysAlarmLevelRepository = SysAlarmLevelRepository;
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


            StringBuilder htmlAlarmCrewLevel = new StringBuilder();
            StringBuilder htmlAlarmVariableBitLevel = new StringBuilder();

            try
            {
                //该报警全部选项
                IEnumerable<ESysAlarmLevel> alarmCrewLevel = await _SysAlarmLevelRepository.GetAlarmLevel(Convert.ToInt32(enAlarmLevelType.AlarmCrewLevel));

                //获取该报警已有权限
                var listChild = await _SysRoleAlarmLevelRepository.GetAlarmLevelByRoleID(RoleID, enAlarmLevelType.AlarmCrewLevel);
                foreach (var item in alarmCrewLevel)
                {
                    bool isChecked = false;
                    foreach (var itemChild in listChild)
                    {
                        if (itemChild.AlarmLevel == item.ID)
                        {
                            isChecked = true;
                        }
                    }

                    htmlAlarmCrewLevel.AppendFormat("<input type =\"checkbox\" name=\"AlarmCrewLevel\" value=\"{0}\"  title=\"{1}\" {2}>",
                        item.ID, item.AlarmLevel, isChecked ? "checked=\"checked\"" : "");
                }

                IEnumerable<ESysAlarmLevel> alarmVariableBitLevel = await _SysAlarmLevelRepository.GetAlarmLevel(Convert.ToInt32(enAlarmLevelType.AlarmVariableBitLevel));

                var listChild2 = await _SysRoleAlarmLevelRepository.GetAlarmLevelByRoleID(RoleID, enAlarmLevelType.AlarmVariableBitLevel);
                foreach (var item in alarmVariableBitLevel)
                {
                    bool isChecked2 = false;
                    foreach (var itemChild in listChild2)
                    {
                        if (itemChild.AlarmLevel == item.ID)
                        {
                            isChecked2 = true;
                        }
                    }

                    htmlAlarmVariableBitLevel.AppendFormat("<input type =\"checkbox\" name=\"AlarmVariableBitLevel\" value=\"{0}\"  title=\"{1}\" {2}>",
                        item.ID, item.AlarmLevel, isChecked2 ? "checked=\"checked\"" : "");

                }

                status = true;
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return Ok(new
            {
                status = status,
                htmlAlarmCrewLevel = htmlAlarmCrewLevel.ToString(),
                htmlAlarmVariableBitLevel = htmlAlarmVariableBitLevel.ToString(),
            });
        }



        public async Task<IActionResult> CerateOrEdit(int RoleID, string AarmCrewLevel, string AlarmVariableBitLevel)//[FromBody]ESysRoleAlarmLevel eSysRoleAlarmLevel
        {
            bool flag = false;
            try
            {
                using (var uow = _uowFactory.Create())
                {
                    flag = await _SysRoleAlarmLevelRepository.DeleteAsync(RoleID);

                    if (!string.IsNullOrEmpty(AarmCrewLevel) && RoleID > 0)
                    {
                        foreach (string item in AarmCrewLevel.Split(','))
                        {
                            flag = await _SysRoleAlarmLevelRepository.AddAsync(new ESysRoleAlarmLevel
                            {
                                AlarmType = (int)enAlarmLevelType.AlarmCrewLevel,
                                AlarmLevel = Convert.ToInt32(item),
                                RoleID = RoleID
                            });
                        }
                    }

                    if (!string.IsNullOrEmpty(AlarmVariableBitLevel) && RoleID > 0)
                    {
                        foreach (string item in AlarmVariableBitLevel.Split(','))
                        {
                            flag = await _SysRoleAlarmLevelRepository.AddAsync(new ESysRoleAlarmLevel
                            {
                                AlarmType = (int)enAlarmLevelType.AlarmVariableBitLevel,
                                AlarmLevel = Convert.ToInt32(item),
                                RoleID = RoleID
                            });
                        }
                    }

                    uow.SaveChanges();
                }


                if (flag)
                {
                    return Ok(new { status = true, message = "success" });
                }
                else
                {
                    if (string.IsNullOrEmpty(AarmCrewLevel) && string.IsNullOrEmpty(AlarmVariableBitLevel))
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