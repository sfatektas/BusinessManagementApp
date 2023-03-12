using AutoMapper;
using BusinessManagementApp.Common;
using BusinessManagementApp.Common.Enums;
using BusinessManagementApp.Common.Interfaces;
using BussinesManagementApp.Bussines.Helpers.Extension;
using BussinesManagementApp.Bussines.Interfaces;
using BussinesManagementApp.Dtos;
using BussinesManagementApp.Dtos.ReportDtos;
using BussinessManagementApp.DataAccess.Interfaces;
using BussinessManagementApp.Entities;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace BussinesManagementApp.Bussines.Services
{
    public class ReportService : IReportService
    {
        readonly IUow _uow;
        readonly IValidator<ReportQueryDto> _queryvalidator;
        readonly IMapper _mapper;
        readonly ICustomerOrderService _customerOrderService;
        readonly ISupplierOrderService _supplierOrderService;
        readonly IWarehouseProductService _warehouseProductService;

        public ReportService(IUow uow, IValidator<ReportQueryDto> queryvalidator, IMapper mapper, ICustomerOrderService customerOrderService, ISupplierOrderService supplierOrderService, IWarehouseProductService warehouseProductService)
        {
            _uow = uow;
            _queryvalidator = queryvalidator;
            _mapper = mapper;
            _customerOrderService = customerOrderService;
            _supplierOrderService = supplierOrderService;
            _warehouseProductService = warehouseProductService;
        }

        public async Task<IResponse<ReportResultModel<ReportDataForCustomer, ReportLastResultForCustomer>>> GetReportResultModelForCustomer(ReportQueryDto dto)
        {
            var result = _queryvalidator.Validate(dto);
            if (result.IsValid)
            {
                var response = await _customerOrderService.GetIncludedAll(x => x.CustomerId == dto.CustomerId &&
                x.Date >= DateTime.Now.AddMonths(-dto.Month), true); // ne kadar zaman aralığına bağlı rapor isteniyor ise o zaman aralığında dönüş yaparız.
                if (response.Data == null)
                {
                    return new Response<ReportResultModel<ReportDataForCustomer, ReportLastResultForCustomer>>(ResponseType.NotFound, "Müşteriye ait herhangi bir satış verisi bulunmamaktadır.", new());
                }
                List<CustomerViewReportModel> CustomerViewReportModelList = new List<CustomerViewReportModel>();
                //reportCustomerList = _mapper.Map<List<ReportDataForCustomer>>(response.Data);
                foreach (var item in response.Data)
                {
                    CustomerViewReportModelList.Add( //mapper nesnesi üzerinde bu nesneye formember methodu kullanarak maplemaeyi uğraştım fakat hata aldım.
                        new CustomerViewReportModel
                        {
                            CominicatePersonName = item.Customer.CominicatePersonName,
                            Date = item.Date.ToString("dddd, dd MMMM yyyy") + " " + item.Date.ToString("HH:mm"),
                            KdvPrice = item.KdvPrice,
                            OrderStatus = item.OrderStatusTypeId == (int)BusinessManagementApp.Common.Enums.OrderStatusType.PreOrder ? "Ön Sipariş" : "Tamamlandı",
                            OrderStatusTypeId = item.OrderStatusTypeId,
                            ProductName = item.Product.Name,
                            TotalPrice = item.TotalPrice,
                            UnitPrice = item.UnitPrice,
                            Amount = item.Amount
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
                var reportResultModel = new ReportResultModel<ReportDataForCustomer, ReportLastResultForCustomer>()
                {
                    ReportData = new ReportDataForCustomer() { CustomerViewReportModel = CustomerViewReportModelList },
                    ReportLastResult = reportLastResultCustomer 
                };
                return new Response<ReportResultModel<ReportDataForCustomer, ReportLastResultForCustomer>>(ResponseType.Success, reportResultModel);
            }
            return new Response<ReportResultModel<ReportDataForCustomer, ReportLastResultForCustomer>>(ResponseType.ValidationError, "", new(), result.GetValidationErrors());
        }
        public async Task<IResponse<ReportResultModel<ReportDataForProduct, ReportLastResultForProduct>>> GetReportResultModelForProduct(ReportQueryDto dto)
        {
            var result = _queryvalidator.Validate(dto);
            if (result.IsValid)
            {
                var customerOrderDatasResponse = await _customerOrderService.GetIncludedAll(x => x.ProductId == dto.ProductId
           && x.IsActive == true
           && x.Date >= DateTime.Now.AddMonths(-dto.Month), true);

                var supplierOrders = await _uow.GetRepository<SupplierOrder>().GetQueryable().Where(x => x.IsActive && x.ProductId == dto.ProductId && x.Date >= DateTime.Now.AddMonths(-dto.Month)).Include(x => x.Product).Include(x => x.MoneyType).AsNoTracking().ToListAsync();

                var WarehouseProductListResponse = await _warehouseProductService.GetIncludedAll(x => x.ProductId == dto.ProductId && x.IsActive == true);
                var warehouseproduct = WarehouseProductListResponse.Data.FirstOrDefault();

                if (customerOrderDatasResponse.Data == null && supplierOrders == null && WarehouseProductListResponse.Data == null)
                    return new Response<ReportResultModel<ReportDataForProduct, ReportLastResultForProduct>>(ResponseType.NotFound, $"İlgili Ürünün son {dto.Month} ayda hiçbir alım , satım , stok kaydı bulunmamaktadır.", new());

                List<SupplierOrderListDto> supplierOrderList = new();
                if(supplierOrders != null)
                {
                    //AutoMapper ile mapleme işlemi hata döndürdüğü için kendim mapleme işlemi yaptım.
                    foreach (var item in supplierOrders)
                    {
                        supplierOrderList.Add(new()
                        {
                            Amount = item.Amount,
                            IsActive = item.IsActive,
                            Date = item.Date,
                            DateString = item.Date.ToString("dddd, dd MMMM yyyy") + " " + item.Date.ToString("HH:mm"),
                            Id = item.Id,
                            ProductId = item.ProductId,
                            TotalPrice = item.TotalPrice,
                            UnitPrice = item.UnitPrice,
                            MoneyTypeId = item.MoneyTypeId,
                            MoneyTypeValue = item.MoneyTypeValue,
                            Product = new ProductListDto()
                            {
                                Name = item.Product.Name
                            },
                            MoneyType = new MoneyTypeListDto()
                            {
                                Defination = item.MoneyType.Name
                            },
                        });
                    }
                }

                return new Response<ReportResultModel<ReportDataForProduct, ReportLastResultForProduct>>(ResponseType.Success, new()
                {
                    ReportData = new()
                    {
                        SoldProductList = customerOrderDatasResponse.Data == null ? new() : customerOrderDatasResponse.Data,// satılan herhangi bir ürün kaydı yok ise boş dönsün excel tarafında ele alınsın.
                        TakenProductList = supplierOrderList,
                        WarehouseProduct = warehouseproduct == null ? new() : warehouseproduct
                    },
                    ReportLastResult = new()
                    {
                        Ciro = supplierOrders.Sum(x => x.TotalPrice),
                        SellAmount = customerOrderDatasResponse.Data.Sum(x => x.Amount),
                        TakenAmount = supplierOrders.Sum(x => x.Amount),
                        WarehouseAmount = warehouseproduct.Amount,
                        TotalPaidPrice = supplierOrders.Sum(x => x.TotalPrice),
                        TotalSellPrice = customerOrderDatasResponse.Data.Sum(x => x.TotalPrice)
                    }
                });;
            }
            return new Response<ReportResultModel<ReportDataForProduct, ReportLastResultForProduct>>(ResponseType.ValidationError, "", new(), result.GetValidationErrors());
               
        }
    }
}
