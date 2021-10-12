using AutoMapper;
using OnlineStore.Core.Common.Contracts.RequestMessages;
using OnlineStore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Core.Mappings
{
    public class RequestMessagesToEntities
    {
        public static void Map(IMapperConfigurationExpression mapperConfiguration)
        {
            mapperConfiguration.CreateMap<UserCreateRequest, User>();
            mapperConfiguration.CreateMap<UserUpdateRequest, User>();
            mapperConfiguration.CreateMap<CategoryCreateRequest, Category>();
            mapperConfiguration.CreateMap<CategoryUpdateRequest, Category>();
            mapperConfiguration.CreateMap<ProductCreateRequest, Product>();
            mapperConfiguration.CreateMap<ProductUpdateRequest, Product>();
        }
    }
}
