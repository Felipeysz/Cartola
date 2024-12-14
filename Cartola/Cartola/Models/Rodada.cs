using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Cartola.Models
{
    public class Rodada
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("numero")]
        public int Numero { get; set; }

        [BsonElement("data")]
        public DateTime Data { get; set; }

        [BsonElement("jogos")]
        public List<Jogo> Jogos { get; set; }
    }

}
