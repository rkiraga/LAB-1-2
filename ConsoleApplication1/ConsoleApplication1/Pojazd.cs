using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Pojazd : Iauta
    {
        public string model;
        public int moc;
        protected int przebieg;

        public Pojazd(string m="Fiat_125p", int hp=40, int p=0)
        {
            model = m;
            moc = hp;
            przebieg = p;
        }
        public Pojazd()
        {
        }
        public void wczytaj_dane()
        {
            Console.WriteLine("Podaj model");
            model = Console.ReadLine();
            Console.WriteLine("Podaj moc (konie mechaniczne");
            moc = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj przebieg");
            przebieg = int.Parse(Console.ReadLine());
        }
        public void wyswietl_dane()
        {
            Console.WriteLine(model);
            Console.WriteLine(moc);
            Console.WriteLine(przebieg);
        }
        public double kilowaty()
        {
            return 0.735 * moc;
        }
    }
}
