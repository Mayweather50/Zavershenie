using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WPF_Biblioteka.СС
{
    /// <summary>
    /// Логика взаимодействия для Novinki.xaml
    /// </summary>
    public partial class Novinki : Page
    {
        public Novinki()
        {
            InitializeComponent();
        }
        private void Button_Sapiens(object sender, RoutedEventArgs e)
        {
            Process.Start("C:/Users/myrta/Downloads/C_4_0_polnoe_rukovodstvo_Shildt_Gerbert.pdf");


        }
        private void Button_Fahrenheit(object sender, RoutedEventArgs e)
        {
            Process.Start("C:/Users/myrta/Downloads/C_4_0_polnoe_rukovodstvo_Shildt_Gerbert.pdf");


        }

        private void Button_Beda(object sender, RoutedEventArgs e)
        {
            Process.Start("C:/Users/myrta/Downloads/C_4_0_polnoe_rukovodstvo_Shildt_Gerbert.pdf");


        }
    }
}
