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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Szolgaltatasok_Loaded(object sender, RoutedEventArgs e)
        {
            string connectionString = "SERVER=localhost;DATABASE=elite_decor;UID=root;PASSWORD=;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand("select megnev, leiras, ar from szolgaltatasok", connection);
            connection.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            connection.Close();

            Szolgaltatasok.DataContext = dt;
        }

        private void Ingatlan_menu_Click(object sender, RoutedEventArgs e)
        {
           
                ingatlanok ingatlan = new ingatlanok();
                ingatlan.Show();
                this.Close();

            
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

        private void Idopontfoglalas_menu_Click(object sender, RoutedEventArgs e)
        {
            Idpontfoglalas idopont = new Idpontfoglalas();
            idopont.Show();
            this.Close();
        }

        private void Kereses_menu_Click(object sender, RoutedEventArgs e)
        {
            Kereses kereses = new Kereses();
            kereses.Show();
            this.Close();
        }
    }
}
