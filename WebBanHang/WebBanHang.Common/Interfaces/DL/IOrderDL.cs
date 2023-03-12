using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanHang.Common.Entities.Model;
using WebBanHang.Common.Interfaces.Base;

namespace WebBanHang.Common.Interfaces.DL
{
    public interface IOrderDL : IBaseDL<SaleOrder>
    {
        /// <summary>
        /// Thêm mới product
        /// </summary>
        /// <param name="product"></param>
        /// <param name="listProductDetail"></param>
        /// <returns></returns>
        public SaleOrder InsertOrderDetail(SaleOrder order, List<OrderDetail> listOrderDetail);

        /// <summary>
        /// Lấy chi tiết đơn hàng
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        object getOrderDetail(int entityId);

        /// <summary>
        /// Sửa đơn hàng
        /// </summary>
        /// <param name="order"></param>
        /// <param name="listOrderDetail"></param>
        /// <returns></returns>
        public SaleOrder UpdateOrderDetail(SaleOrder order, List<OrderDetail> listOrderDetail);

        /// <summary>
        /// lấy thông order code cuối ucngf
        /// </summary>
        /// <returns></returns>
        public SaleOrder GetLastestOrder();

    }
}
