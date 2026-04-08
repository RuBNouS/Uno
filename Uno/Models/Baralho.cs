using System;
using System.Collections.Generic;

namespace UnoDesktopGame.Models
{
    [Serializable]
    public class Baralho
    {
        public List<Carta> Cartas { get; set; }

        public Baralho()
        {
            Cartas = new List<Carta>();
        }
    }
}