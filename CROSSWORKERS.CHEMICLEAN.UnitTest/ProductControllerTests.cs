using AutoMapper;
using CROSSWORKERS.CHEMICLEAN.Data;
using CROSSWORKERS.CHEMICLEAN.Domain;
using CROSSWORKERS.CHEMICLEAN.Domain.Mappers;
using CROSSWORKERS.CHEMICLEAN.Domain.Models;
using CROSSWORKERS.CHEMICLEAN.Domain.Services;
using CROSSWORKERS.CHEMICLEAN.Service.Controllers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CROSSWORKERS.CHEMICLEAN.UnitTest
{
    public class ProductControllerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ProductController_GetSome_NoParameters()
        {
            ChemiCleanContext chemiCleanContext = new ChemiCleanContext();
            IRepository<Product> repository = new ChemiCleanRepository<Product>(chemiCleanContext);
            ProductService productService = new ProductService(repository);
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            ProductController productController = new ProductController(productService, mapper);

           var result=  productController.GetSome(0, 0);

            Assert.AreEqual(result.Result.ToList().Count,0);
        }

        [Test]
        public void ProductController_GetSome_GetOnlyFirstTen()
        {
            ChemiCleanContext chemiCleanContext = new ChemiCleanContext();
            IRepository<Product> repository = new ChemiCleanRepository<Product>(chemiCleanContext);
            ProductService productService = new ProductService(repository);
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            ProductController productController = new ProductController(productService, mapper);

            var result = productController.GetSome(0, 10);

            Assert.AreEqual(result.Result.ToList().Count, 10);
        }

    }
}
