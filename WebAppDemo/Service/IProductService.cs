using WebAppDemo.Models;

namespace WebAppDemo.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}