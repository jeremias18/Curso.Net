using New.Namespace;
using Microsoft.EntityFrameworkCore;
using Clase_27_BdD.Models;

var ctx = new NorthwindContext();

//var customers = ctx.Customers.Select(selector => 
//                                    new {IdCustomer = selector.CustomerId,
//                                        NameCustomer = selector.CompanyName});


//foreach (var customer in customers) {
//    console.writeline(customer.idcustomer + ", " + customer.namecustomer);
//}

Console.WriteLine("Ingrese el idCustomer a buscar:");
string idCustomer = Console.ReadLine();

bool anycustomer = ctx.Customers.Any(x => x.CustomerId == idCustomer.ToUpper());

if (anycustomer) {
    var customer = ctx.Customers.Include(i => i.Orders).FirstOrDefault(ctx => ctx.CustomerId == idCustomer);
    Console.WriteLine(customer.CompanyName + ", " + customer.CustomerId);
    Console.WriteLine("Orders: ");
    foreach(var item in customer.Orders) {
        Console.WriteLine(item.CustomerId + " - " + item.OrderDate);
    }

} else {
    Console.WriteLine("No existe");
}


//Para agregar un nuevo Customer.
    //var newCustomers = new Customer() {
    //    CustomerId = "JP",
    //    CompanyName = "Jeremias Paladini",
    //    Orders = new List<Order>()
    //};

    //newCustomers.Orders.Add(new Order() {
    //    CustomerId = "jere",
    //    OrderDate = DateTime.Now,
    //});

    //ctx.Add(newCustomers);
    //ctx.SaveChanges();

// Para editer
    //var reg = ctx.Customers.FirstOrDefault(r => r.CustomerId == idCustomer);
    //if(reg != null) {
    //    reg.CompanyName = reg.CompanyName.ToUpper() + " Editado";
    //    ctx.SaveChanges();
    //}

//Para eliminar
//Elimino las ordenes.
var regOrders = ctx.Orders.Where(r => r.CustomerId == idCustomer);
ctx.RemoveRange(regOrders);

//Elimino el Customer.
var regCustomers = ctx.Customers.FirstOrDefault(r => r.CustomerId == idCustomer);
ctx.Remove(regCustomers);
ctx.SaveChanges();