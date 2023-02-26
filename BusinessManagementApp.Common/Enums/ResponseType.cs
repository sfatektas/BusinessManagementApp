using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManagementApp.Common.Enums
{
    public enum ResponseType
    {
        Success = 1,
        ValidationError = 2,
        NotFound = 3,
        Error = 4,
    }
}
