using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;

namespace P20251212
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public string felhasznalo = "";
        public string jelszo = "";
        public string jelszo2 = "";
        public Window2()
        {
            InitializeComponent();
        }

        private void btnIn_Click(object sender, RoutedEventArgs e)
        {
            felhasznalo = fNev.Text;
            jelszo = fPass.Password;
            jelszo2 = fPass2.Password;
            FileStream f = new FileStream("adat.txt", FileMode.Create);
            StreamWriter iras = new StreamWriter(f);
            iras.WriteLine(felhasznalo);
            iras.WriteLine(jelszo);
            iras.WriteLine(jelszo2);
            iras.Close();
            f.Close();
        }
    }
}
