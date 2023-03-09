using BusinessManagementApp.Common.Interfaces;
using BussinesManagementApp.Dtos;
using BussinesManagementApp.Dtos.Interfaces;
using BussinessManagementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BussinesManagementApp.Bussines.Interfaces
{
    public interface IQueryable<ListDto,T> where ListDto : class , IListDto
        where T : BaseEntity
    {
        Task<IResponse<List<ListDto>>> GetIncludedAll(bool allPropertyInclude = false);
        Task<IResponse<ListDto>> GetIncludedById(int id , bool allPropertyInclude = false);
        Task<IResponse<List<ListDto>>> GetIncludedAll(Expression<Func<T, bool>> filter, bool allPropertyInclude = false);

    }
}
