namespace SmarterIntervals.Shared;

public class OutboxMessage
{
    public Guid Id { get; set; }
    public required string EventType { get; set; }
    public required string Payload { get; set; }
    public DateTime OccurredOn { get; set; }
    public bool IsPublished { get; set; }
}