using AutoMapper;
using NAPATask.Demo.Models;
using NAPATask.Demo.ViewModel.Products;

namespace NAPATask.Demo.Mappers
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Product, ProductCreateViewModel>().ReverseMap();
            CreateMap<Product, ProductUpdateViewModel>().ReverseMap();

        }
    }
}
