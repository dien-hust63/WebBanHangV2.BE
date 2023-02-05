using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static WebBanHang.Common.Enumeration.Enumeration;

namespace WebBanHang.Common.Entities.Model
{
    public class Employee
    {
        public int idemployee { get; set; }

        public string employeecode { get; set; }

        public string employeename{ get; set; }

        public string email { get; set; }

        public string password { get; set; }

        public int branchid { get; set; }

        public string branchname { get; set; }

        public AccountStatus statusid { get; set; }

        public string statustext { get; set; }
    }
}
