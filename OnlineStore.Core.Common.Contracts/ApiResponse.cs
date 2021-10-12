using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Core.Common.Contracts
{
    [DataContract]
    public class ApiResponse<T>
    {
        [DataMember]
        public string Version
        {
            get
            {
                return "1.0";
            }
        }
        [DataMember]
        public int StatusCode { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string ErrorMessage { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public T Result { get; set; }

        public ApiResponse()
        {

        }

        public ApiResponse(HttpStatusCode statusCode, string errorMessage, T result)
        {
            StatusCode = (int)statusCode;
            ErrorMessage = errorMessage;
            Result = result;
        }
    }
}
