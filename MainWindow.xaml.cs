using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace projektc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Button[,] guziczki = new Button[20, 20];
            
        public MainWindow()
        {
            InitializeComponent();
            
           for(int i=0; i<20; i++)
           {
               for(int j=0; j<20; j++)
               {
                   guziczki[i, j] = new Button();
                   Thickness margin = guziczki[i, j].Margin;
                   margin.Left = j * 42 -480;
                   margin.Top = i * 42 - 480;
                   guziczki[i, j].Height = 20;
                   guziczki[i, j].Width = 20;
                   guziczki[i, j].Margin = margin;
                   this.grid.Children.Add(guziczki[i,j]);
               }
           }
            Swiat swiatJeden = new Swiat(guziczki);
            swiatJeden.DodajOrganizm(new Czlowiek(10, 10,'C'));
            swiatJeden.RysujSwiat();
           
        }
    }
}
