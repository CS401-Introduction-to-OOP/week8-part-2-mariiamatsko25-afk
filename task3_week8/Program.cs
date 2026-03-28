namespace task3_week8;

class Program
{
    static void Main(string[] args)
    {
        var container = new DataContainer<DataItem>();
        for (int i = 0; i < 10000; i++)
        {
            var item = new DataItem
            {
                Id = $"item-{i}",
                Payload = new byte[1024]
            };
            container.AddItem(item);
        }
        Console.WriteLine($"Total size before GC: {container.GetTotalSize()} bytes");
        GC.Collect();
        Console.WriteLine("GC.Collect() was called.");
        Console.WriteLine($"Total size after GC: {container.GetTotalSize()} bytes");
        
        // кількість байтів не змінилась тому, що ми користуємось контейнером і він залишається в купі, тому GC його не видаляє.
        
    }
}