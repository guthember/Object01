using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object01
{
    class Ember
    {
        public string nev;
        public int eletkor;

        public string Bemutatkozas()
        {
            return $"{nev} vagyok {eletkor} éves.";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ember pisti = new Ember();
            Ember eva = new Ember();

            eva.nev = "Nagy Éva";
            eva.eletkor = 18;

            pisti.nev = "Nagy Pisti";
            pisti.eletkor = 20;

            Console.WriteLine(pisti.Bemutatkozas());
            Console.WriteLine(eva.Bemutatkozas());

            Console.ReadKey();
        }
    }
}
