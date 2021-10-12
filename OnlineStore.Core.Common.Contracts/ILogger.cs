using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Core.Common.Contracts
{
    public interface ILogger
    {
        void Info(string message, Dictionary<string, string> additionalColumns = null);
        void Error(string message, Exception exception, Dictionary<string, string> additionalColumns = null);
    }
}
