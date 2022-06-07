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

namespace WPF_Biblioteka
{
    /// <summary>
    /// Логика взаимодействия для Book.xaml
    /// </summary>
    public partial class Book : Page
    {
        public Book()
        {
            InitializeComponent();
        }


        private void Button_vremeni(object sender, RoutedEventArgs e)
        {
            Process.Start("C:/Users/myrta/Downloads/stiven_uilyam_hoking_kratchajsha_1.pdf");


        }   
        
        
        
        private void Button_Kvantovie_miri(object sender, RoutedEventArgs e)
        {
            Process.Start("C:/Users/myrta/Downloads/C_4_0_polnoe_rukovodstvo_Shildt_Gerbert.pdf");


        }      
        
        
        private void Button_Astrofizika(object sender, RoutedEventArgs e)
        {
            Process.Start("C:/Users/myrta/Downloads/nil_degrass_tajson_astrofizika_s.pdf");


        }   
        
        
        
        
        private void Button_Stiven_hoking(object sender, RoutedEventArgs e)
        {
            Process.Start("C:/Users/myrta/Downloads/stiven_uilyam_hoking-kratkaya_istoriya_vremeni-1489046677.pdf");


        }
          
        
        private void Button_Gen(object sender, RoutedEventArgs e)
        {
            Process.Start("C:/Users/myrta/Downloads/klinton_richard_dokinz-egoistichnij_gen-1489167316.pdf");


        }  
        
        
        private void Button_Raduga(object sender, RoutedEventArgs e)
        {
            Process.Start("C:/Users/myrta/Downloads/fenni_flegg-stoya_pod_radugoj-1490550761.pdf");


        }






        private void Button_Dostoevsky(object sender, RoutedEventArgs e)
        {
            Process.Start("C:/Users/myrta/Downloads/fedor_mihajlovich_dostoevskij_pr.pdf");


        }

        private void Button_Zhivie(object sender, RoutedEventArgs e)
        {
            Process.Start("C:/Users/myrta/Downloads/varvara_nikolaevna_enal-mi_ostaemsya_svobodnimi-1497283941.pdf");


        }   
        
        
        private void Button_Instityt(object sender, RoutedEventArgs e)
        {
            Process.Start("C:/Users/myrta/Downloads/stiven_king-institut-5e1ec6dd669a3.pdf");


        } 
        
        
        
        
        private void Button_Zhakomin(object sender, RoutedEventArgs e)
        {
            Process.Start("C:/Users/myrta/Downloads/C_4_0_polnoe_rukovodstvo_Shildt_Gerbert.pdf");


        }
    }
}
