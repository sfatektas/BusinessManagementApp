using BusinessManagementApp.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesManagementApp.Dtos.ReportDtos
{
    public class ReportQueryDto
    {
        public int CustomerId { get; set; }

        public int ProductId { get; set; }

        public int ReportTypeId { get; set; }

        public int Month { get; set; }
        public int TimeRangeTypeId { get; set; }
    }
}
