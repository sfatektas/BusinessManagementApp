using BusinessManagementApp.Common.Interfaces;
using BussinesManagementApp.Dtos;
using BussinesManagementApp.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesManagementApp.Bussines.Interfaces
{
    public interface IQueryable<ListDto> where ListDto : class , IListDto
    {
        Task<IResponse<List<ListDto>>> GetIncludedAll(bool allPropertyInclude = false);
        Task<IResponse<ListDto>> GetIncludedById(int id , bool allPropertyInclude = false);
    }
}
