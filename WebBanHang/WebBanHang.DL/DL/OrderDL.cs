using Dapper;
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

        public SaleOrder GetLastestOrder()
        {
            string sql = "select s.* from saleorder s order by s.idsaleorder desc";
            DynamicParameters param = new DynamicParameters();
            SaleOrder order = _dbHelper.QueryFirstOrDefault<SaleOrder>(sql, param);
            return order;
        }

        /// <summary>
        /// Lấy chi tiêt đơn hàng
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        public object getOrderDetail(int entityId)
        {
            SaleOrder order = GetEntityById(entityId);
            string sql = "select pd.* from orderdetail pd inner join saleorder p on pd.idsaleorder  = p.idsaleorder and p.idsaleorder = @idsaleorder";
            DynamicParameters param = new DynamicParameters();
            param.Add("@idsaleorder", entityId);
            List<OrderDetail> listOrderDetail = _dbHelper.Query<OrderDetail>(sql, param);
            return new
            {
                SaleOrder = order,
                OrderDetail = listOrderDetail
            };
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
                if(order != null)
                {
                    foreach (var item in listOrderDetail)
                    {
                        item.idsaleorder = order.idsaleorder;
                    }
                    bool isSuccess = _dbHelper.InsertBulk(listOrderDetail);

                }
                return order;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Sửa đơn hàng
        /// </summary>
        /// <param name="product"></param>
        /// <param name="listProductDetail"></param>
        /// <returns></returns>
        public SaleOrder UpdateOrderDetail(SaleOrder product, List<OrderDetail> listOrderDetail)
        {
            var result = Update(product, product.idsaleorder);
            bool isSuccess = _dbHelper.UpdateBulk(listOrderDetail);
            if (isSuccess)
            {
                return product;
            }
            return null;
        }

    }
}
