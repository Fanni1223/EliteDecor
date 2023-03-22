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
    /// Interaction logic for Idpontfoglalas.xaml
    /// </summary>
    public partial class Idpontfoglalas : Window
    {
        public Idpontfoglalas()
        {
            InitializeComponent();
        }

        private void Ingatlan_menu1_Click(object sender, RoutedEventArgs e)
        {

            ingatlanok ingatlan = new ingatlanok();
            ingatlan.Show();
            this.Close();
        }

        private void Szolgaltatasok_menu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow szolgaltatas = new MainWindow();
            szolgaltatas.Show();
            this.Close();
        }

        private void Foglalas_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = "SERVER=localhost;DATABASE=elite_decor;UID=root;PASSWORD=;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand("insert into idopotfoglalas (nev, email, telszam, idopont, id) values('" + nev.Text + "', '" + email.Text + "', '" + telszam.Text + "', '" + idopont.Text + "', '" + megnev.Text + "')", connection);

            connection.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            connection.Close();
        }

        private void megnev_Loaded(object sender, RoutedEventArgs e)
        {
            string connectionString = "SERVER=localhost;DATABASE=elite_decor;UID=root;PASSWORD=;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand("select megnev from szolgaltatasok", connection);
            connection.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            connection.Close();

            ComboBox cmb = sender as ComboBox;
            cmb.ItemsSource = dt.AsEnumerable().Select(r => r.Field<string>("megnev")).ToList();
        }

        private void Kereses_menu_Click(object sender, RoutedEventArgs e)
        {
            Kereses keres = new Kereses();
            keres.Show();
            this.Close();
        }
    }
}
