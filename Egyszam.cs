using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgyszamMinta2020
{
    class Egyszam
    {
        private string nev;
        //private int elso;
        //private int masodik;
        //private int harmadik;
        //private int negyedik;
        List<int> fordulok = new List<int>();

        public Egyszam(string sor)
        {
            string[] d = sor.Split(' ');
            nev = d[0];
            for (int i = 1; i < d.Length; i++)
            {
                fordulok.Add(Convert.ToInt32(d[i]));
            }
            
        }

        public string Nev { get => nev; set => nev = value; }
        public List<int> Fordulok { get => fordulok; set => fordulok = value; }
    }
}
