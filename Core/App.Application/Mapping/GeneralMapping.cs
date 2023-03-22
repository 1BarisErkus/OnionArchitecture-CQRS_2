using App.Application.Features.Queries.GetAllProduct;
using App.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping() 
        {
            CreateMap<List<Product>, List<GetAllProductQueryResponse>>().ReverseMap();
        }
    }
}
