using OnlineStore.Business.Contracts;
using OnlineStore.Core.Common.Contracts.RequestMessages;
using OnlineStore.Core.Common.Contracts.ResponseMessages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace OnlineStore.ServiceHost.API.Controllers
{
    public class ProductController : ApiController
    {
        private readonly IProductEngine _productEngine;

        public ProductController(IProductEngine productEngine)
        {
            _productEngine = productEngine;
        }

        public Task<ProductResponse> Get(int id)
        {
            return _productEngine.GetAsync(id);
        }

        public Task<ProductResponse> Post([FromBody] ProductCreateRequest productCreateRequest)
        {
            return _productEngine.CreateAsync(productCreateRequest);
        }

        public Task<ProductResponse> Put([FromBody] ProductUpdateRequest productUpdateRequest)
        {
            return _productEngine.UpdateAsync(productUpdateRequest);
        }

        public Task Delete(int id)
        {
            return _productEngine.DeleteAsync(id);
        }

        [HttpGet]
        public Task<List<ProductResponse>> Search([FromUri] ProductSearchRequest productSearchRequest)
        {
            return _productEngine.SearchAsync(productSearchRequest);
        }
    }
}
