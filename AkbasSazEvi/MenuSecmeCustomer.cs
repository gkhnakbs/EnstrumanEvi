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
    public partial class MenuSecmeCustomer : Form
    {
        string username;
        public MenuSecmeCustomer(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void EnsSatinAl_Click(object sender, EventArgs e)
        {
            KullaniciSatinAlma kullaniciSatinAlma = new KullaniciSatinAlma(username);
            this.Hide();
            kullaniciSatinAlma.Show();
        }

        private void altaAlmaButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login loginn = new Login();
            this.Hide();
            loginn.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SifreYenile sifreYenile = new SifreYenile(username, "customer");
            this.Hide();
            sifreYenile.Show();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SatinAlmaGecmisi satinAlmaGecmisi = new SatinAlmaGecmisi(username);
            this.Hide();
            satinAlmaGecmisi.Show();
            
        }
    }
}
