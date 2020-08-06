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

            //El id de la clave primaria viene cero
            //CreateMap<CustomerRegions, CustomerRegionsDto>().ForMember(p => p.CustomerCountryIdDto, opt => opt.Ignore());
            //CreateMap<CustomerRegions, CustomerRegionsDto>().Include<CustomerCountries, CustomerCountriesDto>();
            //CreateMap<CustomerRegions, CustomerRegionsDto>().Include(src => src.CustomerCountriesDto);
            //CreateMap<CustomerCountries, string>().ConvertUsing(a => a.CustomerCountry);

            CreateMap<CustomerRegionsDto, CustomerRegions>();
            CreateMap<CustomerRegions, CustomerRegionsDto>();

            CreateMap<CustomerCountryRegionVM, CustomerRegions>();
            CreateMap<CustomerRegions, CustomerCountryRegionVM>(); 
            //CreateMap<CustomerRegions, CustomerCountryRegionVM>().ForMember(dest => dest.CustomerCountryName, opt => opt.MapFrom(src => src.CustomerCountry));

            /*var configuration = new MapperConfiguration(cfg => cfg.CreateMap<CustomerCountries, CustomerCountryRegionVM>()
                                    .ForMember(dto => dto.CustomerRegion, conf => conf.MapFrom(ol => ol.CustomerRegions))); //I can´t see the next field on the intellicense */

            
        }

        /*public List<CustomerCountryRegionVM> GetLinesForOrder(int orderId)
        {
            using (var context = new orderEntities())
            {
                return context.OrderLines.Where(ol => ol.OrderId == orderId)
                         .ProjectTo<CustomerCountryRegionVM>(configuration).ToList();
            }
        }*/

    }
}
