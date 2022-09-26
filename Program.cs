using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponavljanje5
{
    class GeometrijskiLik
    {
        int BrojStranica;
        private double[] Str = new double[10];

        public int BrojStranica1 { get => BrojStranica; set => BrojStranica = value; }
        public double[] Str1 { get => Str; set => Str = value; }

        public void UcitajStranice(double stranica)
        {
            Str1.Append(stranica);
          
        }
        public double Opseg(double[] str12)
        { double s=0;
           
        for (int i = 0; i < str12.Length; i++)
            {
                s = s + str12[i];
            }
            return s;
        }
    }
    class Trokut : GeometrijskiLik
    {
        int BrojStranica = 3;
    }
    class Cetverokut : GeometrijskiLik
    {
        int BrojStranica = 4;
       
    }
    internal class Program
    {
        /*
         * 2. Definirajte klasu GeometrijskiLik sa sljedećim članicama:
• varijabla tipa int BrojStranica
• niz tipa double veličine 10 Stranice
• metode UcitajStranice() koja će učitati od korisnika stranice geometrijskog lika
Opseg () koja će vratiti opseg geometrijskog lika
Definirajte klase Trokut i Cetverokut izvedene iz klase GeometrijskiLik, te im definirajte
konstruktore u kojima ćete varijabli BrojStranica dodijeliti odgovarajuću vrijednost.
Definirajte dva objekta tipa Trokut i Cetverokut, učitajte duljine stranica, te izračunajte
opsege.

         * */
        static void Main(string[] args)
        {
            Trokut Trokut = new Trokut();
            Cetverokut Cetverokut = new Cetverokut();
            Trokut.UcitajStranice(12.34);
            Cetverokut.UcitajStranice(20.34);
            Trokut.UcitajStranice(22.34);
            Cetverokut.UcitajStranice(12.94);
            Trokut.UcitajStranice(13.34);
            Cetverokut.UcitajStranice(12.34);
            Cetverokut.UcitajStranice(124.34);

            Console.WriteLine(Cetverokut.Opseg(Cetverokut.Str1));
            Console.WriteLine(Trokut.Opseg(Trokut.Str1));
            Console.ReadKey();
        }
    }
}
