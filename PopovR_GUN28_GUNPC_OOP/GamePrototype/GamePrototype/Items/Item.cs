namespace Items;

public abstract class Item
{
    public string Name { get; }
    protected uint Price { get; }

    protected Item(string name, uint price)
    {
        Name = name;
        Price = price;
    }
}