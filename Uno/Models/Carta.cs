using System;

namespace Uno.Models
{
    [Serializable]
    public class Carta
    {
        public int Id { get; set; } 
        public string Simbolo { get; set; }
        public string Cor { get; set; }
        public int Pontos { get; set; }

        public bool PodeSerJogada { get; set; }
    }
}