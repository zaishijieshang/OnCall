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
    using OnCall.Web.Models;

    public class SysRoleMenuController : BaseController
    {
        private readonly IUnitOfWorkFactory _uowFactory;
        private readonly ISysRoleMenuRepository _SysRoleMenuRepository;
        private readonly ISysMenuRepository _SysMenuRepository;

        public SysRoleMenuController(IUnitOfWorkFactory uowFactory, ISysRoleMenuRepository SysRoleMenuRepository, ISysMenuRepository SysMenuRepository)
        {
            _uowFactory = uowFactory;
            _SysRoleMenuRepository = SysRoleMenuRepository;
            _SysMenuRepository = SysMenuRepository;
        }
        public IActionResult Index()
        {
            return View("~/Views/Systems/SysRoleMenu/Index.cshtml");
        }
        public IActionResult Edit()
        {
            return View("~/Views/Systems/SysRoleMenu/Edit.cshtml");
        }
        public async Task<IActionResult> RoleMenuTreeData(int RoleID)
        {
            string msg = string.Empty;
            bool status = false;
            string sWhere = string.Empty;
            IEnumerable<ETree> listMenus = null;
            IEnumerable<ESysMenu> rootMenus = null;
            List<int> listRoleMenuIDs = new List<int>();
            try
            {
                if (RoleID > 0)
                {
                    var param = new Dapper.DynamicParameters();

                    //查询该角色Menus
                    sWhere += " and RoleID=@RoleID";
                    param.Add("RoleID", RoleID);
                    var listRoleMenuData = await _SysRoleMenuRepository.GetMenuByRoleAsync(sWhere, param);

                    rootMenus = await _SysMenuRepository.GetMenuByParentIDAsync(0);


                    foreach (var p in listRoleMenuData)
                    {
                        bool flag = true;
                        foreach (var pp in rootMenus)
                        {
                            if (p.MenuID == pp.MenuID)
                            {
                                flag = false;
                                break;
                            }
                        }

                        if (flag)
                        {
                            listRoleMenuIDs.Add(p.MenuID);
                        }
                    }

                    //获取该权限的MenuIDs 排除RootMenuID
                    listMenus = await BuilderTreeAsync(listRoleMenuIDs);

                    status = true;
                }
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return Ok(new { status = status, msg = msg, listRoleMenuIDs = listRoleMenuIDs, listMenuData = listMenus });
        }




        //树组装 
        private async Task<List<ETree>> BuilderTreeAsync(int ParentID = 0)
        {
            IEnumerable<ESysMenu> listMenus = await _SysMenuRepository.GetMenuByParentIDAsync(ParentID);

            List<ETree> _treeList = new List<ETree>();

            try
            {
                if (listMenus.Count() > 0)
                {
                    ETree _tree = null;
                    foreach (ESysMenu item in listMenus)
                    {
                        _tree = new ETree();
                        _tree.id = item.MenuID;
                        _tree.title = item.MenuTitle;
                        _tree.href = item.MenuUrl;
                        _tree.spread = true;//展开

                        var listChildMenus = await BuilderTreeAsync(_tree.id);
                        if (listChildMenus.Count > 0)
                        {
                            _tree.children = new List<ETree>();
                            _tree.children.AddRange(listChildMenus);
                        }

                        _treeList.Add(_tree);
                    }

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return _treeList;
        }

        //组装数并初始化勾选
        private async Task<List<ETree>> BuilderTreeAsync(List<int> InitCheck, int ParentID = 0)
        {
            IEnumerable<ESysMenu> listMenus = await _SysMenuRepository.GetMenuByParentIDAsync(ParentID);

            List<ETree> _treeList = new List<ETree>();

            try
            {
                if (listMenus.Count() > 0)
                {
                    ETree _tree = null;
                    foreach (ESysMenu item in listMenus)
                    {
                        _tree = new ETree();
                        _tree.id = item.MenuID;
                        _tree.title = item.MenuTitle;
                        _tree.href = item.MenuUrl;
                        _tree.spread = true;//展开

                        InitCheck.ForEach(p =>
                        {
                            if (p == _tree.id)
                            {
                                _tree.@checked = true;
                            }
                        });

                        var listChildMenus = await BuilderTreeAsync(InitCheck, _tree.id);
                        if (listChildMenus.Count > 0)
                        {
                            _tree.children = new List<ETree>();
                            _tree.children.AddRange(listChildMenus);
                        }

                        _treeList.Add(_tree);
                    }

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return _treeList;
        }




        public async Task<IActionResult> CerateOrEdit(int RoleID, string MenuIDs)
        {
            bool flag = false;
            try
            {
                if (!string.IsNullOrEmpty(MenuIDs) && RoleID > 0)
                {
                    using (var uow = _uowFactory.Create())
                    {
                        await _SysRoleMenuRepository.DeleteAsync(RoleID);
                        foreach (string menuId in MenuIDs.Split(','))
                        {
                            flag = await _SysRoleMenuRepository.AddAsync(new ESysRoleMenu() { RoleID = RoleID, MenuID = Convert.ToInt32(menuId) });
                        }

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
                        flag = await _SysRoleMenuRepository.DeleteAsync(ID);
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


    }

}