using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Cartola.Models
{
    public class Jogo
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("timeCasa")]
        public string TimeCasa { get; set; }

        [BsonElement("timeVisitante")]
        public string TimeVisitante { get; set; }

        [BsonElement("placarCasa")]
        public int PlacarCasa { get; set; }

        [BsonElement("placarVisitante")]
        public int PlacarVisitante { get; set; }

        [BsonElement("data")]
        public DateTime Data { get; set; }
    }

}
