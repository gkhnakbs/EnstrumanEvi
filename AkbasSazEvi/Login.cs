using MySql.Data.MySqlClient;


namespace AkbasSazEvi
{

    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();

        }



        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text != "" && passwordTextBox.Text != "")
            {
                try
                {
                    MySqlConnection baglanti = new MySqlConnection();
                    string veritabanistringi = "server=localhost;uid=root;pwd=admin;database=instrumentstore";
                    baglanti.ConnectionString = veritabanistringi;
                    baglanti.Open();
                    string sql = "select user_username,user_password from users where user_authority='customer'";
                    int i = 0;
                    MySqlCommand cmd = new MySqlCommand(sql, baglanti);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader.GetString("user_username") == usernameTextBox.Text.Trim() && reader.GetString("user_password") == passwordTextBox.Text.Trim())
                        {
                            i += 1;
                            MessageBox.Show("Giris Basarili");
                            MenuSecmeCustomer menuSecmeCustomer = new MenuSecmeCustomer(usernameTextBox.Text.Trim());
                            this.Hide();
                            menuSecmeCustomer.Show();

                        }
                    }
                    if (i == 0)
                    {
                        MessageBox.Show("Giris Yapilamadi bilgilerde sorun var");
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Hata olustu\n" + ex.Message);

                }
            }
            else
            {
                MessageBox.Show("Eksik Bilgi");
            }
        }

        private void altaAlmaButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void adminLoginButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text != "" && passwordTextBox.Text != "")
            {
                try
                {
                    MySqlConnection baglanti = new MySqlConnection();
                    string veritabanistringi = "server=localhost;uid=root;pwd=admin;database=instrumentstore";
                    baglanti.ConnectionString = veritabanistringi;
                    baglanti.Open();
                    string sql = "select user_username,user_password from users where user_authority='admin'";
                    int i = 0;
                    MySqlCommand cmd = new MySqlCommand(sql, baglanti);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader.GetString("user_username") == usernameTextBox.Text.Trim() && reader.GetString("user_password") == passwordTextBox.Text.Trim())
                        {
                            i += 1;
                            MessageBox.Show("Giris Basarili");
                            MenuSecmeAdmin menuSecmeAdmin = new MenuSecmeAdmin(usernameTextBox.Text.Trim());
                            this.Hide();
                            menuSecmeAdmin.Show();

                        }
                    }
                    if (i == 0)
                    {
                        MessageBox.Show("Giris Yapilamadi bilgilerde sorun var");
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Hata olustu\n" + ex.Message);
                    Console.WriteLine(ex.Message);

                }
            }
            else
            {
                MessageBox.Show("Giris Yapilamadi bilgilerde sorun var");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }
    }
}