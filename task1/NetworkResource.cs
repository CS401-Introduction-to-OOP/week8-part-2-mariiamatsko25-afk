namespace task1;

public class NetworkResource : Resource, IDisposable
{
    public NetworkResource(string name) : base(name)
    {
    }

    public override void Open()
    {
        IsOpen = true;
        Console.WriteLine($"Network resource {Name} is open");
    }

    public override void Close()
    {
        IsOpen = false;
        Console.WriteLine($"Network resource {Name} is closed");
        
    }

    public void Dispose()
    {
        Close();
        Console.WriteLine($"Network resource {Name} was disposed");
    }
}