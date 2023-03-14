using BusinessManagementApp.Common.Enums;
using BusinessManagementApp.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BusinessManagementApp.Common
{
    public class Response : IResponse
    {
        public Response(ResponseType responseType)
        {
            ResponseType = responseType;
        }

        public Response(ResponseType responseType, string message)
        {
            ResponseType = responseType;
            Message = message;
        }

        public ResponseType ResponseType { get; set; }
        public string Message { get; set; }
    }

    public class ValidationError
    {
        public string ErrorCode { get; set; }

        public string ErrorMessage { get; set; }
    }
}
