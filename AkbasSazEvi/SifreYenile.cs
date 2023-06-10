using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkbasSazEvi
{
    public partial class SifreYenile : Form
    {
        string username, userPassword, authority;

        MySqlConnection baglanti = new MySqlConnection();
        string veritabanistringi = "server=localhost;uid=root;pwd=admin;database=instrumentstore";
        public SifreYenile(string username, string authority)
        {
            InitializeComponent();
            this.username = username;
            this.authority = authority;
        }

        private void SifreYenile_Load(object sender, EventArgs e)
        {
            label2.Text = username + " için Şifre Yenileme Ekranı ";
            string selectCommand = "select user_password from users where user_username='" + username + "'";
            baglanti.ConnectionString = veritabanistringi;
            baglanti.Open();
            MySqlCommand cmd = new MySqlCommand(selectCommand, baglanti);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                userPassword = reader.GetString(0);
            }

            baglanti.Close();
            
        }

        private void onayla_Click(object sender, EventArgs e)
        {
            if (eskiSifre.Text.Trim().Equals(userPassword))
            {
                string selectCommand = "update users SET user_password='" + yeniSifre.Text.Trim().ToString() + "' where user_username='" + username + "'";
                baglanti.ConnectionString = veritabanistringi;
                baglanti.Open();
                MySqlCommand cmd = new MySqlCommand(selectCommand, baglanti);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Şifre Başarıyla Değiştirildi!");
                gerigitme();
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Eski sifreniz uyusmuyor!!");
            }
        }
        public void gerigitme()
        {
            if (authority.Equals("customer"))
            {
                MenuSecmeCustomer menuSecmeCustomer = new MenuSecmeCustomer(username);
                menuSecmeCustomer.Show();
                this.Close();
            }
            else
            {
                MenuSecmeAdmin menuSecmeAdmin = new MenuSecmeAdmin(username);
                menuSecmeAdmin.Show();
                this.Close();
            }

        }
        private void geri_Click(object sender, EventArgs e)
        {
            gerigitme();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void altaAlmaButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
