namespace WarpCore;

internal class Program
{
    static void Main( string [] args )
    {
        Random rnd = new();

        WarpCore warpCore1 = new( 499.9 );

        warpCore1.CoreTempChange += WarpCoreConsole.PrintTempLog;
        warpCore1.CoreTempOver500 += WarpCoreConsole.PrintOverheatWarning;

        while ( true )
        {
            warpCore1.CoreTemp += rnd.NextDouble() - 0.5;
            Thread.Sleep( 1000 );
        }
    }
}