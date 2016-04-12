using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Combinatorics.Collections;

namespace WyliczanieRegulDecyzyjnych
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ofdPlik.Filter = "Text Files (.txt)|*.txt";
        }
        int[][] systemDecyzyjny;
        private string sciezka;

        int[][] wczytajSystem(string sciezka)
        {
            string plik = System.IO.File.ReadAllText(ofdPlik.FileName);
            string[] tresc = plik.Split('\n');
            systemDecyzyjny = new int[tresc.Length][];
            for (int i = 0; i < tresc.Length; i++)
            {
                string poziom = tresc[i].Trim();
                string[] temp = poziom.Split(' ');
                systemDecyzyjny[i] = new int[temp.Length];
                for (int j = 0; j < temp.Length; j++)
                {
                    systemDecyzyjny[i][j] = int.Parse(temp[j]);
                }
            }
            return systemDecyzyjny;
        }

        private void  btnSzukaj_Click(object sender, EventArgs e)
        {
         //   ofdPlik.ShowDialog();
            if (ofdPlik.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }
            tbSciezka.Text = ofdPlik.FileName;
            sciezka = ofdPlik.FileName;
            systemDecyzyjny = wczytajSystem(sciezka);
            kombinacja(6, 2);

            List<bool> pokrycie = new List<bool>();
            for (int i = 0; i < systemDecyzyjny.Length; i++)
            {
                pokrycie.Add(false);
            }

            for (int i = 1; i < pokrycie.Count(); i++)
            {
                if (pokrycie.Contains(false) == false) break;

                List<List<int>> combinatons = kombinacja(systemDecyzyjny[0].Length - 1, i);

                for (int j = 0; j < combinatons.Count(); j++)
                {



                  
                    for (int k = 0; k < systemDecyzyjny.Length; k++)
                    {
                        Regula regula = new Regula(combinatons[j],systemDecyzyjny[k]);
                        bool Czysprzeczna = sprawdzanie(regula);

                        if (Czysprzeczna)
                        {
                            
                        }
                    }






                }

            }

        }

        private List<List<int>> kombinacja(int ilosc, int dlugosc)
        {
            List<List<int>> kombinacja = new List<List<int>>();
            List<int> temp = new List<int>();
            for (int i = 0; i < ilosc; i++)
			{
                temp.Add(i);
			}
            Combinations<int> kombinacje = new Combinations<int>(temp,dlugosc);
            foreach (var item in kombinacje)
            {
                kombinacja.Add((List<int>)item);
            }
            return kombinacja;
        }

        public bool sprawdzanie(Regula regula)
        {

            for (int i = 0; i < systemDecyzyjny.Length; i++)
            {

                Regula test = new Regula(regula.kombinacja(),systemDecyzyjny[i]);
                if (test.sprzecznosc(regula) == false)
                {
                    return true;
                }


            }
            return false;
        }


        private void btnSequentialCovering_Click(object sender, EventArgs e)
        {

        }






     public   static bool UnorderedEqual<T>(ICollection<T> a, ICollection<T> b)
    {
	// 1
	// Require that the counts are equal
	if (a.Count != b.Count)
	{
	    return false;
	}
	// 2
	// Initialize new Dictionary of the type
	Dictionary<T, int> d = new Dictionary<T, int>();
	// 3
	// Add each key's frequency from collection A to the Dictionary
	foreach (T item in a)
	{
	    int c;
	    if (d.TryGetValue(item, out c))
	    {
		d[item] = c + 1;
	    }
	    else
	    {
		d.Add(item, 1);
	    }
	}
	// 4
	// Add each key's frequency from collection B to the Dictionary
	// Return early if we detect a mismatch
	foreach (T item in b)
	{
	    int c;
	    if (d.TryGetValue(item, out c))
	    {
		if (c == 0)
		{
		    return false;
		}
		else
		{
		    d[item] = c - 1;
		}
	    }
	    else
	    {
		// Not in dictionary
		return false;
	    }
	}
	// 5
	// Verify that all frequencies are zero
	foreach (int v in d.Values)
	{
	    if (v != 0)
	    {
		return false;
	    }
	}
	// 6
	// We know the collections are equal
	return true;
    }
}
    }

 