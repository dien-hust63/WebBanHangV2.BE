using Gather.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using WebBanHang.Common.Entities.Model;
using WebBanHang.Common.Entities.Param;
using WebBanHang.Common.Interfaces.Base;
using WebBanHang.Common.Interfaces.BL;
using WebBanHang.Common.Interfaces.DL;
using WebBanHang.Common.Services;
using WebBanHang.DL.DL;

namespace WebBanHang.BL.BL
{
    public class OrderBL : BaseBL<SaleOrder>, IOrderBL
    {
        IOrderDL _orderDL;

        public OrderBL(IBaseDL<SaleOrder> baseDL, IOrderDL orderDL) : base(baseDL)
        {
            _orderDL = orderDL;
        }

        /// <summary>
        /// thêm đơn hàng
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public ServiceResult InsertOrderDetail(OrderDetailParam param)
        {
            ServiceResult serviceResult = new ServiceResult();
            SaleOrder order = new SaleOrder();
            List<OrderDetail> listOrderDetail = new List<OrderDetail>();
            order = JsonSerializer.Deserialize<SaleOrder>(param.order);
            listOrderDetail = JsonSerializer.Deserialize<List<OrderDetail>>(param.orderdetail);
            SaleOrder? result = _orderDL.InsertOrderDetail(order, listOrderDetail);
            if(order != null)
            {
                // gửi mail
            }


            serviceResult.Data = result;
            return serviceResult;
        }
    }
}
