using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace WebBanHang.Common.Enumeration
{
    public class Enumeration
    {
        public enum EntityState
        {
            Add = 1,
            Edit = 2,
            Delete = 3
        }

        public enum Operator
        {
            [Display(Name = "EQUAL")]
            EQUAL = 1,

            [Display(Name = "LIKE")]
            LIKE = 2
        }

        public enum OrderByType 
        { 
            ASC = 1,
            DESC = 2
        }

        public enum AccountStatus
        {
            [Display(Name = "Chưa kích hoạt")]
            NotActive = 1,

            [Display(Name = "Đã kích hoạt")]
            Active = 2,
        }

        public enum ProductSortOrder
        {
            [Display(Name = "Mới nhất")]
            Newest = 1,

            [Display(Name = "Giá thấp đến cao")]
            PriceAsc = 2,

            [Display(Name = "Giá cao xuống thấp")]
            PriceDes = 3
        }
    }
}
