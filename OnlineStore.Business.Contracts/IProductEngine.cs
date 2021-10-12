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
    public interface IProductEngine : IBusinessEngine
    {
        Task<ProductResponse> GetAsync(int id);
        Task<ProductResponse> CreateAsync(ProductCreateRequest productCreateRequest);
        Task<ProductResponse> UpdateAsync(ProductUpdateRequest productUpdateRequest);
        Task DeleteAsync(int id);
        Task<List<ProductResponse>> SearchAsync(ProductSearchRequest productSearchRequest);
    }
}
