namespace Counter;

public delegate void Milestones( int x );

public delegate void Aktion();

internal class Counter
{
    private int _counter = 0;
    //private int _trigger = 1000;

    public int Count
    {
        get => _counter;
        private set
        {
            if ( _counter + value >= _trigger )
        }
    }

    public event EventHandler<EventArgs> MilestoneReached;

    public void IncreaseCounter( int x ) => Count += x;
}