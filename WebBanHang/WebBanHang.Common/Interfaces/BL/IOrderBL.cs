using Gather.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanHang.Common.Entities.Model;
using WebBanHang.Common.Entities.Param;
using WebBanHang.Common.Interfaces.Base;

namespace WebBanHang.Common.Interfaces.BL
{
    public interface IOrderBL : IBaseBL<SaleOrder>
    {
        /// <summary>
        /// Thêm mới product
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public ServiceResult InsertOrderDetail(OrderDetailParam param);


        /// <summary>
        /// Xem chi tiết sản phẩm
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>

        ServiceResult getOrderDetail(int entityId);

        /// <summary>
        /// Cập nhật đơn hàng
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public ServiceResult UpdateOrderDetail(OrderDetailParam param);

        /// <summary>
        /// Tạo mã đơn hàng tự động
        /// </summary>
        /// <returns></returns>
        public string CreateAutoOrderCode();
    }
}
