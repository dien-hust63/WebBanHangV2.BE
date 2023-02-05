using Gather.ApplicationCore.Entities;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanHang.Common;
using WebBanHang.Common.Entities;
using WebBanHang.Common.Entities.Model;
using WebBanHang.Common.Interfaces.BL;
using WebBanHang.Common.Interfaces.DL;

namespace WebBanHang.BL.BL
{
    public class AuthenticationBL : IAuthenticationBL
    {
        IAuthenticationDL _authenDL;
        IConfiguration _config;
        public AuthenticationBL(IAuthenticationDL authenDL, IConfiguration config) 
        {
            _authenDL = authenDL;
            _config = config;
        }
        /// <summary>
        /// kiểm tra tài khoản có hợp lệ không
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public bool checkUserAccount(LoginParam employee)
        {
            Employee employeeInfo = _authenDL.getEmployeeByEmail(employee.email);
            if(employeeInfo != null)
            {
                byte[] desKey = Convert.FromBase64String(_config.GetSection("DES").GetSection("Key").Value ?? "");
                byte[] desVI = Convert.FromBase64String(_config.GetSection("DES").GetSection("VI").Value ?? "");
                string passBase64 = DESUtility.Encrypt(employee.password, desKey, desVI);
                if (employeeInfo.password.Equals(passBase64))
                {
                    return true;
                }
            }
            return false;
        }

        public ServiceResult loginManagementApplication(Employee employee)
        {
            throw new NotImplementedException();
        }

        public ServiceResult registerManagementApplication(Employee employee)
        {
            var serviceResult = new ServiceResult();
            byte[] desKey = Convert.FromBase64String(_config.GetSection("DES").GetSection("Key").Value??"");
            byte[] desVI = Convert.FromBase64String(_config.GetSection("DES").GetSection("VI").Value ?? "");
            // encrypt password to save in database
            employee.password = DESUtility.Encrypt(employee.password, desKey, desVI);
            bool regisData =  _authenDL.registerManagementApplication(employee);
            serviceResult.Data = regisData;
            if (!regisData)
            {
                serviceResult.setError("Register fail");
            }
            return serviceResult;
        }
    }
}
