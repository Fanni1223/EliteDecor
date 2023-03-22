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
    /// Interaction logic for Kereses.xaml
    /// </summary>
    public partial class Kereses : Window
    {
        public Kereses()
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

        private void Idopontfoglalas_menu_Click(object sender, RoutedEventArgs e)
        {
          Idpontfoglalas idopont = new Idpontfoglalas();
            idopont.Show();
            this.Close();
        }

        private void Kereses_gomb_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = "SERVER=localhost;DATABASE=elite_decor;UID=root;PASSWORD=;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            string megnev_kereses = "";
            if (kereses_tipus.Text != "")
            {
                megnev_kereses = kereses_tipus.Text;
            }
            MySqlCommand cmd = new MySqlCommand($"SELECT `ar`, `leiras`, `hely`, `cm2`, `szobak_szama`, `tipus` FROM `ingatlanok`  WHERE `tipus` LIKE'%{megnev_kereses}%'", connection);
            connection.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            connection.Close();
            Kereses_eredmeny.DataContext = dt;
        }

        private void kereses_tipus_Loaded(object sender, RoutedEventArgs e)
        {
            string connectionString = "SERVER=localhost;DATABASE=elite_decor;UID=root;PASSWORD=;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand("select tipus from ingatlanok", connection);
            connection.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            connection.Close();

            ComboBox cmb = sender as ComboBox;
            cmb.ItemsSource = dt.AsEnumerable().Select(r => r.Field<string>("tipus")).ToList();
        }
    }
}
