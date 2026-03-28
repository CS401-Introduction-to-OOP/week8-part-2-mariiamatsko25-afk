namespace task3_week8;

public class DataContainer<T> where T : DataItem
{
    private readonly List<T> _items = new();
    public void AddItem(T item)
    {
        _items.Add(item);
    }
    public long GetTotalSize()
    {
        long sum = 0;
        foreach (var item in _items)
        {
            long itemSum = item.GetSize();
            sum += itemSum;
        }

        return sum;
    }
}