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
    public partial class MenuSecmeAdmin : Form
    {
        string username;
        public MenuSecmeAdmin(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void altaAlmaButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            panel1.AutoScroll = true;
        }

        private void sifreYenile_Click(object sender, EventArgs e)
        {
            SifreYenile sifreYenile = new SifreYenile(username, "admin");
            sifreYenile.Show();
            this.Hide();
        }

        private void enstrumanYonetim_Click(object sender, EventArgs e)
        {
            AnaEkran anaEkran = new AnaEkran(username);
            anaEkran.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
