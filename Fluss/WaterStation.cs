namespace Fluss;

internal class WaterStation( string name ) : IObserver
{
    private int _intake = 0;

    public string Name { get; set; } = name;

    public void Update( object sender , WaterLevelChangeEventArgs e )
    {
        if ( e.NewLevel > 8000 && _intake >= 0 )
        {
            Console.WriteLine( $"The {GetType().Name} \"{this}\" has stopped their intake due to too high water level of the {sender}" );
            _intake = -1;
        }

        if ( e.NewLevel < 3000 && _intake <= 0 )
        {
            Console.WriteLine( $"The {GetType().Name} \"{this}\" has increased their intake due to too low water level of the {sender}" );
            _intake = 1;
        }

        if ( e.NewLevel >= 3000 && e.NewLevel <= 8000 && _intake != 0 )
        {
            Console.WriteLine( $"The {GetType().Name} \"{this}\" has normalized their intake due to too water level of the {sender} returning to normal" );
            _intake = 0;
        }
    }

    public override string ToString() => Name;
}