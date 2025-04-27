using ProductApi.Models;

namespace ProductApi.Services
{
    public class ProductService : IProductService
    {
        private readonly List<Product> _products = new List<Product>();

        public void CreateProduct(Product product)
        {
             _products.Add(product);
        }

        public IEnumerable<Product> GetAllProducts()
        {
       
            return _products;
        }

        public Product GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

       

    }
}
