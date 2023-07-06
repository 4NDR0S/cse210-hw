class Order
{
    private string _customer;

    public List <Product> _products = new List<Product>();

    public void SetCustomer(string x)
    {
        _customer = x;
    }

    public int TotalCostProduct()
    {
        int total = 0;
            foreach (Product p in _products)
            {
                total = p.ProductPrice()+total;
            }
        return total;
    }

    public void PackingLabel()
    {
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("");
            Console.WriteLine("QTY │     ID     │      PRODUCT   &   UNIT PRICE  ");
        //name and product id
        foreach (Product a in _products)
        {
            Console.WriteLine($" {a.GetQty()}  │ ID: {a.GetProductNameID()} │ {a.GetProductName()}  -  ${a.GetPrice()} ");
        }
        
        Console.WriteLine("");
        Console.WriteLine("-------------------------------------------------");
    }

    public void ShippingLabel(Customer a)
    {
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("");
        //name and address from client
        Console.WriteLine($"Client name: {a.GetName()}");
        Console.WriteLine($"Address: {a.GetAddress()}");
        Console.WriteLine("");
        Console.WriteLine("-------------------------------------------------");
    }
    public int ShippingCost(Address a)
    {
        if (a.LivesinUS() == "yes")
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }

}