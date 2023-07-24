using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjektKeZkousce;

namespace ProjektKeZkousce
{
    public class EvidencePojisteni
    {
        private List<Pojisteny> pojisteni;
        /// <summary>
        /// Inicializuje novou instanci třídy EvidencePojisteni.
        /// </summary>

        public EvidencePojisteni()
        {
            pojisteni = new List<Pojisteny>();
        }
        /// <summary>
        /// Vytvoří nového pojištěného a přidá ho do evidence.
        /// </summary>
        /// <param name="jmeno">Křestní jméno pojištěného.</param>
        /// <param name="prijmeni">Příjmení pojištěného.</param>
        /// <param name="vek">Věk pojištěného.</param>
        /// <param name="telefonniCislo">Telefonní číslo pojištěného.</param>
        public void VytvoritPojisteneho(string jmeno, string prijmeni, int vek, string telefonniCislo)
        {
            Pojisteny novyPojisteny = new Pojisteny(jmeno, prijmeni, vek, telefonniCislo);
            pojisteni.Add(novyPojisteny);
        }

        /// <summary>
        /// Zobrazí všechny pojištěné v evidenci.
        /// </summary>
        public void ZobrazitVsechnyPojistene()
        {
            foreach (Pojisteny pojisteny in pojisteni)
            {
                Console.WriteLine(pojisteny);
                Console.WriteLine("---------------");
            }
        }

        /// <summary>
        /// Vyhledá pojištěného v evidenci podle jména a příjmení.
        /// </summary>
        /// <param name="jmeno">Jméno pojištěného.</param>
        /// <param name="prijmeni">Příjmení pojištěného.</param>
        /// <returns>Pojištěný odpovídající hledaným kritériím nebo null, pokud nebyl nalezen.</returns>
        public Pojisteny NajitPojisteneho(string jmeno, string prijmeni)
        {
            return pojisteni.Find(p => p.Jmeno == jmeno && p.Prijmeni == prijmeni);
        }
    }
}
