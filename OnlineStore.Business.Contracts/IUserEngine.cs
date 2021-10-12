using OnlineStore.Core.Common.Contracts;
using OnlineStore.Core.Common.Contracts.RequestMessages;
using OnlineStore.Core.Common.Contracts.ResponseMessages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Business.Contracts
{
    public interface IUserEngine : IBusinessEngine
    {
        Task<UserResponse> GetAsync(int id);
        Task<UserResponse> CreateAsync(UserCreateRequest request);
        Task<UserResponse> UpdateAsync(UserUpdateRequest request);
        Task DeleteAsync(int id);
    }
}
