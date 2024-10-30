namespace WarpCore;

public delegate void CoreTempChangeEventHandler( object sender , CoreTempChangeEventArgs e );

public class WarpCore( double temperature )
{
    private double _coreTemp = temperature;

    public double CoreTemp
    {
        get { return _coreTemp; }
        set
        {
            if ( _coreTemp != value )
                CoreTempChange?.Invoke( this , new CoreTempChangeEventArgs( _coreTemp , value ) );

            if ( value >= 500 )
                CoreTempOver500?.Invoke( this , new CoreTempChangeEventArgs( _coreTemp , value ) );

            _coreTemp = value;
        }
    }

    public event EventHandler<CoreTempChangeEventArgs> CoreTempChange;

    public event EventHandler<CoreTempChangeEventArgs> CoreTempOver500;

    public override string ToString() => GetType().Name;
}