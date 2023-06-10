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
    public partial class SignUp : Form

    {
        MySqlConnection baglanti = new MySqlConnection();
        string veritabanistringi = "server=localhost;uid=root;pwd=admin;database=instrumentstore";
        public SignUp()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void altaAlmaButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void geriButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "" && surnameTextBox.Text != "" && usernameTextBox.Text != "" && passwordTextBox.Text != "")
            {
                try
                {
                    string insertCommand = "insert into users (user_name,user_surname,user_username,user_password,user_authority) VALUES ('" + nameTextBox.Text.ToString() + "','" + surnameTextBox.Text.ToString() + "','" + usernameTextBox.Text.ToString() + "','" + passwordTextBox.Text.ToString() + "','customer' )";
                    baglanti.ConnectionString = veritabanistringi;
                    baglanti.Open();
                    MySqlCommand cmd = new MySqlCommand(insertCommand, baglanti);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kayit basariyla yapildi");
                    baglanti.Close();
                    Login login1 = new Login();
                    login1.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    baglanti.Close();
                }

            }
            else
            {
                MessageBox.Show("Bos Alanlar Var!!!");
            }
        }
    }
}
