namespace SmarterIntervals.Shared;

public abstract record DomainEvent
{
    public DateTime OccurredOn { get; } = DateTime.UtcNow;
}