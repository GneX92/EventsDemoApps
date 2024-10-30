namespace Counter;

internal class AlternativeCounter(Predicate<int> milestone = null)
{
    public event Action OnMilestoneReached;

    private Predicate<int> _milestone = milestone;

    public int Count { get; private set; } = 0;
    
    public void IncreaseCounter( int x )
    {
        Count += x;
        
        if ( _milestone(Count) )
            OnMilestoneReached?.Invoke();
    }
    
    public void ResetCounter() => Count = 0;
}