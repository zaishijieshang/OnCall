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

    public class SysKeywordsController : BaseController
    {
        private readonly IUnitOfWorkFactory _uowFactory;
        private readonly ISysKeywordsRepository _SysKeywordsRepository;

        public SysKeywordsController(IUnitOfWorkFactory uowFactory, ISysKeywordsRepository SysKeywordsRepository)
        {
            _uowFactory = uowFactory;
            _SysKeywordsRepository = SysKeywordsRepository;
        }
        public IActionResult Index()
        {
            return View("~/Views/Systems/SysKeywords/Index.cshtml");
        }
        public IActionResult Edit()
        {
            return View("~/Views/Systems/SysKeywords/Edit.cshtml");
        }
        public async Task<IActionResult> PageData(int page, int limit, string Keyword)
        {
            string msg = string.Empty;
            int code = 0;
            int total = 0;
            string sWhere = string.Empty;
            IEnumerable<ESysKeywords> list = null;
            try
            {
                var param = new Dapper.DynamicParameters();
                if (!string.IsNullOrEmpty(Keyword))
                {
                    sWhere += " and Keyword like @Keyword";
                    param.Add("Keyword", string.Format("%{0}%", Keyword));
                }

                total = await _SysKeywordsRepository.GetTotalCount(sWhere, param);
                list = await _SysKeywordsRepository.GetPageAsync(page, limit, sWhere, param);
            }
            catch (Exception ex)
            {
                code = -1;
                msg = ex.Message;
            }
            return Ok(new { code = code, msg = msg, count = total, data = list });
        }

        public async Task<IActionResult> CerateOrEdit([FromBody]ESysKeywords eSysKeywords)
        {
            bool flag = false;
            try
            {
                if (eSysKeywords.ID == 0)
                {
                    using (var uow = _uowFactory.Create())
                    {
                        flag = await _SysKeywordsRepository.AddAsync(eSysKeywords);
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
                        flag = await _SysKeywordsRepository.UpdateAsync(eSysKeywords);
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
                        flag = await _SysKeywordsRepository.DeleteAsync(ID);
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
                        flag = await _SysKeywordsRepository.DeletesAsync(IDS);
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