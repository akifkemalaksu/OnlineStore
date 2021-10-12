using OnlineStore.Business.Contracts;
using OnlineStore.Core.Common.Contracts;
using OnlineStore.Core.Common.Contracts.RequestMessages;
using OnlineStore.Core.Common.Contracts.ResponseMessages;
using OnlineStore.Data.Contracts;
using OnlineStore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Business
{
    public class UserEngine : BusinessEngineBase, IUserEngine
    {
        private readonly IUserRepository _userRepository;

        public UserEngine(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<UserResponse> CreateAsync(UserCreateRequest request)
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {
                var user = Mapper.Map<User>(request);
                _userRepository.Add(user);
                await _userRepository.SaveChangesAsync();
                return Mapper.Map<UserResponse>(user);
            });
        }

        public Task DeleteAsync(int id)
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {
                await _userRepository.Delete(id);
                await _userRepository.SaveChangesAsync();
            });
        }

        public Task<UserResponse> GetAsync(int id)
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
           {
               var user = await _userRepository.GetAsync(id);
               return Mapper.Map<UserResponse>(user);
           });
        }

        public Task<UserResponse> UpdateAsync(UserUpdateRequest request)
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {
                var user = Mapper.Map<User>(request);
                _userRepository.Update(user);
                await _userRepository.SaveChangesAsync();
                return Mapper.Map<UserResponse>(user);
            });
        }
    }
}
