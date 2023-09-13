using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Backend.Models
{
    [BsonIgnoreExtraElements]
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = String.Empty;

        [BsonElement("first_name")]
        public string FirstName { get; set; } = String.Empty;
        
        [BsonElement("last_name")]
        public string LastName { get; set; } = String.Empty;
    }
}