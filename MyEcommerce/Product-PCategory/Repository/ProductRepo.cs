using Microsoft.EntityFrameworkCore;
using Product_PCategory.DataAccess;
using Product_PCategory.Models;

namespace Product_PCategory.Repository
{
    public class ProductRepo:IProduct
    {
        private readonly ProductContext _context;

        public ProductRepo(ProductContext context)
        {
            _context = context;
        }

        public string AddNewProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return "Added Succefully";
        }

        public string DeleteProduct(int id)
        {
            var getProductId = _context.Products.Find(id);
            if (getProductId != null)
            {
                _context.Products.Remove(getProductId);
                _context.SaveChanges();
                return "deleted successfully";
            }
            else
            {
                return "Not found";
            }
        }

        public List<Product> getAllProducts()
        {
            return _context.Products.Include(x=> x.Category).ToList();
        }

        public Product GetProductById(int id)
        {
            return _context.Products.FirstOrDefault(p => p.ProductId == id);
        }

        public string UpdateProduct(Product product)
        {
            var getProductId = _context.Products.Find(product.ProductId);
            if (getProductId != null)
            {
                getProductId.Name = product.Name;
                getProductId.Description = product.Description;
                getProductId.CategoryId = product.CategoryId;
                getProductId.Price = product.Price;
                _context.SaveChanges();
                return "update successfully";

            }
            else
            {
                return "cannot update the details.";
            }
        }
    }
}
