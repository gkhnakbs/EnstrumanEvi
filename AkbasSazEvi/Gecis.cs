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
    public partial class Gecis : Form
    {
        public Gecis()
        {
            InitializeComponent();
        }

        int baslangic = 0;
        private void timer1_Tick(object sender, EventArgs e)

        {
            yuzdeSayici.Text = "%" + baslangic.ToString();
            progressBar1.Value = baslangic;
            baslangic += 1;

            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                progressBar1.Value = 0;

                Login log = new Login();
                log.Show();
                this.Hide();
            }
        }

        private void Gecis_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
