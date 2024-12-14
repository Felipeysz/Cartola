using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Cartola.Models
{
    public class Time
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("nome")]
        public string Nome { get; set; }

        [BsonElement("jogadores")]
        public List<Jogador> Jogadores { get; set; }

        [BsonElement("pontuacao")]
        public int Pontuacao { get; set; }
    }

}
