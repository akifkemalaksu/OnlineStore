using OnlineStore.Business.Contracts;
using OnlineStore.Core.Common.Contracts.RequestMessages;
using OnlineStore.Core.Common.Contracts.ResponseMessages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace OnlineStore.ServiceHost.API.Controllers
{
    public class UserController : ApiController
    {
        private readonly IUserEngine _userEngine;

        public UserController(IUserEngine userEngine)
        {
            _userEngine = userEngine;
        }

        public Task<UserResponse> Get(int id)
        {
            return _userEngine.GetAsync(id);
        }

        public Task<UserResponse> Post([FromBody] UserCreateRequest request)
        {
            return _userEngine.CreateAsync(request);
        }

        public Task<UserResponse> Put([FromBody] UserUpdateRequest request)
        {
            return _userEngine.UpdateAsync(request);
        }

        public Task Delete(int id)
        {
            return _userEngine.DeleteAsync(id);
        }
    }
}
