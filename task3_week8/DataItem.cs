namespace task3_week8;

public class DataItem
{
    public string Id { get; set; } = string.Empty;
    public byte[] Payload { get; set; } = Array.Empty<byte>();
    public long GetSize()
    {
        return Payload.Length;
    } 
}