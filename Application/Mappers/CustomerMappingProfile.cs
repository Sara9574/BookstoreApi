using Application.Commands;
using Application.Responses;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappers
{
    public class CustomerMappingProfile : Profile
    {
        public CustomerMappingProfile()
        {
            CreateMap<Core.Entities.Customer, CustomerResponse>().ReverseMap();
            CreateMap<Core.Entities.Customer, CreateCustomerCommand>().ReverseMap();
            CreateMap<Core.Entities.Customer, UpdateCustomerCommand>().ReverseMap();
        }
    }
}
