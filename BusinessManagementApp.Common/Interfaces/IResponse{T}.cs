﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManagementApp.Common.Interfaces
{
    public interface IResponse<T> : IResponse
    {
        public T Data { get; set; }

        public List<ValidationError> ValidationErrors { get; set; }
    }
}
