using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanHang.Common.Attributes;

namespace WebBanHang.Common.Entities.Model
{
    public class Product:ProductNotFile
    {
        /// <summary>
        /// Ảnh sản phẩm
        /// </summary>
        [AttributeCustomNotMap]
        public IFormFile mainImage { get; set; }
    }
}
