using OnlineStore.Core.Common.Contracts;
using OnlineStore.Core.Common.Contracts.RequestMessages;
using OnlineStore.Core.Common.Contracts.ResponseMessages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Business.Contracts
{
    public interface ICategoryEngine : IBusinessEngine
    {
        Task<CategoryResponse> GetAsync(int id);
        Task<CategoryResponse> CreateAsync(CategoryCreateRequest categoryCreateRequest);
        Task<CategoryResponse> UpdateAsync(CategoryUpdateRequest categoryUpdateRequest);
        Task DeleteAsync(int id);
        Task<List<CategoryResponse>> GetAllAsync(int skip, int take);
    }
}
