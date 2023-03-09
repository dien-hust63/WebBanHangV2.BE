﻿using Gather.ApplicationCore.Entities;
using Gather.ApplicationCore.Entities.Param;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanHang.Common.Entities;
using WebBanHang.Common.Entities.Model;
using WebBanHang.Common.Entities.Param;
using WebBanHang.Common.Interfaces.Base;
using WebBanHang.Common.Interfaces.BL;

namespace WebBanHang.Api.Controllers
{
    public class OrderController : BaseEntityController<SaleOrder>
    {
        IBaseBL<SaleOrder> _baseBL;
        IOrderBL _orderBL;
        public OrderController(IBaseBL<SaleOrder> baseBL, IOrderBL orderBL) : base(baseBL)
        {
            _baseBL = baseBL;
            _orderBL = orderBL;
        }

        /// <summary>
        /// Thêm mới dữ liệu hàng hóa
        /// </summary>
        /// <param name="entity">Dữ liệu được thêm</param>
        /// <returns></returns>
        /// CreatedBy: nvdien(17/8/2021)
        /// ModifiedBy: ndien(17/8/2021)
        [HttpPost("insertOrderDetail")]
        public async Task<ServiceResult> insertOrderDetail( OrderDetailParam param)
        {
            ServiceResult serviceResult = new ServiceResult();
            try
            {
                serviceResult = _orderBL.InsertOrderDetail(param);
            }
            catch (Exception ex)
            {
                serviceResult.setError(ex.Message);
            }
            return serviceResult;
        }


    }
}
