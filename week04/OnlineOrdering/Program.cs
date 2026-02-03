using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("231 main St", "Monrovia", "Montserrado", "USA");
        Address address2 = new Address("304 Water st", "Sinkor", "Montserrado", "Liberia");


        
        Customer customer1 = new Customer("Jonathan Quiwon", address1);
        Customer customer2 = new Customer("Blessing Kollie", address2);

        
        Product item1 = new Product("USB-C Hub", 2201, 24.99m, 2);
        Product item2 = new Product("1080p Webcam", 4450, 39.99m, 1);
        Product item3 = new Product("Mechanical Keyboard", 1001, 59.50m, 1);
        Product item4 = new Product("Mouse Pad (XL)", 3007, 12.00m, 3);

        
        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);


        order1.AddProduct(item1);
        order1.AddProduct(item2);
        order2.AddProduct(item3);
        order2.AddProduct(item4);

        List<Order> orders = new List<Order> { order1, order2 }; 

        
        foreach (var order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine();
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine();

            Console.WriteLine($"Subtotal: {order.GetSubTotal():C}");
            Console.WriteLine($"Shipping: {order.GetShippingCost():C}");
            Console.WriteLine($"Total:    {order.GetTotalPrice():C}");
            Console.WriteLine(new string('-', 50));
        }




    }


}