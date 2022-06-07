using WPF_Biblioteka.View;
using System;
using System.Windows;
using System.Windows.Input;
using WPF_Biblioteka.ViewModel;
using System.Diagnostics;
using WPF_Biblioteka.СС;
using WPF_Biblioteka.AppCode;
using System.Windows.Threading;

namespace WPF_Biblioteka
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int cType;

        public object Track_One { get; internal set; }
        public object SubmenuOne_UC { get; internal set; }

        public MainWindow()
        {
            AppCursor.GetInstance();
            Timer.GetInstance();
            this.Cursor = AppCursor.GetCursor();


       



            InitializeComponent();  
            Page1 x = new Page1();
            Main.NavigationService.Navigate(x);
            //Main.Content = new Book();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();

        }
        void timer_Tick(object sender, EventArgs e)
        {
            if (cType != AppCursor.CCursor)
            {
                this.Cursor = AppCursor.GetCursor();
                cType = AppCursor.CCursor;
            }
        }



        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
          
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();



        }

        private void ChangeWindowState()
        {
            if (WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
                Window_Edge.Visibility = Visibility.Collapsed;
            }
            else
            {
                if (WindowState == WindowState.Maximized) 
                {
                    this.WindowState = WindowState.Normal;
                    Window_Edge.Visibility = Visibility.Visible;

                }
            }
        }

        private void Main_Window_Panel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left && e.ClickCount == 2)
            {
                ChangeWindowState();
            }

            //// Close All Open Menu Panels on Mouse Button Click
            //if (e.ChangedButton == MouseButton.Left && e.ClickCount == 1)
            //{
            //    //// Access the SubmenuOne UserControl Account Btn and Unselect it. 
            //    //if (Application.Current.MainWindow is MainWindow MW)
            //    //{
            //    //    MW.SubmenuOne_UC.account_btn.IsSelected = false;
            //    //}

            //    //// Access the MainMenu UserControl Menu Toggle Btn and Uncheck it. 
            //    //if (Application.Current.MainWindow is MainWindow MW1)
            //    //{
            //    //    MW1.MainMenu_UC.Menu_ToggleButton.IsChecked = false;
            //    //}

            //    //// Access the SidePanel UserControl Mail Btn and Unselect it. 
            //    //if (Application.Current.MainWindow is MainWindow MW2)
            //    //{
            //    //    MW2.MainMenu_UC.SidePanel_UC.mail_sidepanel_listboxitem.IsSelected = false;
            //    //}

            //}
        }

        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Polygon_MouseDown(object sender, MouseButtonEventArgs e)
        {
        }

        private void minimizeButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void maximizeButton_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
                WindowState = WindowState.Maximized;
            else
                WindowState = WindowState.Normal;

        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
          

        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            Autorize autorize = new Autorize();
            autorize.Show();



        }  

        
        
        private void Button_Click_Books(object sender, RoutedEventArgs e)
        {
            Main.Content = new Book();

        }

        private void Button_Click_Audio(object sender, RoutedEventArgs e)
        {
            Audio_Book audio_Book = new Audio_Book();
            audio_Book.Show();

        }
        private void Button_Clicked(object sender, RoutedEventArgs e)
        {
            Main.Content = new CursorViewModel();

        }

        private void minimizeButton_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

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

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            Page1 x = new Page1();
            Main.NavigationService.Navigate(x);

        }

        private void Novinki_Click(object sender, RoutedEventArgs e)
        {
            Novinki x = new Novinki();
            Main.NavigationService.Navigate(x);
        }


        //private void ComboBox_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    var tb = (TextBox)e.OriginalSource;
        //    if (tb.SelectionStart != 0)
        //    {
        //        CB.SelectedItem = null; // Если набирается текст сбросить выбраный элемент
        //    }
        //    if (tb.SelectionStart == 0 && CB.SelectedItem == null)
        //    {
        //        CB.IsDropDownOpen = false; // Если сбросили текст и элемент не выбран, сбросить фокус выпадающего списка
        //    }

        //    CB.IsDropDownOpen = true;
        //    if (CB.SelectedItem == null)
        //    {
        //        // Если элемент не выбран менять фильтр
        //        CollectionView cv = (CollectionView)CollectionViewSource.GetDefaultView(CB.ItemsSource);
        //        cv.Filter = s => ((string)s).IndexOf(CB.Text, StringComparison.CurrentCultureIgnoreCase) >= 0;
        //    }
        //}
    }
}
