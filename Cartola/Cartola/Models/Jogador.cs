using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Cartola.Models
{
    public class Jogador
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("nome")]
        public string Nome { get; set; }

        [BsonElement("posicao")]
        public string Posicao { get; set; }

        [BsonElement("pontuacao")]
        public int Pontuacao { get; set; }
    }

}
