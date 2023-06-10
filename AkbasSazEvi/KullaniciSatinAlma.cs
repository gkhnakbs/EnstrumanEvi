using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkbasSazEvi
{
    public partial class KullaniciSatinAlma : Form
    {

        private int Enskey;
        string username = "";

        MySqlConnection baglanti = new MySqlConnection();
        string veritabanistringi = "server=localhost;uid=root;pwd=admin;database=instrumentstore";
        public KullaniciSatinAlma(string username)
        {
            InitializeComponent();
            this.username = username;
        }
        private void KullaniciSatinAlma_Load(object sender, EventArgs e)
        {
            uyeler();
        }
        private void uyeler()
        {
            baglanti.ConnectionString = veritabanistringi;
            string query = "Select * FROM instrument where instrument_amount>0;";
            baglanti.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter(query, baglanti);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            EnsDataGrid.DataSource = ds.Tables[0];
            EnsSatırSayTb.Text = ((EnsDataGrid.Rows.Count) - 1).ToString();
            EnsDataGrid.ClearSelection();
            ClearDataBox();
            baglanti.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void altaAlmaButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void ClearDataBox()
        {
            EnsAdTb.Text = string.Empty;
            EnsMikUD.Value = 0;
            EnsKatCb.SelectedIndex = -1;
            EnsRenkCb.SelectedIndex = -1;
            EnsMarkaCb.SelectedIndex = -1;
            EnsUcrTb.Clear();
        }

        private void yenilebutton_Click(object sender, EventArgs e)
        {
            if (EnsKatFiltreCb.SelectedIndex == -1)
            {
                MessageBox.Show("Herhangi bir kategori secmediniz!");
            }
            else if (EnsKatFiltreCb.SelectedItem.ToString() == "Hepsi")
            {
                uyeler();
            }
            else
            {
                try
                {
                    string filtercommand = "Select * from instrument WHERE instrument_category='" + EnsKatFiltreCb.SelectedItem.ToString() + "'";
                    baglanti.ConnectionString = veritabanistringi;
                    baglanti.Open();
                    MySqlDataAdapter sda = new MySqlDataAdapter(filtercommand, baglanti);
                    MySqlCommandBuilder builder = new MySqlCommandBuilder(sda);
                    var ds = new DataSet();
                    sda.Fill(ds);
                    EnsDataGrid.DataSource = ds.Tables[0];
                    EnsSatırSayTb.Text = ((EnsDataGrid.Rows.Count) - 1).ToString();
                    baglanti.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void EnsGeri_Click(object sender, EventArgs e)
        {
            MenuSecmeCustomer menuSecmeCustomer = new MenuSecmeCustomer(username);
            this.Hide();
            menuSecmeCustomer.Show();
        }

        private void EnsSatinAl_Click(object sender, EventArgs e)
        {
            int EnsAmount = Convert.ToInt32(EnsDataGrid.SelectedRows[0].Cells[5].Value.ToString());
            Enskey = Convert.ToInt32(EnsDataGrid.SelectedRows[0].Cells[0].Value);
            if (Convert.ToInt32(EnsMikUD.Value) <= EnsAmount)
            {
                try
                {
                    int yeniMiktar = EnsAmount - Convert.ToInt32(EnsMikUD.Value);
                    string updateCommand = "Update instrument SET instrument_amount=" + yeniMiktar + " where instrument_id=" + Enskey;
                    baglanti.ConnectionString = veritabanistringi;
                    baglanti.Open();
                    MySqlCommand cmd = new MySqlCommand(updateCommand, baglanti);
                    cmd.ExecuteNonQuery();
                    string insertCommand = "insert into history (history_instrumentName,history_instrumentBrand,history_instrumentCategory,history_instrumentColor,history_instrumentAmount,history_instrumentPrice,history_username) VALUES ('" + EnsAdTb.Text.ToString() + "','" + EnsMarkaCb.SelectedItem.ToString() + "','" + EnsKatCb.SelectedItem.ToString() + "','" + EnsRenkCb.SelectedItem.ToString() + "'," + EnsMikUD.Value.ToString() + "," + EnsUcrTb.Text.ToString() + ",'"+username+"')";
                    MySqlCommand cmdd = new MySqlCommand(insertCommand, baglanti);
                    cmdd.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Başarıyla satın alındı!");
                    uyeler();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Stok adedini aştınız!!");
            }
        }

        private void EnsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (EnsDataGrid.SelectedRows.Count == 1 && Enskey == Convert.ToInt32(EnsDataGrid.SelectedRows[0].Cells[0].Value.ToString()))
            {
                EnsDataGrid.ClearSelection();
                ClearDataBox();
            }
            else
            {
                Enskey = Convert.ToInt32(EnsDataGrid.Rows[0].Cells[0].Value.ToString());
                EnsAdTb.Text = EnsDataGrid.SelectedRows[0].Cells[1].Value.ToString();
                EnsMarkaCb.Text = EnsDataGrid.SelectedRows[0].Cells[2].Value.ToString();
                EnsKatCb.Text = EnsDataGrid.SelectedRows[0].Cells[3].Value.ToString();
                EnsRenkCb.Text = EnsDataGrid.SelectedRows[0].Cells[4].Value.ToString();
                EnsUcrTb.Text = EnsDataGrid.SelectedRows[0].Cells[6].Value.ToString();
            }
        }


    }
}
