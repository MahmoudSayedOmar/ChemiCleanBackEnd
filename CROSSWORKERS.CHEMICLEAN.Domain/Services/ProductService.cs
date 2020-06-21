using CROSSWORKERS.CHEMICLEAN.Domain.Models;
using CROSSWORKERS.CHEMICLEAN.Utilities.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CROSSWORKERS.CHEMICLEAN.Domain.Services
{
  
     public class ProductService
    {
        private readonly IRepository<Product> _productRepository;
        public ProductService(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Product>  GetProduct(int Id)
        {
            if (Id < 1)
                throw new ArgumentException();

            return await _productRepository.Get(Id);
        }
         async Task<Product> Modify(Product product)
        {
            return await _productRepository.Update(product);
        }
        public async Task<List<Product>> GetSome(int skip , int take)
        {

            var products = await _productRepository.GetAll();
           products= products.Skip(skip).Take(take).ToList();
            products.ForEach(async product =>
            {
                if (SafetyDataSheetsManager.UpdateSafetyDataSheet(product.Url, product.UserName, product.Password))
                {

                    product.IsAvailable = true;
                    product.LastUpdate = DateTime.Now;
                    product.SafetyDataSheetPath = product.Url.Split('/').Last();
                    await Modify(product);
                }
            });
            return products;
        }
    }
}
