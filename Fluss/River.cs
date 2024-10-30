namespace Fluss;

internal class River( string name , int waterlevel ) : IObservable
{
    private int _waterlevel = waterlevel;
    private List<IObserver> _observers = new();

    public string Name { get; set; } = name;

    public int WaterLevel
    {
        get => _waterlevel;
        set
        {
            NotifyObservers( value );

            _waterlevel = value;
        }
    }

    public event EventHandler<WaterLevelChangeEventArgs> WaterLevelChanged;

    public void NotifyObservers( int value )
    {
        if ( _waterlevel != value )
            WaterLevelChanged?.Invoke( this , new WaterLevelChangeEventArgs( value ) );
    }

    public void Subscribe( IObserver observer )
    {
        if ( !_observers.Contains( observer ) )
        {
            _observers.Add( observer );
            WaterLevelChanged += observer.Update;
        }
    }

    public void Unsubscribe( IObserver observer )
    {
        if ( _observers.Contains( observer ) )
        {
            _observers.Remove( observer );
            WaterLevelChanged -= observer.Update;
        }
    }
}