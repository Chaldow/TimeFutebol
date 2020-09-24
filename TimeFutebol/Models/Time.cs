using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeFutebol.Models
{
    public class Time
    {
        public int id { get; set; }
        public string nome { get; set; }
        public int anoCriacao { get; set; }
        public string estado { get; set; }
        public string imagem { get; set; }
        public string mascote { get; set; }
        public int qtdTitulosBrasil { get; set; }
        public int qtdTitulosCopaBrasil { get; set; }
        public int qtdTitulosRegional { get; set; }
    }
}
