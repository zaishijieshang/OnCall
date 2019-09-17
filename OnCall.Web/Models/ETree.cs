using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnCall.Web.Models
{
    public class ETree
    {
        /// <summary>
        /// 节点唯一索引值，用于对指定节点进行各类操作
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 节点标题
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 节点字段名(一般对应表字段名)
        /// </summary>
        public string field { get; set; }
        /// <summary>
        ///子节点。支持设定选项同父节点
        /// </summary>
        public List<ETree> children { get; set; }
        /// <summary>
        /// 点击节点弹出新窗口对应的 url。需开启 isJump 参数
        /// </summary>
        public string href { get; set; }
        /// <summary>
        /// 节点是否初始展开，默认 false
        /// </summary>
        public bool spread { get; set; }
        /// <summary>
        /// 节点是否初始为选中状态（如果开启复选框的话），默认 false
        /// </summary>
        public bool @checked { get; set; }
        /// <summary>
        /// 节点是否为禁用状态。默认 false
        /// </summary>
        public bool disabled { get; set; }
    }
}
