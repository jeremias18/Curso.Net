namespace ApiDapper.Models {
    public class Order {
        public int OrderId { get; set; }
        public string CustomerId { get; set; }
        public List<OrderDetail> Details { get; set; }
    }
}
