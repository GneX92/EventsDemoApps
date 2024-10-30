namespace Counter;

internal class Program
{
    static void Main( string [] args )
    {
        Counter counter = new Counter(x => x >= 1000);
        AlternativeCounter altCounter = new AlternativeCounter(y => y >= 42);
        
        counter.OnMilestoneReached += () => Console.WriteLine( "Counter1: Milestone Reached. Geil!" );
        altCounter.OnMilestoneReached += () => Console.WriteLine( "Counter2: Milestone Reached. Oba Geil!" );
        
        counter.IncreaseCounter(500);
        counter.IncreaseCounter(600);
        
        altCounter.IncreaseCounter(13);
        altCounter.IncreaseCounter(30);
        
        counter.ResetCounter();
        altCounter.ResetCounter();
    }
}