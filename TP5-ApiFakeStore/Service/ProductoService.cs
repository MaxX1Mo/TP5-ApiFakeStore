﻿
using TP5_ApiFakeStore.Models;
using System.Net.Http.Headers;
using System.Text.Json;
using TP5_ApiFakeStore.Utils;
using System.Net.Http.Json;

namespace TP5_ApiFakeStore.Service
{
    public class ProductoService : IProductoService
    {
        HttpClient client;

        private static JsonSerializerOptions options = new()
        {
            PropertyNameCaseInsensitive = true
        };

        public ProductoService()
        {
            client = new HttpClient();

            client.BaseAddress = new Uri(Constants.ApiDataServer);
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<IEnumerable<Producto>> GetProductsAsync()
        {
            var response = await client.GetAsync(Constants.ProductsEndpoint);

            if (response.IsSuccessStatusCode)
                return await response.Content.ReadFromJsonAsync<IEnumerable<Producto>>(options);

            return default;
        }

    }
}
