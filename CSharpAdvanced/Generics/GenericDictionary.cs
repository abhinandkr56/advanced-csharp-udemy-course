namespace CSharpAdvanced;

public class GenericDictionary<TKey, TValue>
{
    private Dictionary<TKey, TValue> _dictionary = new Dictionary<TKey, TValue>();

    public void Add(TKey key, TValue value)
    {
        _dictionary[key] = value;
    }

    public TValue this[TKey key]
        => _dictionary[key];
    
}

public class DiscountCalculator<TProduct> where TProduct : Product
{
    public TProduct MaxPrice(TProduct a, TProduct b)
    {
        return a.Price.CompareTo(b.Price) >= 0 ? a : b;
    }
}

public class Product : IComparable<Product>
{
    public int Id { get; set; }

    public string Name { get; set; }
    
    public decimal Price { get; set; }
    
    public int CompareTo(Product? obj)
    {
        return Price.CompareTo(obj.Price);
    }
}