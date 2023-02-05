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
    public class RoleController : BaseEntityController<Role>
    {
        IBaseBL<Role> _baseBL;
        IRoleBL _roleBL;
        public RoleController(IBaseBL<Role> baseBL, IRoleBL roleBL) : base(baseBL)
        {
            _baseBL = baseBL;
            _roleBL = roleBL;
        }


    }
}
