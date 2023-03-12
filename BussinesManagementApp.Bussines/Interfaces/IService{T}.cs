using BusinessManagementApp.Common.Interfaces;
using BussinessManagementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BussinesManagementApp.Dtos.Interfaces;

namespace BussinesManagementApp.Bussines.Interfaces
{
    public interface IService<CreateDto, UpdateDto, ListDto, T> where
           CreateDto : class, ICreateDto where
           UpdateDto : class, IUpdateDto where
           ListDto : class, IListDto where
           T : BaseEntity
    {

        Task<IResponse<CreateDto>> CreateAsync(CreateDto dto);

        Task<IResponse<List<ListDto>>> GetAllAsync();

        Task<IResponse<List<ListDto>>> GetAllAsync(Expression<Func<T, bool>> filter);

        Task<IResponse<ListDto>> GetByIdAsync(int id);

        Task<IResponse<ListDto>> GetByFilterAsync(Expression<Func<T, bool>> filter);

        Task<IResponse> Remove(ListDto dto);

        Task<IResponse<UpdateDto>> UpdateAsync(UpdateDto dto);

    }
}
