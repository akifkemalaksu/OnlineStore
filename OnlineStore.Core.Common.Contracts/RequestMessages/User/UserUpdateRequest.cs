using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Core.Common.Contracts.RequestMessages
{
    public class UserUpdateRequest : UserCreateRequest
    {
        public int Id { get; set; }
    }
}
