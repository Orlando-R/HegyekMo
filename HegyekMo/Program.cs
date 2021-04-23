using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HegyekMo
{
    public class Hegy
    {
        public string hegycsucs;
        public string hegyseg;
        public int magassag;

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Hegy> hegyek = new List<Hegy>();
            string file = "Magyarorszaghegyei.txt";
            StreamReader sr = new StreamReader(file);
            string[] sortomb;
            string fejlec = sr.ReadLine();

            while (sr.EndOfStream != true)
            {
                sortomb = sr.ReadLine().Split(';');
                Hegy h = new Hegy();
                h.hegycsucs = sortomb[0];
                h.hegyseg = sortomb[1];
                h.magassag = int.Parse(sortomb[2]);
                hegyek.Add(h);
            }
            sr.Close();

            Console.ReadLine();

        }
    }
}
