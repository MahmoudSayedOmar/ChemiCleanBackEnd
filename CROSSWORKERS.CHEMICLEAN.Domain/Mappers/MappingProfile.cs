using AutoMapper;
using CROSSWORKERS.CHEMICLEAN.Domain.Models;
using CROSSWORKERS.CHEMICLEAN.Utilities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace CROSSWORKERS.CHEMICLEAN.Domain.Mappers
{
   public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<Product, ProductDto>().ForMember(dest => dest.IsUpdatedInLastThreeDays, map => map.MapFrom((s, d) => DateTime.Now.Subtract(s.LastUpdate).Days<=3?true:false));
            ;
            CreateMap<ProductDto, Product>();


          
        }
    }

}
