using System;
using System.Collections.Generic;

namespace IscrizioneEsame
{
    class Program
    {
        static void Main(string[] args)
        {

            List<CorsoDiLaurea> CorsidiLaurea = new List<CorsoDiLaurea>();
            CorsoDiLaurea Matematica = new CorsoDiLaurea("Matematica");
            CorsoDiLaurea Ingegneria = new CorsoDiLaurea("Ingegneria");
            CorsoDiLaurea Fisica = new CorsoDiLaurea("Fisica");
            CorsoDiLaurea Lettere = new CorsoDiLaurea("Lettere");
            CorsoDiLaurea Informatica = new CorsoDiLaurea("Informatica");
            
            CorsidiLaurea.Add(Matematica);
            CorsidiLaurea.Add(Fisica);
            CorsidiLaurea.Add(Ingegneria);
            CorsidiLaurea.Add(Lettere);
            CorsidiLaurea.Add(Informatica);


            Studente Tiziana = new Studente("Tiziana", "Camboni", new DateTime(1994, 10, 18), "Ingeneria", Immatricolazione.Percorso.Ingegneria, CorsidiLaurea);
            


        }
    }
}
