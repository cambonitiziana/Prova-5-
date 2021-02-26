using System;
using System.Collections.Generic;
using System.Text;

namespace IscrizioneEsame
{
   public class CorsoDiLaurea
    {
      

        public string NomeLaurea { get; set; }
        public int AnniTotali { get; }
        public int CFUTotali { get; }
        public List<Corso> CorsiAssociati { get; }

       // costruttore corsi di laurea: quindi alla fine potrò avere una lista <corsi di laurea> al cui interno ho liste <corso>
        public CorsoDiLaurea(string nomelaurea)
        {
            NomeLaurea = nomelaurea;
            AnniTotali = corsiAssociatiswitch(nomelaurea).Item2;
            CFUTotali = corsiAssociatiswitch(nomelaurea).Item3;
            CorsiAssociati = corsiAssociatiswitch(nomelaurea).Item1;
        }

        //List<Corso> CorsiMatematica, List<Corso> CorsiIngegneria, List<Corso> CorsiFisica, List<Corso> CorsiLettere, List<Corso> CorsiInformatica
        public int calcolocfu(List<Corso> corsi)
        {
            int cfu = 0;
            foreach (Corso el in corsi)
            {
                cfu = cfu + el.CFU;
            }
            return cfu;
        }
        public (List<Corso>, int, int) corsiAssociatiswitch(string nomelaurea )
         {
            List<Corso> Corsi = new List<Corso>();
            int anni = 0;


            #region ESAMI
            List<Corso> CorsiInformatica = new List<Corso>();
               Corso Analisi1 = new Corso("Analisi1", 10);
            Corso Calcolatori = new Corso("Calcolatori", 5);
                CorsiInformatica.Add(Analisi1);
                CorsiInformatica.Add(Calcolatori);


            List<Corso> CorsiMatematica = new List<Corso>();
                    Corso Analisi3= new Corso("Analisi3", 10);
                    Corso Gauss = new Corso("Gauss", 5);
                     CorsiMatematica.Add(Analisi3);
                     CorsiMatematica.Add(Gauss);


            List<Corso> CorsiIngegneria = new List<Corso>();
                    Corso Analisi6 = new Corso("Analisi6", 20);
                    Corso Gauss90 = new Corso("Gauss90", 5);
                    CorsiIngegneria.Add(Analisi6);
                    CorsiIngegneria.Add(Gauss90);

            List<Corso> CorsiLettere = new List<Corso>();
                    Corso Dante = new Corso("Dante", 15);
                    Corso Pascoli = new Corso("Pascoli", 5);
                    CorsiLettere.Add(Analisi3);
                    CorsiLettere.Add(Gauss);


            List<Corso> CorsiFisica = new List<Corso>();
                   Corso Analisi3333 = new Corso("Analisi3333", 10);
                   Corso XXXGauss = new Corso("XXXGauss", 5);
                   CorsiFisica.Add(Analisi3);
                   CorsiFisica.Add(XXXGauss);
            #endregion


            switch (nomelaurea)
            {
                
                case "Matematica":
                     Corsi= CorsiMatematica;
                    anni = 3;
                    
                        break;
                
                case "Ingegneria":
                
                        Corsi=CorsiIngegneria;
                         anni = 3;
                        break;
                    
                case "Informatica":
                    anni = 3;
                        Corsi = CorsiInformatica;
                        break;
                    
                case "Lettere":
                    anni = 5;
                        Corsi=CorsiLettere;
                        break;
                    
                case "Fisica":
                    anni = 5;
                        Corsi= CorsiFisica;
                        break;
            }
            return (Corsi, anni, calcolocfu(Corsi));

        }




    }
}
