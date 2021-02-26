using System;
using System.Collections.Generic;
using System.Text;

namespace IscrizioneEsame
{
    public class Corso
    {
      public string nomeCorso { get; set; }
      public int CFU { get; set; }
      public bool Superamento { get; set; }

        //costruttore 
        public Corso(string corsoA, int cfu)
        {
            nomeCorso = corsoA;
            CFU = cfu;
            Superamento = false;
        }

    }
}
