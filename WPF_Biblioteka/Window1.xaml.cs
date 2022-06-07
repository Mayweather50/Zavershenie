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
using System.Windows.Shapes;

namespace WPF_Biblioteka
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public List<User> user = new List<User>();
        public void LoadUser(List<User> _user)
        {
            userList.Items.Clear(); // очищаем лист с элементами

            for (int i = 0; i < _user.Count; i++) // перебираем элементы
            {
                userList.Items.Add(_user[i]); // добавляем элементы в ListBox
            }
        }

        public Window1()
        {
            InitializeComponent();


            // Добавляем данные
            user.Add(new User("Достоевский.", "27.04.1996",  "Преступление и наказание"));
            user.Add(new User("Стивен Кинг", "25.02.1998", "Институт"));
            user.Add(new User("Кучукбаева Л.А.", "18.02.1999", "F"));
            user.Add(new User("Белов А.В.", "25.02.1997",  "M"));
            user.Add(new User("Хоробрых Г.Д.", "25.02.1996",  "M"));
            user.Add(new User("Юкович Н.Т.", "25.02.1995",  "M"));
            user.Add(new User("Власов А.А.", "25.02.1994",  "M"));
            user.Add(new User("Теплоухов Н.С.", "25.02.1993",  "M"));
            LoadUser(user); // выводим данные на экран
        }

        private void ActiveFilter(object sender, RoutedEventArgs e)
        {
            List<User> newUsers = new List<User>();
            newUsers = user;

            if (genderFilter.SelectedIndex == 0)
                newUsers = user.FindAll(x => x.book == "Преступление и наказание");

            else
                newUsers = user.FindAll(x => x.book == "Институт");

            newUsers = newUsers.FindAll(x => x.name.Contains(nameFilter.Text));

            LoadUser(newUsers);
        }


        private void MaxBtn_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
            {
                WindowState = WindowState.Maximized;
            }
            else
            {
                if (WindowState == WindowState.Maximized)
                {
                    WindowState = WindowState.Normal;
                }
            }
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        } 
        
        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }








        public class User
        {
            public string name { get; set; }
            public string dataOfBirth { get; set; }
            public string book { get; set; }

            public User(string _name, string _dataOfBirth,  string _book)
            {
                this.name = _name;
                this.dataOfBirth = _dataOfBirth;
                this.book = _book;
            }

          





        }

    }
}
