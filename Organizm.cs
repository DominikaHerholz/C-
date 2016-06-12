using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektc
{
    class Organizm
    {
        public int sila;
        public int inicjatywa;
        public int x, y;
        public char reprezentacja;
        public Swiat swiat; //enkapsulacja,typ, nazwa zmiennej

        public Organizm(){}

        public Organizm(int sila, int inicjatywa, int x, int y) 
        {
            this.sila = sila;
            this.inicjatywa = inicjatywa;
            this.x = x;
            this.y = y;

        } 

        public void Akcja()
        { 
        

        }

        public void Kolizja(Organizm drugi)
        {
            if (drugi.sila<=this.sila)
            {
                drugi = null;
            }

        }

        public void Rysowanie()
        {


        }



    }
}
