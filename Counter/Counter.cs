﻿namespace Counter;

public delegate bool Milestone( int x );
public delegate void Aktion();

internal class Counter(Milestone milestone = null)
{
    public event Aktion OnMilestoneReached;

    private Milestone _milestone = milestone;

    public int Count { get; private set; } = 0;
    
    public void IncreaseCounter( int x )
    {
        Count += x;
        
        if ( _milestone(Count) )
            OnMilestoneReached?.Invoke();
    }
    
    public void ResetCounter() => Count = 0;
}