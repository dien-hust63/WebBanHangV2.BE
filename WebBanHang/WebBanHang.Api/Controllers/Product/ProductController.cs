using Azure.Storage.Blobs;
using Gather.ApplicationCore.Entities;
using Gather.ApplicationCore.Entities.Param;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebBanHang.Common.AzureStorage;
using WebBanHang.Common.Entities.Model;
using WebBanHang.Common.Interfaces.Base;
using WebBanHang.Common.Interfaces.BL;

namespace WebBanHang.Api.Controllers
{
    public class ProductController : BaseEntityController<Product>
    {
        IBaseBL<Product> _baseBL;
        IProductBL _productBL;
        IAzureStorageBL _azureStorageBL;
        public ProductController(IBaseBL<Product> baseBL, IProductBL productBL, IAzureStorageBL azureStorageBL) : base(baseBL)
        {
            _baseBL = baseBL;
            _productBL = productBL;
            _azureStorageBL = azureStorageBL;
        }

        /// <summary>
        /// Thêm mới
        /// </summary>
        /// <param name="entity">Dữ liệu được thêm</param>
        /// <returns></returns>
        /// CreatedBy: nvdien(17/8/2021)
        /// ModifiedBy: ndien(17/8/2021)
        [HttpPost("insertProduct")]
        public Task<ServiceResult> Insert([FromForm] Product product)
        {
            //Trả về kết quả cho client
            return _productBL.InsertProduct(product);

        }

        [HttpPost("uploadImage")]
        public async Task<ServiceResult> UploadImage([FromForm] Product product)
        {
            ServiceResult serviceResult = new ServiceResult();
            serviceResult = await _productBL.InsertProduct(product);
            return serviceResult;
        }

    }
}
