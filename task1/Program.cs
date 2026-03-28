namespace task1;

class Program
{
    static void Main(string[] args)
    {
        var file1 = new FileResource("report.txt");
        var network = new NetworkResource("api.company.local");
        var manager = new ResourceManager<Resource>();
        
        manager.Add(file1);
        manager.Add(network);
        
        manager.OpenAll();
        
        using(var file2 = new FileResource("file"))
        {
            file2.Open();
            Console.WriteLine($"Open {file2.Name}");
        }
        
        manager.CloseAll();

        Console.WriteLine("Done.");
    }
}