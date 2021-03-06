﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OnCall.Web.Controllers
{
    using OnCall.Web.Domain.Entity;
    using OnCall.Web.Domain.Infrastructure.DP;
    using OnCall.Web.Domain.Repository.Systems;

    public class SysAlarmLevelController : BaseController
    {
        private readonly IUnitOfWorkFactory _uowFactory;
        private readonly ISysAlarmLevelRepository _SysAlarmLevelRepository;

        public SysAlarmLevelController(IUnitOfWorkFactory uowFactory, ISysAlarmLevelRepository SysAlarmLevelRepository)
        {
            _uowFactory = uowFactory;
            _SysAlarmLevelRepository = SysAlarmLevelRepository;
        }
        public IActionResult Index()
        {
            return View("~/Views/Systems/SysAlarmLevel/Index.cshtml");
        }
        public IActionResult Edit()
        {
            return View("~/Views/Systems/SysAlarmLevel/Edit.cshtml");
        }
        public async Task<IActionResult> PageData(int page, int limit)
        {
            string msg = string.Empty;
            int code = 0;
            int total = 0;
            string sWhere = string.Empty;
            IEnumerable<ESysAlarmLevel> list = null;
            try
            {
                var param = new Dapper.DynamicParameters();

                total = await _SysAlarmLevelRepository.GetTotalCount(sWhere, param);
                list = await _SysAlarmLevelRepository.GetPageAsync(page, limit, sWhere, param);
            }
            catch (Exception ex)
            {
                code = -1;
                msg = ex.Message;
            }
            return Ok(new { code = code, msg = msg, count = total, data = list });
        }

        public async Task<IActionResult> CerateOrEdit([FromBody]ESysAlarmLevel eSysAlarmLevel)
        {
            bool flag = false;
            try
            {
                if (eSysAlarmLevel.ID == 0)
                {
                    using (var uow = _uowFactory.Create())
                    {
                        flag = await _SysAlarmLevelRepository.AddAsync(eSysAlarmLevel);
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
                        flag = await _SysAlarmLevelRepository.UpdateAsync(eSysAlarmLevel);
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
                        flag = await _SysAlarmLevelRepository.DeleteAsync(ID);
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
                        flag = await _SysAlarmLevelRepository.DeletesAsync(IDS);
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