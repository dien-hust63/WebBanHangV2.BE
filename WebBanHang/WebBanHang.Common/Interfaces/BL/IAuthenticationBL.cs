using Gather.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanHang.Common.Entities;
using WebBanHang.Common.Entities.Model;

namespace WebBanHang.Common.Interfaces.BL
{
    public interface IAuthenticationBL
    {
        public ServiceResult registerManagementApplication(Employee employee);

        public ServiceResult loginManagementApplication(Employee employee);

        public bool checkUserAccount(LoginParam employee);
    }
}
