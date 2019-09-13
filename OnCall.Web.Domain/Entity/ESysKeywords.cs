using System;
using System.Collections.Generic;
using System.Text;

namespace OnCall.Web.Domain.Entity
{
    public class ESysKeywords
    {
        ///<summary>
        /// ID
        ///</summary>
        public int ID { get; set; }
        ///<summary>
        /// 关键字Query
        ///</summary>
        public string Keyword { get; set; }
        ///<summary>
        /// 替换值
        ///</summary>
        public string ReplaceValue { get; set; }
        ///<summary>
        /// 状态
        ///</summary>
        public int Status { get; set; }
    }

}
