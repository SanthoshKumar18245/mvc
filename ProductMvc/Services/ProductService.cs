using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using ProductMvc.Models;

namespace ProductMvc.Services
{
    public class ProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<Product>>("http://localhost:5105/api/products");
        }

        public async Task<Product> GetProductAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<Product>($"http://localhost:5105/api/products/{id}");
        }

        public async Task CreateProductAsync(Product product)
        {
            await _httpClient.PostAsJsonAsync("http://localhost:5105/api/products", product);
        }

        public async Task UpdateProductAsync(Product product)
        {
            await _httpClient.PutAsJsonAsync($"http://localhost:5105/api/products/{product.Id}", product);
        }

        public async Task DeleteProductAsync(int id)
        {
            await _httpClient.DeleteAsync($"http://localhost:5105/api/products/{id}");
        }
    }
}
