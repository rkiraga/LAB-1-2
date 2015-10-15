using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Osobowka : Pojazd
    {   
        public int liczba_miejsc;

        //public Osobowka()
        //{
        //    model = m;
        //    moc = hp;
        //    przebieg = p;
        //    Console.WriteLine("Podaj liczbe miejsc");
        //    liczba_miejsc = int.Parse(Console.ReadLine());
        //}
        public Osobowka(string m, int hp, int p)
        {
            model = m;
            moc = hp;
            przebieg = p;
            Console.WriteLine("Podaj liczbe miejsc");
            liczba_miejsc = int.Parse(Console.ReadLine());
        }
        public int cegla()
        {
            return (liczba_miejsc * 80) / 4;
        }
        double kilowaty()
        {
            return 0.735 * moc;
        }
    }
}
