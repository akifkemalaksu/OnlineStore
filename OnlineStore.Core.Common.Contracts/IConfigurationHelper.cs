using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Core.Common.Contracts
{
    public interface IConfigurationHelper
    {
        int DefaultProductListCount { get; }
    }
}
