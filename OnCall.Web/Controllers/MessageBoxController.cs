using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnCall.Web.Domain.Infrastructure.DP;
using OnCall.Web.Domain.Entity;
using OnCall.Web.Domain.Repository.MessageBox;

namespace OnCall.Web.Controllers
{
    public class MessageBoxController : Controller
    {

        private readonly IUnitOfWorkFactory _uowFactory;
        private readonly IMessageBoxRepository _MessageBoxRepository;

        public MessageBoxController(IUnitOfWorkFactory uowFactory, IMessageBoxRepository MessageBoxRepository)
        {
            _uowFactory = uowFactory;
            _MessageBoxRepository = MessageBoxRepository;
        }
        public IActionResult Drafts()
        {
            return View("~/Views/MessageBox/Drafts.cshtml");
        }
        public IActionResult Inbox()
        {
            return View("~/Views/MessageBox/Inbox.cshtml");
        }
        public IActionResult Outbox()
        {
            return View("~/Views/MessageBox/Outbox.cshtml");
        }

        public IActionResult Edit()
        {
            return View("~/Views/MessageBox/Edit.cshtml");
        }
        public async Task<IActionResult> PageData(int page, int limit, string Title, string Content, int type)
        {
            string msg = string.Empty;
            int code = 0;
            int total = 0;
            string sWhere = string.Empty;
            IEnumerable<EMessageBox> list = null;
            try
            {
                var param = new Dapper.DynamicParameters();
                if (!string.IsNullOrEmpty(Title))
                {
                    sWhere += " and Title like @Title";
                    param.Add("Title", string.Format("%{0}%", Title));
                }
                if (!string.IsNullOrEmpty(Content))
                {
                    sWhere += " and Content like @Content";
                    param.Add("Content", string.Format("%{0}%", Content));
                }

                total = await _MessageBoxRepository.GetTotalCount(sWhere, param);
                list = await _MessageBoxRepository.GetPageAsync(page, limit, sWhere, param);
            }
            catch (Exception ex)
            {
                code = -1;
                msg = ex.Message;
            }
            return Ok(new { code = code, msg = msg, count = total, data = list });
        }


        public async Task<IActionResult> CerateOrEdit([FromBody]EMessageBox eMessageBox)
        {
            bool flag = false;
            try
            {
                if (eMessageBox.ID == 0)
                {
                    using (var uow = _uowFactory.Create())
                    {
                        flag = await _MessageBoxRepository.AddAsync(eMessageBox);
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
                        flag = await _MessageBoxRepository.UpdateAsync(eMessageBox);
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
                        flag = await _MessageBoxRepository.DeleteAsync(ID);
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
                        flag = await _MessageBoxRepository.DeletesAsync(IDS);
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