using OnlineStore.Business.Contracts;
using OnlineStore.Core.Common.Contracts.RequestMessages;
using OnlineStore.Core.Common.Contracts.ResponseMessages;
using OnlineStore.Data.Contracts;
using OnlineStore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Business
{
    public class ProductEngine : BusinessEngineBase, IProductEngine
    {
        private readonly IProductRepository _productRepository;

        public ProductEngine(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        #region IProductEngine Members

        public Task<ProductResponse> CreateAsync(ProductCreateRequest productCreateRequest)
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {
                var product = Mapper.Map<Product>(productCreateRequest);
                _productRepository.Add(product);
                await _productRepository.SaveChangesAsync();
                return Mapper.Map<ProductResponse>(product);
            });
        }

        public Task DeleteAsync(int id)
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {
                await _productRepository.Delete(id);
                await _productRepository.SaveChangesAsync();
            });
        }

        public Task<ProductResponse> GetAsync(int id)
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {
                var product = await _productRepository.GetAsync(id);
                return Mapper.Map<ProductResponse>(product);
            });
        }

        public Task<List<ProductResponse>> SearchAsync(ProductSearchRequest productSearchRequest)
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {
                if (productSearchRequest.Take == 0)
                {
                    productSearchRequest.Take = ConfigurationHelper.DefaultProductListCount;
                }

                var searchQuery = _productRepository.GetAll(productSearchRequest.Skip, productSearchRequest.Take);

                if (!string.IsNullOrEmpty(productSearchRequest.ProductName))
                {
                    searchQuery = searchQuery.Where(x => x.Name.Contains(productSearchRequest.ProductName));
                }

                if (productSearchRequest.MinPrice.HasValue)
                {
                    searchQuery = searchQuery.Where(x => x.Price >= productSearchRequest.MinPrice.Value);
                }

                if (productSearchRequest.MaxPrice.HasValue)
                {
                    searchQuery = searchQuery.Where(x => x.Price <= productSearchRequest.MaxPrice);
                }

                return Mapper.Map<List<ProductResponse>>(await searchQuery.ToListAsync());
            });
        }

        public Task<ProductResponse> UpdateAsync(ProductUpdateRequest productUpdateRequest)
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {
                var product = Mapper.Map<Product>(productUpdateRequest);
                _productRepository.Update(product);
                await _productRepository.SaveChangesAsync();
                return Mapper.Map<ProductResponse>(product);
            });
        }

        #endregion
    }
}
