using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Cartola.Models
{
    public class Campeonato
    {
        [BsonId] // Identificador único do campeonato
        public ObjectId Id { get; set; }

        [BsonElement("nome")]
        public string Nome { get; set; }

        [BsonElement("tipo")]
        public string Tipo { get; set; } // "Pontos Corridos", "Mata-mata", "Liga Clássica"

        [BsonElement("dataInicio")]
        public DateTime DataInicio { get; set; }

        [BsonElement("dataFim")]
        public DateTime DataFim { get; set; }

        [BsonElement("rodadas")]
        public List<Rodada> Rodadas { get; set; }

        [BsonElement("times")]
        public List<Time> Times { get; set; }
    }

}
