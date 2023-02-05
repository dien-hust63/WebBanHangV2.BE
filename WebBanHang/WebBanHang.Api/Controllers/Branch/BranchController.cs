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
    public class BranchController : BaseEntityController<Branch>
    {
        IBaseBL<Branch> _baseBL;
        IBranchBL _branchBL;
        public BranchController(IBaseBL<Branch> baseBL, IBranchBL branchBL) : base(baseBL)
        {
            _baseBL = baseBL;
            _branchBL = branchBL;
        }


    }
}
