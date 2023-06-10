using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class AnaEkran : Form
    {
        string username = "";

        MySqlConnection baglanti = new MySqlConnection();
        string veritabanistringi = "server=localhost;uid=root;pwd=admin;database=instrumentstore";

        private int Enskey;

        public AnaEkran(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void uyeler()
        {
            baglanti.ConnectionString = veritabanistringi;
            string query = "Select * FROM instrument";
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


        private void EnsGeri_Click(object sender, EventArgs e)
        {
            MenuSecmeAdmin menuSecmeAdmin=new MenuSecmeAdmin(username);
            this.Hide();
            menuSecmeAdmin.Show();
        }

        private void EnsEkle_Click(object sender, EventArgs e)
        {
            if (EnsAdTb.Text.Trim().ToString() != "" && EnsKatCb.SelectedIndex != -1 && EnsMarkaCb.SelectedIndex != -1 && EnsRenkCb.SelectedIndex != -1 && EnsMikTb.Text.Trim().ToString() != "" && EnsUcrTb.Text.Trim().ToString() != "")
            {
                try
                {
                    string insertCommand = "insert into instrument (instrument_name,instrument_brand,instrument_category,instrument_color,instrument_amount,instrument_price) VALUES ('" + EnsAdTb.Text.ToString() + "','" + EnsMarkaCb.SelectedItem.ToString() + "','" + EnsKatCb.SelectedItem.ToString() + "','" + EnsRenkCb.SelectedItem.ToString() + "'," + EnsMikTb.Text.ToString() + "," + EnsUcrTb.Text.ToString() + ")";
                    baglanti.ConnectionString = veritabanistringi;
                    baglanti.Open();
                    MySqlCommand cmd = new MySqlCommand(insertCommand, baglanti);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ekleme basariyla yapildi");
                    baglanti.Close();
                    uyeler();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    baglanti.Close();
                }
            }
            else
            {
                MessageBox.Show("Bos Alanlar var!!!");
            }
        }

        private void EnsSil_Click(object sender, EventArgs e)
        {
            if (EnsAdTb.Text.ToString() == "")
            {
                MessageBox.Show("Silinecek Elemani Seciniz");
            }
            else
            {
                try
                {
                    Enskey = Convert.ToInt32(EnsDataGrid.SelectedRows[0].Cells[0].Value.ToString());
                    string insertCommand = "Delete from instrument where instrument_id=" + Enskey + "";
                    baglanti.ConnectionString = veritabanistringi;
                    baglanti.Open();
                    MySqlCommand cmd = new MySqlCommand(insertCommand, baglanti);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Silme basariyla yapildi");
                    baglanti.Close();
                    uyeler();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
                Enskey = Convert.ToInt32(EnsDataGrid.SelectedRows[0].Cells[0].Value.ToString());
                EnsAdTb.Text = EnsDataGrid.SelectedRows[0].Cells[1].Value.ToString();
                EnsMarkaCb.Text = EnsDataGrid.SelectedRows[0].Cells[2].Value.ToString();
                EnsKatCb.Text = EnsDataGrid.SelectedRows[0].Cells[3].Value.ToString();
                EnsRenkCb.Text = EnsDataGrid.SelectedRows[0].Cells[4].Value.ToString();
                EnsMikTb.Text = EnsDataGrid.SelectedRows[0].Cells[5].Value.ToString();
                EnsUcrTb.Text = EnsDataGrid.SelectedRows[0].Cells[6].Value.ToString();
            }
        }

        private void ClearDataBox()
        {
            EnsAdTb.Clear();
            EnsMikTb.Clear();
            EnsKatCb.SelectedIndex = -1;
            EnsRenkCb.SelectedIndex = -1;
            EnsMarkaCb.SelectedIndex = -1;
            EnsUcrTb.Clear();
        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {
            uyeler();
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
                    EnsSatırSayTb.Text = ((EnsDataGrid.Rows.Count) -1 ).ToString();
                    baglanti.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void EnsDuzenle_Click(object sender, EventArgs e)
        {
            if (EnsAdTb.Text == "")
            {
                MessageBox.Show("Bos Alanlar Var!!!");
            }
            else
            {
                try
                {
                    string insertCommand = "Update instrument SET instrument_name='" + EnsAdTb.Text + "',instrument_brand='" + EnsMarkaCb.SelectedItem.ToString() + "',instrument_category='" + EnsKatCb.SelectedItem.ToString() + "',instrument_color='" + EnsRenkCb.SelectedItem.ToString() + "',instrument_amount=" + EnsMikTb.Text + ",instrument_price=" + EnsUcrTb.Text + " WHERE instrument_id=" + Enskey + ";";
                    baglanti.ConnectionString = veritabanistringi;
                    baglanti.Open();
                    MySqlCommand cmd = new MySqlCommand(insertCommand, baglanti);
                    cmd.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Guncelleme islemi basariyla yapildi.");
                    uyeler();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void altaAlmaButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            panel1.AutoScroll = true;
        }


    }
}
