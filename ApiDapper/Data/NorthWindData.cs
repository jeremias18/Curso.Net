using ApiDapper.Models;
using Dapper;
using System.Data.SqlClient;

namespace ApiDapper.Data {
    public class NorthWindData {
        public string _cnnStr = "Server=JEREMIASNOTE\\SQLEXPRESS;Initial Catalog=Northwind;Trusted_Connection=true;Integrated Security=true";
        
        public bool DeleteOrderById(int id) {
            using var cnn = new SqlConnection(_cnnStr);
            cnn.Open();
            var tran = cnn.BeginTransaction();
            try {
                var sql = "DELETE FROM [Order Details] WHERE OrderID = @orderId";
                cnn.Execute(sql, new { orderId = id }, tran);
                sql = "DELETE FROM Orders WHERE OrderId = @orderId";
                cnn.Execute(sql, new { orderId = id }, tran);
                tran.Commit();
                return true;
            } catch {
                tran.Rollback();
                throw;
            } finally {
                cnn.Close();
            }
        }
        public List<Product> getAllProducts() {
            using var cnn = new SqlConnection(_cnnStr);
            cnn.Open();
            var query = "SELECT * FROM Products";
            var listProducts = cnn.Query<Product>(query).ToList();
            cnn.Close();
            return listProducts;
        }

        public Product GetProductById(int id) {
            using var cnn = new SqlConnection(_cnnStr);
            cnn.Open();
            var query = "SELECT * FROM Products WHERE ProductId = @IdProducto";
            var product = cnn.Query<Product>(query, new {IdProducto = id}).FirstOrDefault();
            cnn.Close();
            return product;
        }

        public Product GetProductById(Product p) {
            using var cnn = new SqlConnection(_cnnStr);
            cnn.Open();
            var query = "SELECT * FROM Products WHERE Products.Id = @ProductId";
            var product = cnn.Query<Product>(query, new { ProductId = p.ProductID }).FirstOrDefault();
            cnn.Close();
            return product;
        }

        public List<Order> GetAllOrders() {
            using var cnn = new SqlConnection("Server=JEREMIASNOTE\\SQLEXPRESS;Initial Catalog=Northwind;Trusted_Connection=true;Integrated Security=true");
            cnn.Open();
            var query = "SELECT o.OrderId, o.CustomerID, od.* FROM Orders o INNER JOIN [Order Details] od ON o.OrderId = od.OrderId";

            var diccion = new Dictionary<int, Order>();
            cnn.Query<Order, OrderDetail, Order>(query, (o, d) => {
                if (!diccion.TryGetValue(o.OrderId, out Order order))
                    diccion.Add(o.OrderId, order = o);
                if (order.Details == null)
                    order.Details = new List<OrderDetail>();
                order.Details.Add(d);
                return order;
            },
            splitOn: "OrderId").AsQueryable();

            var orders = diccion.Values.ToList();
            cnn.Close();
            return orders;
        }
    }
}
