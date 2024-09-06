
using TP5_ApiFakeStore.Models;

namespace TP5_ApiFakeStore.Service
{
    public interface IProductoService
    {
        Task<IEnumerable<Producto>> GetProductsAsync();

    }
}


