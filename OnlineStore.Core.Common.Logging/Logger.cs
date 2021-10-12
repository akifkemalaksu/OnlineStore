using OnlineStore.Core.Common.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Core.Common.Logging
{
    public class Logger : ILogger
    {
        private readonly log4net.ILog _log;

        public Logger()
        {
            log4net.Config.XmlConfigurator.Configure(
                new FileInfo(AppDomain.CurrentDomain.BaseDirectory + "log4net.config"));
            _log = log4net.LogManager.GetLogger(GetType().FullName);
        }

        public void Error(string message, Exception exception, Dictionary<string, string> additionalColumns = null)
        {
            System.Diagnostics.Contracts.Contract.Assert(!string.IsNullOrEmpty(message));
            System.Diagnostics.Contracts.Contract.Assert(exception != null);

            BindAdditionalColumnsIfNotEmpty(additionalColumns);

            _log.Error(message, exception);
        }

        public void Info(string message, Dictionary<string, string> additionalColumns = null)
        {
            System.Diagnostics.Contracts.Contract.Assert(!string.IsNullOrEmpty(message));

            BindAdditionalColumnsIfNotEmpty(additionalColumns);

            _log.Info(message);
        }

        private void BindAdditionalColumnsIfNotEmpty(Dictionary<string, string> additionalColumns)
        {
            if (additionalColumns != null && additionalColumns.Any())
            {
                foreach (var column in additionalColumns)
                {
                    log4net.ThreadContext.Properties[column.Key] = column.Value;
                }
            }
        }
    }
}
