using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektc
{
    class Czlowiek:Zwierze
    {
        public int kierunek_x;
        public int kierunek_y;
        
        
        public Czlowiek(int x, int y,char c)
        {
            this.x = x;
            this.y = y;
            this.reprezentacja = c;
        }

        public void Akcja()
        {
            x += kierunek_x;
            y += kierunek_y;

        }

        

    }
}
