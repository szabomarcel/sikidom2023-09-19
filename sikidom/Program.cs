using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sikidom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Sikidom> sikidom = new List<Sikidom>();
            sikidom.Add(new Negyzet(10));
            sikidom.Add(new Teglalap(4,5));
            sikidom.Add(new Kor(5.67));
            foreach (var item in sikidom)
            {
                Console.WriteLine($"{item.Terulet()} - {item.Kerulet()}");
            }

            Console.ReadLine();
        }
    }
}
