using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ManufacturaMVC.Models;
using ManufacturaMVC.Dto;
using ManufacturaMVC.ViewModels;


namespace ManufacturaMVC.Dto
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<CustomerCountries, CustomerCountriesDto>();
            CreateMap<CustomerCountriesDto, CustomerCountries>();

            CreateMap<CustomerRegions, CustomerCountryRegionVM>()
                .ForMember(x => x.CustomerCountryName, opt => opt.MapFrom(z => z.CustomerCountry.CustomerCountryName));
            CreateMap<CustomerCountryRegionVM, CustomerRegions>()
                .ForMember(x => x.CustomerCountry, opt => opt.Ignore());
        }

    }
}
