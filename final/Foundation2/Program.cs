using System;

class Program
{
    static void Main(string[] args)
    {
        Product pencil = new Product("Pencil", "P-001", 1, 20);
        Product eraser = new Product("Eraser", "E-002", 2, 5);
        Product chair = new Product("Chair", "C-003", 15, 4);
        Product table = new Product("Table", "T-004", 25, 1);

        List<Product> Order1List = [pencil, eraser];
        List<Product> Order2List = [chair, table];

        Address address1 = new Address("123 Main St.", "City Town", "ID", "US");
        Address address2 = new Address("456 Center St.", "Town City", "BC", "Canada");

        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Real Person", address2);

        Order order1 = new Order(Order1List, customer1);
        Order order2 = new Order(Order2List, customer2);

        Console.WriteLine($"Order 1\n{order1.GetPackingLabel()}\n{order1.GetShippingLabel()}\n\n${order1.GetTotalPrice()}\n\nOrder 2\n{order2.GetPackingLabel()}\n{order2.GetShippingLabel()}\n\n${order2.GetTotalPrice()}");
    }
}