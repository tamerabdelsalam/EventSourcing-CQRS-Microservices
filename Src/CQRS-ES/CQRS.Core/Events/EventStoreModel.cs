namespace CQRS.Core.Events;

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class EventStoreModel
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public DateTime TimeStamp { get; set; }
    public Guid AggregateId { get; set; }
    public string AggregateType { get; set; }
    public int AggregateVersion { get; set; }
    public string EventType { get; set; }
    public BaseEvent EventData { get; set; }
}
