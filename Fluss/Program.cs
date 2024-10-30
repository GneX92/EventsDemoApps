namespace Fluss;

internal class Program
{
    static void Main( string [] args )
    {
        Random rnd = new();

        River rhein = new( "Rhein" , 5000 );
        River donau = new( "Donau" , 5000 );

        City koeln = new( "Köln" );
        City duesseldorf = new( "Düsseldorf" );
        City ulm = new( "Ulm" );

        Ship lorelei = new( "Lorelei" );
        Ship rheingold = new( "Rheingold" );
        Ship xaver = new( "Xaver" );
        Ship franz = new( "Franz" );

        WaterStation strauß1 = new( "Strauß 1" );

        rhein.Subscribe( koeln );
        rhein.Subscribe( duesseldorf );
        rhein.Subscribe( lorelei );
        rhein.Subscribe( rheingold );

        donau.Subscribe( ulm );
        donau.Subscribe( xaver );
        donau.Subscribe( franz );
        donau.Subscribe( strauß1 );

        while ( true )
        {
            int rheinwater = rnd.Next( 100 , 10001 );
            int donauwater = rnd.Next( 100 , 10001 );

            Console.WriteLine( "Rhein water: " + rheinwater );
            rhein.WaterLevel = rheinwater;

            Console.WriteLine( "Donau water: " + donauwater );
            donau.WaterLevel = donauwater;

            Thread.Sleep( 1000 );
        }
    }
}