using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
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
    /// Логика взаимодействия для User.xaml
    /// </summary>
    public partial class User : Window
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        public User()
        {
            InitializeComponent();
            DataContext = this;
            con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString();


        }


















        private bool VerifyUser(string username, string password)
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "select Status from Users where username='" + username + "' and password='" + password + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                if (Convert.ToBoolean(dr["Status"]) == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


        public bool IsDarkTheme { get; set; }
        private readonly PaletteHelper paletteHelper = new PaletteHelper();






        private void toggleTheme(object sender, RoutedEventArgs e)
        {

            ITheme theme = paletteHelper.GetTheme();

            if (IsDarkTheme = theme.GetBaseTheme() == BaseTheme.Dark)
            {
                IsDarkTheme = false;
                theme.SetBaseTheme(Theme.Light);
            }


            else
            {
                IsDarkTheme = true;
                theme.SetBaseTheme(Theme.Dark);
            }


            paletteHelper.SetTheme(theme);
        }


        private void exitApp(object sender, RoutedEventArgs e)
        {
            Close();
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }


        private void doLogin(object sender, RoutedEventArgs e)
        {






            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
            if (VerifyUser(txtUsername.Text, txtPassword.Password))
            {
                MessageBox.Show("Вход успешно выполнен", "Congrats", MessageBoxButton.OK, MessageBoxImage.Information);
                Profile profile = new Profile();
                profile.Show();
            }
            else
            {
                MessageBox.Show("Неверный Логин или Пароль", "Error", MessageBoxButton.OK, MessageBoxImage.Error);


            }









            //string connectionString = @"Data Source=DESKTOP-ER355JS;Initial Catalog=WPF;Integrated Security=True";
            //SqlConnection connection = new SqlConnection(@connectionString);
            //SqlCommand cmd1;







            //cmd = new SqlCommand("delete tbl_Record where ID=@id", connection);
            //connection.Open();
            ////cmd.Parameters.AddWithValue("@id", id);
            //cmd.ExecuteNonQuery();
            //connection.Close();
            //MessageBox.Show("Record Deleted Successfully!");



            //MessageBox.Show("Please Select Record to Delete");








            //string query = ("INSERT INTO Users (Username, Password) VALUES(@Username, @Password)");
            //SqlCommand command = new SqlCommand(query, connection);
            //command.Parameters.AddWithValue("@Username", txtUsername.Text);
            //command.Parameters.AddWithValue("@Password", txtPassword.Password);
            //try
            //{
            //    connection.Open();
            //    command.ExecuteNonQuery();
            //    Console.WriteLine("Records Inserted Successfully");
            //}
            //catch (SqlException ex)
            //{
            //    Console.WriteLine("Error Generated. Details: " + ex.ToString());
            //}
            //finally
            //{
            //    connection.Close();
            //}


        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-ER355JS;Initial Catalog=WPF;Integrated Security=True";

            using (SqlConnection conn =
          new SqlConnection(connectionString))
            {

                using (SqlCommand cmd =
                    new SqlCommand("UPDATE Users  SET  Username=@Username, Password=@Password  WHERE Id=@Id", conn))
                {
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Password);
                    cmd.Parameters.AddWithValue("@Id", 11);
                    //add whatever parameters you required to update here
                    //int rows = cmd.ExecuteNonQuery();
                    //conn.Close();

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Records Inserted Successfully");
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("Error Generated. Details: " + ex.ToString());
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                MessageBox.Show("Логин или Пароль успешно изменен");
            }

        }
    }
}
