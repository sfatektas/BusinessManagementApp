using AutoMapper;
using BusinessManagementApp.Common;
using BusinessManagementApp.Common.Enums;
using BusinessManagementApp.Common.Interfaces;
using BussinesManagementApp.Bussines.Helpers.Extension;
using BussinesManagementApp.Bussines.Interfaces;
using BussinesManagementApp.Dtos.ReportDtos;
using BussinessManagementApp.DataAccess.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesManagementApp.Bussines.Services
{
    public class ReportService : IReportService
    {
        readonly IUow _uow;
        readonly IValidator<ReportQueryDto> _queryvalidator;
        readonly IMapper _mapper;
        readonly ICustomerOrderService _customerOrderService;

        public ReportService(IUow uow, IValidator<ReportQueryDto> queryvalidator, IMapper mapper, ICustomerOrderService customerOrderService)
        {
            _uow = uow;
            _queryvalidator = queryvalidator;
            _mapper = mapper;
            _customerOrderService = customerOrderService;
        }

        public async Task<IResponse<ReportResultModel<ReportDataForCustomer, ReportLastResultForCustomer>>> GetReportResultModelForCustomer(ReportQueryDto dto)
        {
            var result = _queryvalidator.Validate(dto);
            if (result.IsValid)
            {
                var response = await _customerOrderService.GetIncludedAll(x => x.CustomerId == dto.CustomerId &&
                x.Date >= DateTime.Now.AddMonths(-dto.Month),true); // ne kadar zaman aralığına bağlı rapor isteniyor ise o zaman aralığında dönüş yaparız.
                if (response.Data == null)
                {
                    return new Response<ReportResultModel<ReportDataForCustomer, ReportLastResultForCustomer>>(ResponseType.NotFound, "Müşteriye ait herhangi bir satış verisi bulunmamaktadır.", new());
                }
                List<ReportDataForCustomer> reportCustomerList = new List<ReportDataForCustomer>();
                //reportCustomerList = _mapper.Map<List<ReportDataForCustomer>>(response.Data);
                foreach (var item in response.Data)
                {
                    reportCustomerList.Add( //mapper nesnesi üzerinde bu nesneye formember methodu kullanarak maplemaeyi uğraştım fakat hata aldım.
                        new ReportDataForCustomer
                        {
                            CominicatePersonName = item.Customer.CominicatePersonName ,
                            Date= item.Date,
                            KdvPrice= item.KdvPrice,
                            OrderStatus = item.OrderStatusTypeId ==(int)OrderStatusType.PreOrder ? "Ön Sipariş":"Tamamlandı",
                            OrderStatusTypeId= item.OrderStatusTypeId,
                            ProductName = item.Product.Name,
                            TotalPrice= item.TotalPrice,
                            UnitPrice= item.UnitPrice,
                        }
                    );
                }
                var reportLastResultCustomer = new ReportLastResultForCustomer() // Sonuç Verisi 
                {
                    DifferentProductCount = response.Data.Select(x => x.ProductId).Distinct().Count(),
                    OrderCount = response.Data.Count(),
                    TotalOrderPrice = response.Data.Sum(x => x.TotalPrice),
                    TotalProductCount = response.Data.Sum(x => x.Amount)
                };
                var reportResultModel = new ReportResultModel<ReportDataForCustomer, ReportLastResultForCustomer>();
                reportResultModel.ReportData = reportCustomerList;
                reportResultModel.ReportLastResult = reportLastResultCustomer;
                return new Response<ReportResultModel<ReportDataForCustomer, ReportLastResultForCustomer>>(ResponseType.Success, reportResultModel);
            }
            return new Response<ReportResultModel<ReportDataForCustomer, ReportLastResultForCustomer>>(ResponseType.ValidationError,"",new(),result.GetValidationErrors());
        }
    }
}
