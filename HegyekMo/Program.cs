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

            Console.WriteLine($"3. feladat: Hegycsúcsok száma: {hegyek.Count} db");

            //4 feladat

            double osszmagassag = 0;
            foreach (Hegy h in hegyek)
            {
                osszmagassag += h.magassag;
            }

            Console.WriteLine($"4. feladat: Hegycsúcsok átlagos magassága: {osszmagassag/hegyek.Count} m");

            //5 feladat
            Hegy legmagasabb = new Hegy();
            foreach (Hegy h in hegyek)
            {
                if (h.magassag > legmagasabb.magassag)
                {
                    legmagasabb = h;
                }
            }
            Console.WriteLine($"5. feladat: A legmagasabb hegycsúcs adatai:\n\tNév: {legmagasabb.hegycsucs}\n\tHegység: {legmagasabb.hegyseg}\n\tMagasság: {legmagasabb.magassag}");

            //6. feladat

            Console.Write("6. Feladat: Kérek egy magasságot: ");

            int be = int.Parse(Console.ReadLine());
            foreach (Hegy h in hegyek)
            {
                if (h.magassag > be)
                {
                    Console.WriteLine($"\tVan {be} méternél magasabb hegycsúcs: {h.hegycsucs} {h.magassag}");
                    break;
                }
            }

            //7. feladat

            double lab = 3.280839895;
            int lab3000db = 0;

            foreach (Hegy h in hegyek)
            {
                if (h.magassag*lab >= 3000)
                {
                    lab3000db++;
                }
            }
            Console.WriteLine($"7. feladat: 3000 lábnál magasabb hegycsúcsok száma : {lab3000db}");


            Console.ReadLine();

        }
    }
}
