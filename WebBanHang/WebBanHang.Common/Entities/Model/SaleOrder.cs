using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBanHang.Common.Attributes;

namespace WebBanHang.Common.Entities.Model
{
    public class SaleOrder
    {
        [AttributeCustomId]
        public int idorder { get; set; }

        /// <summary>
        /// mã đơn hàng
        /// </summary>
        [AttributeCustomUnique]
        [AttributeCustomDisplayName("Mã đơn hàng")]
        public string ordercode { get; set; }

        /// <summary>
        /// tên khách hàng
        /// </summary>
        public string customername { get; set; }

        /// <summary>
        /// sđt khách hàng
        /// </summary>
        public string customerphone { get; set; }

        /// <summary>
        /// email khách hàng
        /// </summary>
        public string customeremail { get; set; }

        /// <summary>
        /// ghi chú của khách
        /// </summary>
        public string customerdescription { get; set; }

        public int provinceid { get; set; }

        public string provincename { get; set; }

        public int districtid { get; set; }

        public string districtname { get; set; }

        public string wardid { get; set; }

        public string wardname { get; set; }

        /// <summary>
        /// Địa chỉ giao hàng
        /// </summary>
        public string customeraddress { get; set; }

        public int deliverprice { get; set; }

        public int totalprice { get; set; }

        /// <summary>
        /// ngày đặt hàng
        /// </summary>
        public DateTime? orderdate { get; set; }

        /// <summary>
        /// nhân viên tiếp nhận
        /// </summary>
        public string receiveemployeeid { get; set; }

        /// <summary>
        /// tên nhân viên tiếp nhận
        /// </summary>
        public string receiveemployeename { get; set; }

        /// <summary>
        /// chi nhánh
        /// </summary>
        public int branchid { get; set; }

        /// <summary>
        /// chi nhánh bán
        /// </summary>
        public string branchname { get; set; }

        /// <summary>
        /// Hình thức mua hàng
        /// </summary>
        public int ordertypeid { get; set; }

        /// <summary>
        /// Hình thức mua hàng
        /// </summary>
        public string ordertypename { get; set; }

        /// <summary>
        /// trạng thái thanh toán
        /// </summary>
        public int checkoutstatusid { get; set; }

        /// <summary>
        /// Trạng thái thanh toán
        /// </summary>
        public string checkoutstatusname { get; set; }

        /// <summary>
        /// Hình thức thanh toán
        /// </summary>
        public int checkouttypeid { get; set; }

        /// <summary>
        /// Hình thức thanh toán
        /// </summary>
        public string checkouttypename { get; set; }
    }
}


