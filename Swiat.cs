using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace projektc
{
    class Swiat
    {
        private List<Organizm> organizmy;
        private Button[,] plansza;

        public Swiat()
        {

        }

        public Swiat(Button[,] buttons)
        {
            plansza = buttons;
            organizmy = new List<Organizm>();
        }
            //metody
        public void DodajOrganizm(Organizm organizm)
        {
            organizmy.Add(organizm);
        }

        public void WykonajTure()
        {
            foreach (var organizm in organizmy)
            {
                organizm.Akcja();
            }
        }

        public void RysujSwiat()
        {
            foreach(var organizm in organizmy)
            {
                plansza[organizm.x, organizm.y].Content = organizm.reprezentacja;
            }
        }

       
    }
}
