using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanHang.Common.Entities.Model;
using WebBanHang.Common.Interfaces.Base;
using WebBanHang.Common.Interfaces.BL;
using WebBanHang.Common.Interfaces.DL;
using WebBanHang.Common.Services;

namespace WebBanHang.BL.BL
{
    public class RoleBL : BaseBL<Role>, IRoleBL
    {
        IRoleDL _roleDL;

        public RoleBL(IBaseDL<Role> baseDL, IRoleDL roleDL) : base(baseDL)
        {
            _roleDL = roleDL;
        }

    }
}
