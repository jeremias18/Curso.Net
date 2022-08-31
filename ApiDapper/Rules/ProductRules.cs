using ApiDapper.Data;
using ApiDapper.Models;

namespace ApiDapper.Rules {
    public class ProductRules {
        public List<Product> GetAllProducts() {
            var data = new NorthWindData();
            return data.getAllProducts();
        }
        public Product GetProductById(int id) {
            var data = new NorthWindData();
            return data.GetProductById(id);
        }
        public Product GetProductById(Product p) {
            var data = new NorthWindData();
            return data.GetProductById(p);
        }


    }
}
