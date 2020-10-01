using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlagszamitos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg az évvégi eredményeidet!");
            Console.Write("Magyar: ");
            int magyar = int.Parse(Console.ReadLine());
            Console.Write("Matek: ");
            int matek = int.Parse(Console.ReadLine());
            Console.Write("Töri: ");
            int tori = int.Parse(Console.ReadLine());
            Console.Write("Programozás: ");
            int prog = int.Parse(Console.ReadLine());
            Console.Write("Tesi: ");
            int tesi = int.Parse(Console.ReadLine());

            if (magyar < 1 || magyar > 5 ||
                matek < 1 || matek > 5 ||
                tori < 1 || tori > 5 ||
                prog < 1 || prog > 5 ||
                tesi < 1 || tori > 5)
            {
                Console.WriteLine("Hibás adatot adtál meg!");
            }
            else
            {
                double atlag = (magyar + matek + tori + prog + tesi) / 5.0;
                Console.WriteLine("Az átlagod: " + atlag);
            }
            Console.ReadKey();
        }
    }
}
