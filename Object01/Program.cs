using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object01
{
    class Teglalap
    {
        private int a;
        private int b;


        public Teglalap(int aOldal, int bOldal)
        {
            a = aOldal;
            b = bOldal;
        }


        public int Kerulet()
        {
            return 2 * (a + b);
        }

        public int Terulet() 
        {
            return a * b;
        }
    }

    class Kor
    {
        private int r;

        public Kor(int sugar)
        {
            if( sugar < 1)
            {
                r = 1;
            }
            else
            {
                r = sugar;
            }
        }

        private double Kerulet()
        {
            return 2 * r * Math.PI;
        }

        private double Terulet()
        {
            return Math.Pow(r, 2) * Math.PI;
        }

        public void AdatokKiirasa() 
        {
            Console.WriteLine("Sugár: {0}",r);
            Console.WriteLine("Terület: {0}", Terulet());
            Console.WriteLine("Kerület: {0}", Kerulet());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.Write("Kérem az a oldalt: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Kérem a b oldalt: ");
            b = int.Parse(Console.ReadLine());

            Teglalap t = new Teglalap(a, b);

            Console.Write("Írja be a kör sugarát: ");
            int sugar = int.Parse(Console.ReadLine());
            Kor k = new Kor(sugar);

            Console.WriteLine("Téglalap");
            Console.WriteLine("Kerület: {0}", t.Kerulet());
            Console.WriteLine("Terület: {0}", t.Terulet());

            Console.WriteLine("Kör");
            k.AdatokKiirasa();


            Console.ReadKey();
        }
    }
}
