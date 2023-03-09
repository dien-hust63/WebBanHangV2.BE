using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanHang.Common.DBHelper;
using WebBanHang.Common.Entities.Model;
using WebBanHang.Common.Interfaces.DL;
using WebBanHang.Common.ServiceCollection;
using WebBanHang.DL.BaseDL;

namespace WebBanHang.DL.DL
{
    public class OrderDL : BaseDL<SaleOrder>, IOrderDL
    {
        public OrderDL(IConfiguration configuration, IDBHelper dbHelper) : base(configuration, dbHelper)
        { 
        }

        /// <summary>
        /// thêm đơn hàng
        /// </summary>
        /// <param name="order"></param>
        /// <param name="listOrderDetail"></param>
        /// <returns></returns>
        public SaleOrder InsertOrderDetail(SaleOrder order, List<OrderDetail> listOrderDetail)
        {
            var result = Insert(order);
            if (result != null)
            {
                order = (SaleOrder)result;
                order = GetEntityByProperty(nameof(order.ordercode), order.ordercode);
                foreach (var item in listOrderDetail)
                {
                    item.idorder = order.idorder;
                }
                bool isSuccess = _dbHelper.InsertBulk(listOrderDetail);
                return order;
            }
            else
            {
                return null;
            }
        }
    }
}
