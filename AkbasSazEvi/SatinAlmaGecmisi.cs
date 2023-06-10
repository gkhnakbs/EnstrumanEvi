using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkbasSazEvi
{
    public partial class SatinAlmaGecmisi : Form
    {
        string username;

        MySqlConnection baglanti = new MySqlConnection();
        string veritabanistringi = "server=localhost;uid=root;pwd=admin;database=instrumentstore";
        public SatinAlmaGecmisi(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            MenuSecmeCustomer menuSecmeCustomer = new MenuSecmeCustomer(username);
            this.Close();
            menuSecmeCustomer.Show();
        }
        private void uyeler()
        {
            baglanti.ConnectionString = veritabanistringi;
            string query = "Select * FROM history where history_username='" + username + "'";
            baglanti.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter(query, baglanti);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        private void altaAlmaButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SatinAlmaGecmisi_Load(object sender, EventArgs e)
        {
            uyeler();
        }
    }
}
