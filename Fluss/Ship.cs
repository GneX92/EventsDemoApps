namespace Fluss;

internal class Ship( string name ) : IObserver
{
    private bool _isMoving = true;

    public string Name { get; set; } = name;

    public void Update( object sender , WaterLevelChangeEventArgs e )
    {
        if ( e.NewLevel <= 250 || e.NewLevel >= 8000 && _isMoving )
        {
            Console.WriteLine( $"The {GetType().Name} \"{this}\" has stopped due to too high/low water level of the {sender}" );
            _isMoving = false;
        }

        if ( e.NewLevel > 250 || e.NewLevel < 8000 && !_isMoving )
        {
            Console.WriteLine( $"The {GetType().Name} \"{this}\" has started moving due to water level of the {sender} returning to normal levels" );
            _isMoving = true;
        }
    }

    public override string ToString() => Name;
}