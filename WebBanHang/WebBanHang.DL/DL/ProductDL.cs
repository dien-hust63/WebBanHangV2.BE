using Dapper;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanHang.Common.DBHelper;
using WebBanHang.Common.Entities.Model;
using WebBanHang.Common.Interfaces.DL;
using WebBanHang.Common.ServiceCollection;
using WebBanHang.DL.BaseDL;
using static Gather.ApplicationCore.Constant.RoleProject;

namespace WebBanHang.DL.DL
{
    public class ProductDL : BaseDL<Product>, IProductDL
    {
        public ProductDL(IConfiguration configuration, IDBHelper dbHelper) : base(configuration, dbHelper)
        { 
        }

        /// <summary>
        /// Thêm mới hàng hóa
        /// </summary>
        /// <param name="product"></param>
        /// <param name="listProductDetail"></param>
        /// <returns></returns>
        public Product InsertProductDetail(Product product, List<ProductDetail> listProductDetail)
        {
            var result = Insert(product);
            if (result != null)
            {
                product = (Product)result;
                product = GetEntityByProperty(nameof(product.productcode), product.productcode);
                bool isSuccess = _dbHelper.InsertBulk(listProductDetail);
                return product;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Luwu linh anh
        /// </summary>
        /// <param name="id"></param>
        /// <param name="imageLink"></param>
        /// <returns></returns>
        public bool saveImageLinkProduct(string productcode, string imageLink)
        {
            string sql = "update product set image = @imagelink where productcode = @productcode";
            DynamicParameters dynamicParam = new DynamicParameters();
            dynamicParam.Add("@imagelink", imageLink);
            dynamicParam.Add("@productcode", productcode);
            return _dbHelper.QueryFirstOrDefault<int>(sql, dynamicParam, System.Data.CommandType.Text) > 0;
        }


    }
}
