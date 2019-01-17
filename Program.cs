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
            werte = new string[][]
            {
                new string[] {"K12", "130"},
                new string[] {"B49", "112"},
                new string[] {"K12", "138"},
                new string[] {"B16", "199"},
                new string[] {"K12", "131"},
            };
        }

        string[][] werte;
        static Program program;

        static void Main(string[] args)
        {
            program = new Program();
            program.DurchlaufeVerzweigtesArray();
            program.WarteBisEnter();
        }

        public void DurchlaufeVerzweigtesArray()
        {
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
    }
}
