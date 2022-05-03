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

namespace OOP_nakladak
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        nakladak jedna;
        nakladak dva;

        public MainWindow()
        {
            InitializeComponent();

            jedna = new nakladak();
            jedna.Name = "jedna";

            dva = new nakladak();
            dva.Name = "dva";
        }

        public void Zobraz(nakladak jedna, TextBox textBox)
        {
            nakladakjedna.Text = jedna.Name + "\n";
            nakladakjedna.Text += "Nosnot: " + jedna.Nosnost.ToString() + "\n";
            nakladakjedna.Text += "Naklad: " + jedna.Naklad.ToString() + "\n";
            nakladakjedna.Text += "Objemnadrze" + jedna.Objemnadrze.ToString() + "\n";
            nakladakjedna.Text += "Spotrebapaliva" + jedna.Spotrebapaliva.ToString() + "\n";
            nakladakjedna.Text += "Celkovavzdalenost" + jedna.Celkovavzdalenost.ToString() + "\n";
        }
        public void Zobraz(nakladak dva, TextBox textBox)
        {
            nakladakdva.Text = dva.Name + "\n";
            nakladakdva.Text += "Nosnot: " + dva.Nosnost.ToString() + "\n";
            nakladakdva.Text += "Naklad: " + dva.Naklad.ToString() + "\n";
            nakladakdva.Text += "Objemnadrze" + dva.Objemnadrze.ToString() + "\n";
            nakladakdva.Text += "Spotrebapaliva" + dva.Spotrebapaliva.ToString() + "\n";
            nakladakdva.Text += "Celkovavzdalenost" + dva.Celkovavzdalenost.ToString() + "\n";
        }

        private void Button
    }
}
