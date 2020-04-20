using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EgyszamMinta2020
{
    class Program
    {
        static List<Egyszam> egyszamLista = new List<Egyszam>();

        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("egyszamjatek1.txt", Encoding.UTF8);
            string sor = "";
            while (!sr.EndOfStream)
            {
                sor = sr.ReadLine();
                Egyszam e = new Egyszam(sor);
                egyszamLista.Add(e);
            }
            sr.Close();

            Console.WriteLine("3. feladat");
            Console.WriteLine("Játékosok száma: " + egyszamLista.Count);

            Console.WriteLine("4. feladat");
            Console.Write("Kérem a forduló sorszámát: ");
            int sorszam = Convert.ToInt32(Console.ReadLine());
            int tippOsszeg = 0;
            for (int i = 0; i < egyszamLista.Count; i++)
            {
                tippOsszeg += egyszamLista[i].Fordulok[sorszam - 1];
            }
            double tippAtlag = (double)tippOsszeg / egyszamLista.Count;
            Console.WriteLine("5. feladat");
            Console.WriteLine("A megadott forduló tippjeinek átlaga: " 
                + Math.Round(tippAtlag,2));



            Console.ReadKey();
        }
    }
}
