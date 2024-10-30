namespace WarpCore;

internal static class WarpCoreConsole
{
    public static void PrintOverheatWarning( object sender , CoreTempChangeEventArgs e )
    {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.DarkYellow;
        Console.Write( $"Warning! Warp Core temperature is over 500°C!!! Overheat imminent . . ." );
        Console.ResetColor();
    }

    public static void PrintTempLog( object sender , CoreTempChangeEventArgs e )
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write( $"\n[{e.Timestamp}] {sender}: Core temperature changed to {e.NewTemp:F2}°C ( from {e.OldTemp:F2}°C)\n" );
        Console.ResetColor();
    }
}