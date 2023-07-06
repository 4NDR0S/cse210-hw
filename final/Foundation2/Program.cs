using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation2 World!");
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("             Andros Computer Shop");
        Console.WriteLine("-------------------------------------------------");

        //order #1
        Order order1 = new Order();
        order1.SetCustomer("George's Computer Shop");
        Address address1 = new Address("Av Angamos Oeste 120", "Miraflores", "Lima", "Peru");
        Customer customer1 = new Customer("George's Computer Shop", address1);
        Product product1 = new Product("Mouse Logitech G502", 100502, 75, 9);
        // order1._products.Add(product1);
        Product product2 = new Product("Keyboard Logitech G150", 100150, 125, 6);
        Product product3 = new Product("Monitor Samsung Odyssey G3", 210003, 280, 5);
        Product product4 = new Product("Headset Razer Barracuda X-Black", 311002, 99, 7);
        order1._products.Add(product1);
        order1._products.Add(product2);
        order1._products.Add(product3);
        order1._products.Add(product4);

        order1.ShippingLabel(customer1);
        order1.PackingLabel();

        Console.WriteLine($"Total price: ${order1.TotalCostProduct()}");
        Console.WriteLine($"Shipping price: ${order1.ShippingCost(address1)}");
        int Total = order1.ShippingCost(address1) + order1.TotalCostProduct();
        Console.WriteLine($"Total Cost: ${Total}");
        Console.WriteLine();
        Console.WriteLine();
        //order #1 (end)


        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("             Andros Computer Shop");
        Console.WriteLine("-------------------------------------------------");
        //order #2
        Order order2 = new Order();
        order2.SetCustomer("Mauri");
        Address address2 = new Address("Av. Libertador Bernardo O'Higgins 108", "Región Metropolitana", "Santiago", "Chile");
        Customer customer2 = new Customer("Mauri", address2);
        Product product2_1 = new Product("Headset Redragon Zeus 2 H510", 400510, 79, 3);
        Product product2_2 = new Product("Keyboard Kumara K552", 420552, 63, 2);
        order2._products.Add(product2_1);
        order2._products.Add(product2_2);

        order2.ShippingLabel(customer2);
        order2.PackingLabel();

        Console.WriteLine($"Total price: ${order2.TotalCostProduct()}");
        Console.WriteLine($"Shipping price: ${order2.ShippingCost(address2)}");
        int Total_2 = order2.ShippingCost(address2) + order2.TotalCostProduct();
        Console.WriteLine($"Total Cost: ${Total_2}");
        Console.WriteLine();
        Console.WriteLine();
        //order #2 (end)


        //order #3
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("             Andros Computer Shop");
        Console.WriteLine("-------------------------------------------------");
        //order 3
        Order order3 = new Order();
        order3.SetCustomer("William");
        Address address3 = new Address("201 W Washington Blvd", "Los Angeles", "California", "US");
        Customer customer3 = new Customer("William", address3);
        Product product3_1 = new Product("Pad Steelseries Qck 450", 850450, 35, 2);
        Product product3_2 = new Product("Monitor Samsung Odyssey G7 28", 210007, 730, 1);
        Product product3_3 = new Product("Mouse Ryzer Viper V2", 321002, 131, 2);
        order3._products.Add(product3_1);
        order3._products.Add(product3_2);
        order3._products.Add(product3_3);

        order3.ShippingLabel(customer3);
        order3.PackingLabel();
        
        Console.WriteLine($"Total price: ${order3.TotalCostProduct()}");
        Console.WriteLine($"Shipping price: ${order3.ShippingCost(address3)}");
        int Total_3 = order3.ShippingCost(address3) + order3.TotalCostProduct();
        Console.WriteLine($"Total Cost: ${Total_3}");
        Console.WriteLine();
        //order #3 (end)
    }
}