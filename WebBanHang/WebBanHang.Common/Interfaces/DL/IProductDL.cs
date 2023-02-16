using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanHang.Common.Entities.Model;
using WebBanHang.Common.Interfaces.Base;

namespace WebBanHang.Common.Interfaces.DL
{
    public interface IProductDL : IBaseDL<Product>
    {
        public bool saveImageLinkProduct(string productcode, string imageLink);

        /// <summary>
        /// Thêm mới product
        /// </summary>
        /// <param name="product"></param>
        /// <param name="listProductDetail"></param>
        /// <returns></returns>
        public Product InsertProductDetail(Product product, List<ProductDetail> listProductDetail);
    }
}
