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

        public Osobowka(string m, int hp, int p)
        {
            model = m;
            moc = hp;
            przebieg = p;
            Console.WriteLine("Podaj liczbe miejsc");
            liczba_miejsc = int.Parse(Console.ReadLine());
        }
        public void wczytaj_dane()
        {
            Console.WriteLine("Podaj model");
            model = Console.ReadLine();
            Console.WriteLine("Podaj moc (konie mechaniczne");
            moc = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj przebieg");
            przebieg = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbe miejsc");
            liczba_miejsc = int.Parse(Console.ReadLine());
        }
        override public void wyswietl_dane()
        {
            Console.WriteLine(model);
            Console.WriteLine(moc);
            Console.WriteLine(przebieg);
            Console.WriteLine(liczba_miejsc);
        }
        public int cegla()      //  ile cegiel mozna przewiezc zamiast pasazerow
        {
            return (liczba_miejsc * 80) / 4;
        }

    }
}
