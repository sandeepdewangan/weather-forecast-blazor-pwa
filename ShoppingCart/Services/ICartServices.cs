using ShoppingCart.Models;

namespace ShoppingCart.Services
{
    public interface ICartServices
    {
        IList<Product> Cart { get; }
        int Total { get; }
        event Action OnChange;
        void AddProduct(Product product);
        void DeleteProduct(Product product);
    }
}
