using Gather.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanHang.Common.AzureStorage;
using WebBanHang.Common.Entities.Model;
using WebBanHang.Common.Interfaces.Base;
using WebBanHang.Common.Interfaces.BL;
using WebBanHang.Common.Interfaces.DL;
using WebBanHang.Common.Services;
using static WebBanHang.Common.Enumeration.Enumeration;

namespace WebBanHang.BL.BL
{
    public class ProductBL : BaseBL<Product>, IProductBL
    {
        IProductDL _productDL;
        IAzureStorageBL _azureStorageBL;

        public ProductBL(IBaseDL<Product> baseDL, IProductDL productDL, IAzureStorageBL azureStorageBL) : base(baseDL)
        {
            _productDL = productDL;
            _azureStorageBL = azureStorageBL;
        }

        public async Task<ServiceResult> InsertProduct(Product product)
        {
            ServiceResult serviceResult = new ServiceResult();
            ProductNotFile productnotfile = new ProductNotFile();
            serviceResult = Insert(product);
            Product productAfterSave = new Product();
            if (!serviceResult.Success)
            {
                return serviceResult;
            }
            else
            {
                productnotfile.productcode = product.productcode;
                productnotfile.productname = product.productname;
            }
            ServiceResult serviceResult2 = await _azureStorageBL.UploadBlobFileAsync(product.mainImage);
            if (serviceResult2.Success && serviceResult2 != null)
            {
                productnotfile.image  = serviceResult2.Data?.ToString();
                // save image link to database
                _productDL.saveImageLinkProduct(product.productcode, productnotfile.image);
            }
            serviceResult.Data = productnotfile;
            return serviceResult;
        }

        /// <summary>
        /// Xử lý sau khi insert
        /// </summary>
        /// <param name="entity"></param>
        protected override async void AfterSave (EntityState entityState, Product entity)
        {
            //if (entityState == EntityState.Add)
            //{
            //    await _azureStorageBL.UploadBlobFileAsync(entity.mainImage);
            //}
        }

    }
}
