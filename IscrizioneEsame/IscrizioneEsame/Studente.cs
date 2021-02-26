using System;
using System.Collections.Generic;
using System.Text;
using static IscrizioneEsame.Immatricolazione;

namespace IscrizioneEsame
{
    public class Studente
    {
       public string Nome { get; set; }
       public string Cognome { get; set; }
	   public DateTime AnnoDiNascita { get; set; }
       private Immatricolazione Immatricolazione { get; set; }
       public List<Corso> Esami{ get; set; }
       private bool RichiestaLaurea { get; set; }

        //costruttore
        public Studente(string nome, string cognome, DateTime dnascita, string NomeCorsoLaurea, Percorso percorsi, List<CorsoDiLaurea> corsilaurea)
        {
            Nome = nome;
            Cognome = cognome;
            AnnoDiNascita = dnascita;
            Immatricolazione = new Immatricolazione(NomeCorsoLaurea, percorsi,corsilaurea);
            Esami = EsamiLaurea(NomeCorsoLaurea, corsilaurea);
        }
        
        //richiamo gli esami associati ad un corso di laurea
        public List<Corso> EsamiLaurea(string NomeCorsoLaurea, List<CorsoDiLaurea> corsilaurea)
        {
            List<Corso> CorsiAss = new List<Corso>();

            foreach (CorsoDiLaurea el in corsilaurea)
            {
                if (el.NomeLaurea == NomeCorsoLaurea)
                    CorsiAss= el.CorsiAssociati;
            }
            return CorsiAss;
        }
    }
}
