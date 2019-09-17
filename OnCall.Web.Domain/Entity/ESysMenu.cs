using System;
using System.Collections.Generic;
using System.Text;

namespace OnCall.Web.Domain.Entity
{
    public class ESysMenu
    {

        ///<summary>
        /// 菜单ID
        ///</summary>
        public int MenuID { get; set; }
        ///<summary>
        /// 菜单名称Query
        ///</summary>
        public string MenuTitle { get; set; }
        ///<summary>
        /// 链接
        ///</summary>
        public string MenuUrl { get; set; }
        ///<summary>
        /// 父菜单ID
        ///</summary>
        public int ParentID { get; set; }
        ///<summary>
        /// 样式
        ///</summary>
        public string Style { get; set; }
        ///<summary>
        /// 排序
        ///</summary>
        public int Sort { get; set; }
        ///<summary>
        /// 状态
        ///</summary>
        public int Status { get; set; }
    }



}
