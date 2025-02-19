namespace SmarterIntervals.Shared;

public abstract class Entity
{
    public Guid Id { get; protected set; }
    public ICollection<DomainEvent> DomainEvents { get; } = new List<DomainEvent>();
}