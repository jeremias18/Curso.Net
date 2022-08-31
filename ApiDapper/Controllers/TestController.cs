using ApiDapper.Models;
using ApiDapper.Rules;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiDapper.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase {
        [HttpGet]
        public List<Product> GetAllProducts() {
            var rule = new ProductRules();
            return rule.GetAllProducts();
        }

        [HttpGet("/api/test/{id}")]
        public Product GetProduct(int id) {
            var rule = new ProductRules();
            return rule.GetProductById(id);
        }

        [HttpGet("/api/orders/")]
        public List<Order> GetOrders() {
            var rule = new OrderRules();
            return rule.GetAllOrders();
        }

        [HttpDelete("/api/orders/")]
        public bool Delete(int id) {
            var rule = new OrderRules();
            return rule.DeleteOrderById(id);
        }
    }
}
