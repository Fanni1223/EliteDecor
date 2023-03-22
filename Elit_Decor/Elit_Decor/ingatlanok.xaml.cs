using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Elit_Decor
{
    /// <summary>
    /// Interaction logic for ingatlanok.xaml
    /// </summary>
    public partial class ingatlanok : Window
    {
        public ingatlanok()
        {
            InitializeComponent();
        }

        private void adatok_Loaded(object sender, RoutedEventArgs e)
        {
            string connectionString = "SERVER=localhost;DATABASE=elit_decor;UID=root;PASSWORD=;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand("select leiras,hely,cm2,szobak_szama,tipus,ar from ingatlanok ", connection);
            connection.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            connection.Close();

            adatok.DataContext = dt;
        }

        private void felvezetes_Click(object sender, RoutedEventArgs e)
        {

            string connectionString = "SERVER=localhost;DATABASE=elit_decor;UID=root;PASSWORD=;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand("insert into vetel (nev,email)values('" + nev.Text + "','" + email.Text + "')", connection);
            connection.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            connection.Close();

            adatok.DataContext = dt;
        }
    }
}
