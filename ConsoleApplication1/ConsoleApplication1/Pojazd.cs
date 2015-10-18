using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    abstract class Pojazd : Iauta
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
        public Pojazd() // pusty konstruktor - klasa jest abstrakcyjna
        {
        }

        abstract public void wyswietl_dane();

        //  gdy klasa jest abstrakcyjna - metoda wczytaj i konstruktor nie maja sensu
        
        public double kilowaty()    //funkcja bedzie dziedziczona przez klasy pochodne (i nalezy do intefejsu)
        {
            return 0.735 * moc;
        }
    }
}
