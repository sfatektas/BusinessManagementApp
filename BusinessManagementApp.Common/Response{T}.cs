using BusinessManagementApp.Common.Enums;
using BusinessManagementApp.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManagementApp.Common
{
    public class Response<T> : Response, IResponse<T>
    {
        public Response(ResponseType responseType , T data) : base(responseType)
        {
            Data = data;
        }

        public Response(ResponseType responseType, string message, T data, List<ValidationError> validationErrors):base(responseType,message)
        {
            Data = data;
            ValidationErrors = validationErrors;
        }

        public Response(ResponseType responseType, string message , T data) : base(responseType, message)
        {
            Data = data;
        }

        public T Data { get; set; }
        public List<ValidationError> ValidationErrors { get; set; }
    }
}
