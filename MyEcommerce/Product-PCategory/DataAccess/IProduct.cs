using Product_PCategory.Models;

namespace Product_PCategory.DataAccess
{
    public interface IProduct
    {
        public List<Product> getAllProducts();

        public string AddNewProduct(Product product);

        public string DeleteProduct(int id);

        public Product GetProductById(int id);

        public string UpdateProduct(Product product);
    }
}
