using AutoMapper;
using OnlineStore.Core.Common.Contracts.ResponseMessages;
using OnlineStore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Core.Mappings
{
    public class EntitiesToResponseMessages
    {
        public static void Map(IMapperConfigurationExpression mapperConfiguration)
        {
            //TODO mappingler tanımlanacak
            mapperConfiguration.CreateMap<User, UserResponse>();
            mapperConfiguration.CreateMap<Category, CategoryResponse>();
            mapperConfiguration.CreateMap<Product, ProductResponse>();
        }
    }
}
