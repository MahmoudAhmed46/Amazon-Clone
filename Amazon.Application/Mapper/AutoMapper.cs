using Amazon.Domain;
using Amazon.DTO;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Application.Mapper
{
    public class AutoMapper:Profile
    {
        public AutoMapper()
        {
            CreateMap<Category, SubCategoryDTO>().ReverseMap();
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Category,arCategoryDTO>().ReverseMap();
            CreateMap<Category, arsubcategory>().ReverseMap();
            CreateMap<Product, ShowProductDTO>().ReverseMap();
            CreateMap<Product, ArShowproduct>().ReverseMap();
            CreateMap<ApplicationUser,UserRegisterDTO>().ReverseMap();
            CreateMap<ApplicationUser,UserLoginDTO>().ReverseMap();
            CreateMap<OrderItem, OrderItemShow>().ReverseMap();
        }
    }
}
