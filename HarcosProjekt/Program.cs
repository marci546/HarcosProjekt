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
            foreach (var item in harcosok)
            {
                Console.WriteLine(item);
            }
            
            
            Console.ReadLine();
        }
    }
}
