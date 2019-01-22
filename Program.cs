using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayIterator
{
    class Program
    {
        public Program()
        {
            // Hier definierst du das verzweigte Array. ;D
            // Also Ein Array, dass mehrere Arrays hat.
            werte = new string[][]
            {
                // Erstelle Array in Feld 0 das "K12" und "130" enthält 
                new string[] {"K12", "130"},
                new string[] {"B49", "112"},
                new string[] {"K12", "138"},
                new string[] {"B16", "199"},
                new string[] {"K12", "131"},
            };
        }

        string[][] werte;
        static Program program; // für dich irrelevant

        static void Main(string[] args)
        {
            program = new Program();  // das auch irrelvant
            //program.DurchlaufeVerzweigtesArray();
            program.ListeGeraeteAuf();
            program.WarteBisEnter();
        }

        // Mit der Methode durchläufst du das verzweigte Array.
        public void DurchlaufeVerzweigtesArray()
        {
            // Für jedes Element im übergordnetem Array.
            for (int i = 0; i < werte.GetLength(0); i++)
            {
                GibAus(werte[i][0] + "\t" + werte[i][1]);
            }
        }

        private void GibAus(string text)
        {
            Console.WriteLine(text);
        }

        private void WarteBisEnter()
        {
            Console.ReadLine();
        }

        private void ListeGeraeteAuf()
        {
            string[] kommtVor = new string[werte.GetLength(0)];

            // Schleife stellt Sucharray
            for (int i = 0; i < werte.GetLength(0); i++)
            {
                bool gibtEs = false;
                for (int j = 0; j < kommtVor.Length; j++)
                {
                    if (kommtVor[j] == werte[i][0])
                    {
                        gibtEs = true;
                    }
                }
                if (!gibtEs)
                {
                    kommtVor[i] = werte[i][0];
                    GibAus(werte[i][0] + "\t");
                    ListeWerteAuf(werte[i][0]);
                }
            }

            void ListeWerteAuf(string element)
            {
                for (int i = 0; i < werte.GetLength(0); i++)
                {
                    if (werte[i][0] == element)
                    {
                        GibAus("\t" + werte[i][1]);
                    }
                }
            }
        }
    }
}
