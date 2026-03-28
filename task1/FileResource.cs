namespace task1;

public class FileResource : Resource, IDisposable
{
    public FileResource(string name) : base(name)
    {
    }
    public override void Open()
    {
        IsOpen = true;
        Console.WriteLine($"File {Name} is open");
    }
    public override void Close()
    {
        IsOpen = false;
        Console.WriteLine($"File {Name} is closed"); 
    }
    public void Dispose()
    {
        Close();
        Console.WriteLine($"File {Name} was disposed");
    } 
}