using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ManufacturaMVC.Models;

namespace ManufacturaMVC.ViewModels
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<CustomerCountries, CustomerCountriesDto>();
            CreateMap<CustomerCountriesDto, CustomerCountries>();

            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<CustomerCountriesDto, CustomerCountries>()
                    .ReverseMap()
                        .ForMember(CustomerCountriesDto => CustomerCountriesDto.CustomerCountry, expression => 
                                                                        expression.MapFrom(model => model.CustomerCountry));
                        
            });
        }
    }
}
