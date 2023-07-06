class Product
{
    private  string _name;
    private  int _productID;
    private  int _price;
    private  int _quantity;

    public Product (string name, int productID, int price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public int ProductPrice()
    {
        return _price * _quantity;
    }

    public string GetProductName()
    {
        return _name;
    }
    public int GetProductNameID()
    {
        return _productID;
    }
    public int GetPrice()
    {
        return _price;
    }
    public int GetQty()
    {
        return _quantity;
    }
}