using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjektKeZkousce;

namespace ProjektKeZkousce
{
    public class Pojisteny
    {
        /// <summary>
        /// Získá nebo nastaví jméno pojištěného.
        /// </summary>
        public string Jmeno { get; set; }
        /// <summary>
        /// Získá nebo nastaví příjmení pojištěného.
        /// </summary>
        public string Prijmeni { get; set; }
        /// <summary>
        /// Získá nebo nastaví věk pojištěného.
        /// </summary>
        public int Vek { get; set; }
        /// <summary>
        /// Získá nebo nastaví telefonní číslo pojištěného.
        /// </summary>
        public string TelefonniCislo { get; set; }

        /// <summary>
        /// Inicializuje novou instanci třídy Pojisteny se zadanými informacemi.
        /// </summary>
        /// <param name="jmeno">Jméno pojištěného.</param>
        /// <param name="prijmeni">Příjmení pojištěného.</param>
        /// <param name="vek">Věk pojištěného.</param>
        /// <param name="telefonniCislo">Telefonní číslo pojištěného.</param>
        public Pojisteny(string jmeno, string prijmeni, int vek, string telefonniCislo)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = vek;
            TelefonniCislo = telefonniCislo;
        }
        /// <summary>
        /// Převede informace o pojištěném na řetězec.
        /// </summary>
        /// <returns>Řetězec obsahující informace o pojištěném.</returns>
        public override string ToString()
        {
            return $"Jméno: {Jmeno}\nPříjmení: {Prijmeni}\nVěk: {Vek}\nTelefonní číslo: {TelefonniCislo}";
        }
    }
}