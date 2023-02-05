using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanHang.Common.Attributes;

namespace WebBanHang.Common.Entities.Model
{
    public class Branch
    {
        [AttributeCustomId]
        public int idbranch { get; set; }

        [AttributeCustomUnique]
        [AttributeCustomDisplayName("Mã chi nhánh")]
        public string branchcode { get; set; }

        public string  branchname { get; set; }

        public string address { get; set; }

        public int branchmanagerid { get; set; }

        public string branchmanagername { get; set; }
    }
}
