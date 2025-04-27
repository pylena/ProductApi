using ProductApi.Models;

namespace ProductApi.Services
{
    public interface IProductService
    {
        // get all products
        IEnumerable<Product> GetAllProducts();
        // get product by id
        Product  GetProductById(int id);
        // create product
        void  CreateProduct(Product product);
    }
}
