using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WPF_Biblioteka.AppCode;

namespace WPF_Biblioteka.View
{
    /// <summary>
    /// Логика взаимодействия для HomeView.xaml
    /// </summary>
    /// 

    public partial class HomeView : UserControl
    {
      
        public HomeView()
        {
            InitializeComponent();
            AppCursor.GetInstance();
            this.Cursor = AppCursor.GetCursor();
        }




        private void Cursor_Click(object sender, RoutedEventArgs e)
        {
            AppCursor.CCursor = 3;
            this.Cursor = AppCursor.GetCursor();
        }

        private void Fire_Click(object sender, RoutedEventArgs e)
        {
            AppCursor.CCursor = 1;
          this.Cursor = AppCursor.GetCursor();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            AppCursor.CCursor = 2;
            this.Cursor = AppCursor.GetCursor();
        }
    }
}
