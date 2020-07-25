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

            //El id de la clave primaria viene cero
            //CreateMap<CustomerRegions, CustomerRegionsDto>().ForMember(p => p.CustomerCountryIdDto, opt => opt.Ignore());
            //CreateMap<CustomerRegions, CustomerRegionsDto>().Include<CustomerCountries, CustomerCountriesDto>();
            //CreateMap<CustomerRegions, CustomerRegionsDto>().Include(src => src.CustomerCountriesDto);
            //CreateMap<CustomerCountries, string>().ConvertUsing(a => a.CustomerCountry);

            CreateMap<CustomerRegionsDto, CustomerRegions>();

            CreateMap<CustomerCountryRegionVM, CustomerCountryRegionDto>();
            CreateMap<CustomerCountryRegionDto, CustomerCountryRegionVM>();

        }
    }
}
