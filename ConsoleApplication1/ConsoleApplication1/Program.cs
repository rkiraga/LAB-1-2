using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("");

            Ciezarowka c1 = new Ciezarowka();
            Console.WriteLine("Ciezarowka {0} moze przewiezc ", c1.model);
            Console.WriteLine(" {0} cegiel", c1.cegla());

            Console.WriteLine("");
            Console.WriteLine("");


            Osobowka o1 = new Osobowka("Astra", 50, 50);
            o1.wyswietl_dane();
            Console.WriteLine("Tylu osobom: {0} odpowiada:", o1.liczba_miejsc);
            Console.WriteLine(  "{0} cegiel", o1.cegla());

            Console.WriteLine("kilowaty astry: ");
            Console.WriteLine(o1.kilowaty());


            Console.ReadLine();
        }
    }
}
