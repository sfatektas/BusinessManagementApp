using BussinesManagementApp.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesManagementApp.Dtos.ReportDtos
{
    public class ReportResultModel<ReportDataModel,ReportLastResultModel> where ReportDataModel : IReportData 
        where ReportLastResultModel: IReportLastResult
    {
        public List<ReportDataModel> ReportData { get; set; }

        public ReportLastResultModel ReportLastResult { get; set; }

    }
}
