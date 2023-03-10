using BusinessManagementApp.Common.Interfaces;
using BussinesManagementApp.Dtos;
using BussinesManagementApp.Dtos.ReportDtos;

namespace BussinesManagementApp.Bussines.Interfaces
{
    public interface IReportService
    {
        public Task<IResponse<ReportResultModel<ReportDataForCustomer,ReportLastResultForCustomer>>> GetReportResultModelForCustomer(ReportQueryDto dto);
    }
}
