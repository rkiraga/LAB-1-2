using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Ciezarowka : Pojazd
    {
        public int ladownosc;

        public Ciezarowka(string m="Star", int hp=150, int p=0, int l=20)
        {
            model = m;
            moc = hp;
            przebieg = p;
            ladownosc = l;
        }
        public Ciezarowka()
        {
            Console.WriteLine("Podaj model");
            model = Console.ReadLine();
            Console.WriteLine("Podaj moc (konie mechaniczne");
            moc = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj przebieg");
            przebieg = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj ladownosc (tony)");
            ladownosc = int.Parse(Console.ReadLine());

        }

        override public void wyswietl_dane()
        {
            Console.WriteLine(model);
            Console.WriteLine(moc);
            Console.WriteLine(przebieg);
            Console.WriteLine(ladownosc);
        }

        public int cegla()  //ile 4kg cegiel mozna zaladowac na ciezarowke
        {
            return (ladownosc * 1000) / 4;
        }

    }
}
