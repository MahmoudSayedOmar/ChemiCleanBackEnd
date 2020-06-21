using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CROSSWORKERS.CHEMICLEAN.Domain.Models;
using CROSSWORKERS.CHEMICLEAN.Domain.Services;
using CROSSWORKERS.CHEMICLEAN.Utilities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CROSSWORKERS.CHEMICLEAN.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(ProductService ProductService , IMapper mapper)
        {
            _productService = ProductService;
            _mapper = mapper;

        }
        // GET: api/Product
        [HttpGet]
        [Route("GetSome/{skip:int}/{take:int}")]

        public async Task<IEnumerable<ProductDto>> GetSome(int skip , int take)
        
        {


            var products = await _productService.GetSome(skip,take);

            return _mapper.Map<List<ProductDto>>(products); 
        }

        

       
    }
}
