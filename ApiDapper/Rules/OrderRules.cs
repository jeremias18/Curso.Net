using ApiDapper.Data;
using ApiDapper.Models;

namespace ApiDapper.Rules {
    public class OrderRules {
        public List<Order> GetAllOrders() {
            var data = new NorthWindData();
            return data.GetAllOrders();
        }
        public bool DeleteOrderById(int id) { 
            var data = new NorthWindData();
            try {
                data.DeleteOrderById(id);
                return true;
            } catch {
                return false;
            }
        }
    }
}
