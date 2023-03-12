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

            // Tạo mã đơn hàng tự động
            order.ordercode = CreateAutoOrderCode();

            listOrderDetail = JsonSerializer.Deserialize<List<OrderDetail>>(param.orderdetail);
            SaleOrder? result = _orderDL.InsertOrderDetail(order, listOrderDetail);
            if(order != null)
            {
                // gửi mail
            }


            serviceResult.Data = result;
            return serviceResult;
        }

        public string CreateAutoOrderCode()
        {
            string newCode = "";
            SaleOrder lastOrder = _orderDL.GetLastestOrder(); 
            if(lastOrder != null)
            {
                string lastCode = lastOrder.ordercode;
                int codenumber = int.Parse(lastCode.Substring(2)) + 1;
                newCode = "DH" + codenumber.ToString();
            }
            else
            {
                newCode = "DH100001";
            }
            return newCode;
        }



        /// <summary>
        /// Lấy chi tiết đơn hàng
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        public ServiceResult getOrderDetail(int entityId)
        {
            ServiceResult serviceResult = new ServiceResult();
            serviceResult.Data = _orderDL.getOrderDetail(entityId);
            return serviceResult;
        }


        /// <summary>
        /// Cập nhật đơn hàng
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public ServiceResult UpdateOrderDetail(OrderDetailParam param)
        {
            ServiceResult serviceResult = new ServiceResult();
            SaleOrder order = new SaleOrder();
            List<OrderDetail> listOrderDetail = new List<OrderDetail>();
            order = JsonSerializer.Deserialize<SaleOrder>(param.order);
            listOrderDetail = JsonSerializer.Deserialize<List<OrderDetail>>(param.orderdetail);
            SaleOrder? result = _orderDL.UpdateOrderDetail(order, listOrderDetail);



            serviceResult.Data = result;
            return serviceResult;
        }
    }
}
