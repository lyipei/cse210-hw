using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("175 Valley River", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("Mary White", address1);

        Product product1 = new Product("IPad", "A0001", 499, 3);
        Product product2 = new Product("IWatch", "A0002", 299, 5);

        Order order1 = new Order(customer1);
        order1.Additem(product1);
        order1.Additem(product2);

        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: {order1.GetTotalCost()}\n");


        Address address2 = new Address("145 Brooklyn Ave", "Brooklyn", "NY", "USA");
        Customer customer2 = new Customer("Josph Smith", address2);

        Product product3 = new Product("Watter Bottle", "B0003", 49, 11);
        Product product4 = new Product("Air Fryer", "B0004",79 , 2);

        Order order2 = new Order(customer2);
        order2.Additem(product3);
        order2.Additem(product4);

        Console.WriteLine("Order 2:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: {order2.GetTotalCost()}\n");
    }
}