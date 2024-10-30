namespace Fluss;

internal class City( string name ) : IObserver
{
    private bool _hasBarricade = false;

    public string Name { get; set; } = name;

    public void Update( object sender , WaterLevelChangeEventArgs e )
    {
        if ( e.NewLevel >= 8200 && !_hasBarricade )
        {
            Console.WriteLine( $"The {GetType().Name} \"{this}\" is building a water barricade due to high water level of the {sender}" );
            _hasBarricade = true;
        }

        if ( e.NewLevel < 8200 && _hasBarricade )
        {
            Console.WriteLine( $"The {GetType().Name} \"{this}\" is taking down their water barricade due to the water level of the {sender} returning to normal" );
            _hasBarricade = false;
        }
    }

    public override string ToString() => Name;
}