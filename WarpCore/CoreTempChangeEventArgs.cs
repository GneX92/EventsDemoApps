namespace WarpCore;

public class CoreTempChangeEventArgs( double oldTemp , double newTemp ) : EventArgs
{
    public double OldTemp { get; set; } = oldTemp;

    public double NewTemp { get; set; } = newTemp;

    public string Timestamp { get; set; } = DateTime.Now.ToLongTimeString();
}