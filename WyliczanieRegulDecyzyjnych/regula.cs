using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WyliczanieRegulDecyzyjnych
{
    public class Regula
    {
        public List<deskryptor> deskryptory = new List<deskryptor>();
        public int decyzja;
        List<int> deskryptory_nr; // numery dekryptorów z jakich powstała reguła
        public Regula(List<int> lista, int[] tablica)
        {
            foreach (var item in lista)
            {
                deskryptor deskryptor_temp = new deskryptor();
                deskryptor_temp.numer = item;
                deskryptor_temp.wartosc = tablica[item];
                this.deskryptory.Add(deskryptor_temp);
            }
            this.deskryptory_nr = lista;
            decyzja = tablica.Last();
        }

        public List<int> kombinacja ()
        {
            return deskryptory_nr;
        }

        public bool sprzecznosc (Regula badanie)
        {
            if (deskryptory.Count() != badanie.deskryptory.Count()) return false;

            for (int i = 0; i < deskryptory.Count(); i++)
            {
                if (badanie.deskryptory[i].numer == this.deskryptory[i].numer && badanie.deskryptory[i].wartosc == this.deskryptory[i].wartosc)
                {
                    continue;
                }
                else return false;

            }

            if (badanie.decyzja != this.decyzja)
            {
                return false;
            }
            return true;

        }
    }
}
