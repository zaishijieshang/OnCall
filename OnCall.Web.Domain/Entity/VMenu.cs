using System;
using System.Collections.Generic;
using System.Text;

namespace OnCall.Web.Domain.Entity
{
    [Serializable]
    public class VMenu
    {
        public int MenuID { get; set; }
        public string MenuTitle { get; set; }
        public string MenuUrl { get; set; }
        public int ParentID { get; set; }
        public string Style { get; set; }
    }
}
