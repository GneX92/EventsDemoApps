namespace Fluss;

public class WaterLevelChangeEventArgs( int newlevel ) : EventArgs
{
    public int NewLevel { get; set; } = newlevel;

    public string Timestamp { get; set; } = DateTime.Now.ToLongTimeString();
}