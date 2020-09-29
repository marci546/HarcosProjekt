using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarcosProjekt
{
    class Program
    {    
        static void Main(string[] args)
        {
            List<Harcos> harcosok = new List<Harcos>();
            harcosok.Add(new Harcos("Kása", 1));
            harcosok.Add(new Harcos("Iván", 2));
            harcosok.Add(new Harcos("Dezső", 3));

            StreamReader r = new StreamReader("harcosok 1.csv");
            try
            {
                while (!r.EndOfStream)
                {
                    string[] sor = r.ReadLine().Split(';');
                    harcosok.Add(new Harcos(sor[0], Convert.ToInt32(sor[1])));
                }              
            }
            catch (Exception)
            {

                throw;
            }
            r.Close();
            //foreach (var item in harcosok)
            //{
            //    Console.WriteLine(item + "\n");
            //}

            Console.Write("Adja meg a nevét: ");
            string nev = Console.ReadLine();

            Console.Write("Adja meg a státuszsablont(1/2/3): ");
            int statusz = Convert.ToInt32(Console.ReadLine());

            var a = new Harcos(nev, statusz);
            harcosok.Add(a);

            foreach (var item in harcosok)
            {
                Console.WriteLine(item+"\n");
            }

            for (int i = 0; i < harcosok.Count; i++)
            {
                Console.WriteLine("{0}.{1}", i+1, harcosok[i]);
            }

            //meccs
            char valasztas;
            do
            {
                Console.WriteLine("Válasszn a lehetőségek közül: " +
                    "\ta) Megküzdeni egy harcossal" +
                    "\tb) Gyógyulni" +
                    "\tc) Kilépni");
                valasztas = Convert.ToChar(Console.ReadLine());
                while (valasztas != 'a' && valasztas != 'b' && valasztas != 'c')
                {
                    Console.WriteLine("Válasszn a lehetőségek közül: " +
                    "\ta) Megküzdeni egy harcossal" +
                    "\tb) Gyógyulni" +
                    "\tc) Kilépni");
                    valasztas = Convert.ToChar(Console.ReadLine());

                    

                }
                if (valasztas == 'a')
                {

                }
                else if (valasztas == 'b')
                {

                }
                else
                {
                    Console.WriteLine("Adjon egy másik betűt!");
                }

            } 
            while (valasztas != 'c');

            Console.ReadLine();
        }
    }
}
