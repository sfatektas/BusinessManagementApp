using BusinessManagementApp.Common.Interfaces;
using BussinesManagementApp.Dtos;
using BussinessManagementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesManagementApp.Bussines.Interfaces
{
    public interface ICustomerOrderService : IService<CustomerOrderCreateDto,CustomerOrderUpdateDto,CustomerOrderListDto,CustomerOrder>,
        IQueryable<CustomerOrderListDto,CustomerOrder>
    {
        Task<IResponse<CustomerOrderCreateDto>> AddCustomerOrderAndUpdateWarehouse(CustomerOrderCreateDto dto);

        Task<IResponse> ComplatePreOrderAndUpdateWarehouse(int CustomerOrderId);

        Task<IResponse<List<CustomerOrderListDto>>> GetIncludeAllAndLastTenRow();

    }
}
