using System;
using System.Collections.Generic;
using System.Text;
using static IscrizioneEsame.CorsoDiLaurea;

namespace IscrizioneEsame
{
   public class Immatricolazione
    {
		public enum Percorso
		{
			Matematica,
			Fisica,
			Informatica,
			Ingegneria,
			Lettere
		};

		int matricolaseed = 1000;
		public string Matricola { get; }
		public DateTime DataInizio { get; set; }
		public Percorso CorsoLaurea { get; set; }
		public bool FuoriCorso { get; set; }
		public int CFUAccumulati { get; set; }


		public Immatricolazione(string nomelaurea, Percorso percorsi, List<CorsoDiLaurea> corsilaurea)
		{
			Matricola = matricolaseed.ToString();
			matricolaseed++;
			DataInizio = DateTime.Today;
			CorsoLaurea = percorsi;
			FuoriCorso = false;
			CFUAccumulati = cfuAccumulati(corsilaurea, nomelaurea);

		}

		//calcolo i cfu degli esami per cui il superamento è true
		public int cfuAccumulati(List<CorsoDiLaurea> corsilaurea, string nomelaurea)
		{ int cfupassati = 0;
			foreach (CorsoDiLaurea el in corsilaurea)
			{
				if (el.NomeLaurea == nomelaurea)
				{
					foreach (Corso c in el.CorsiAssociati)
					{
						if (c.Superamento == true)
						{
							cfupassati = cfupassati + c.CFU;
						}
					}
				
				}
			}
			return cfupassati;
		}

    }
}