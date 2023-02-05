using Gather.ApplicationCore.Entities;
using Gather.ApplicationCore.Entities.Param;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanHang.Common.Entities.Model;
using WebBanHang.Common.Interfaces.Base;
using WebBanHang.Common.Interfaces.BL;

namespace WebBanHang.Api.Controllers
{
    public class EmployeeController : BaseEntityController<Employee>
    {
        IBaseBL<Employee> _baseBL;
        IEmployeeBL _employeeBL;
        public EmployeeController(IBaseBL<Employee> baseBL, IEmployeeBL employeeBL) :base(baseBL)
        {
            _baseBL = baseBL;
            _employeeBL = employeeBL;
        }

      
    }
}
