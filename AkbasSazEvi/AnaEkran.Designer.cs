namespace AkbasSazEvi
{
    partial class AnaEkran
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            altaAlmaButton = new Button();
            button3 = new Button();
            label5 = new Label();
            label1 = new Label();
            EnsKatCb = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            EnsEkle = new Button();
            EnsDuzenle = new Button();
            EnsSil = new Button();
            EnsGeri = new Button();
            label11 = new Label();
            EnsAdTb = new TextBox();
            label12 = new Label();
            label14 = new Label();
            ID = new DataGridViewTextBoxColumn();
            EnsDataGrid = new DataGridView();
            EnsUcrTb = new TextBox();
            label7 = new Label();
            yenilebutton = new Button();
            label8 = new Label();
            EnsMarkaCb = new ComboBox();
            EnsMikIsim = new Label();
            EnsMikTb = new TextBox();
            label2 = new Label();
            label9 = new Label();
            EnsRenkCb = new ComboBox();
            EnsKatFiltreCb = new ComboBox();
            label6 = new Label();
            EnsSatırSayTb = new TextBox();
            label10 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EnsDataGrid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AllowDrop = true;
            panel1.AutoSize = true;
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(altaAlmaButton);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1134, 87);
            panel1.TabIndex = 17;
            // 
            // altaAlmaButton
            // 
            altaAlmaButton.AutoSize = true;
            altaAlmaButton.FlatStyle = FlatStyle.Flat;
            altaAlmaButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            altaAlmaButton.ForeColor = SystemColors.ActiveCaption;
            altaAlmaButton.Location = new Point(1032, 0);
            altaAlmaButton.Name = "altaAlmaButton";
            altaAlmaButton.Size = new Size(46, 44);
            altaAlmaButton.TabIndex = 18;
            altaAlmaButton.Text = "__";
            altaAlmaButton.UseVisualStyleBackColor = true;
            altaAlmaButton.Click += altaAlmaButton_Click;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ActiveCaption;
            button3.Location = new Point(1080, 0);
            button3.Name = "button3";
            button3.Size = new Size(51, 44);
            button3.TabIndex = 17;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.Black;
            label5.Font = new Font("Consolas", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaption;
            label5.Location = new Point(368, 12);
            label5.Name = "label5";
            label5.Size = new Size(453, 75);
            label5.TabIndex = 15;
            label5.Text = "Enstruman Evi";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(28, 189);
            label1.Name = "label1";
            label1.Size = new Size(139, 28);
            label1.TabIndex = 19;
            label1.Text = "Enstrüman Adı";
            // 
            // EnsKatCb
            // 
            EnsKatCb.FormattingEnabled = true;
            EnsKatCb.Items.AddRange(new object[] { "Akustik Gitar", "Elektro Gitar", "Bağlama", "Keman", "Klarnet", "Piano", "Yan Flüt" });
            EnsKatCb.Location = new Point(33, 306);
            EnsKatCb.Name = "EnsKatCb";
            EnsKatCb.Size = new Size(151, 28);
            EnsKatCb.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(28, 272);
            label3.Name = "label3";
            label3.Size = new Size(87, 28);
            label3.TabIndex = 28;
            label3.Text = "Kategori";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(239, 349);
            label4.Name = "label4";
            label4.Size = new Size(59, 28);
            label4.TabIndex = 29;
            label4.Text = "Ücret";
            // 
            // EnsEkle
            // 
            EnsEkle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EnsEkle.Location = new Point(30, 453);
            EnsEkle.Name = "EnsEkle";
            EnsEkle.Size = new Size(90, 37);
            EnsEkle.TabIndex = 32;
            EnsEkle.Text = "Ekle";
            EnsEkle.UseVisualStyleBackColor = true;
            EnsEkle.Click += EnsEkle_Click;
            // 
            // EnsDuzenle
            // 
            EnsDuzenle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EnsDuzenle.Location = new Point(160, 453);
            EnsDuzenle.Name = "EnsDuzenle";
            EnsDuzenle.Size = new Size(120, 37);
            EnsDuzenle.TabIndex = 33;
            EnsDuzenle.Text = "Güncelle";
            EnsDuzenle.UseVisualStyleBackColor = true;
            EnsDuzenle.Click += EnsDuzenle_Click;
            // 
            // EnsSil
            // 
            EnsSil.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EnsSil.Location = new Point(317, 453);
            EnsSil.Name = "EnsSil";
            EnsSil.Size = new Size(87, 37);
            EnsSil.TabIndex = 34;
            EnsSil.Text = "Sil";
            EnsSil.UseVisualStyleBackColor = true;
            EnsSil.Click += EnsSil_Click;
            // 
            // EnsGeri
            // 
            EnsGeri.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EnsGeri.Location = new Point(170, 524);
            EnsGeri.Name = "EnsGeri";
            EnsGeri.Size = new Size(87, 37);
            EnsGeri.TabIndex = 35;
            EnsGeri.Text = "Geri";
            EnsGeri.UseVisualStyleBackColor = true;
            EnsGeri.Click += EnsGeri_Click;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label11.Location = new Point(91, 111);
            label11.Name = "label11";
            label11.Size = new Size(253, 44);
            label11.TabIndex = 41;
            label11.Text = "Enstrüman Yönetimi";
            // 
            // EnsAdTb
            // 
            EnsAdTb.BackColor = SystemColors.Control;
            EnsAdTb.BorderStyle = BorderStyle.None;
            EnsAdTb.Location = new Point(33, 226);
            EnsAdTb.Name = "EnsAdTb";
            EnsAdTb.Size = new Size(162, 20);
            EnsAdTb.TabIndex = 42;
            // 
            // label12
            // 
            label12.BackColor = Color.DarkGray;
            label12.Location = new Point(32, 249);
            label12.Name = "label12";
            label12.Size = new Size(160, 3);
            label12.TabIndex = 43;
            // 
            // label14
            // 
            label14.BackColor = Color.DarkGray;
            label14.Location = new Point(243, 408);
            label14.Name = "label14";
            label14.Size = new Size(160, 3);
            label14.TabIndex = 45;
            // 
            // ID
            // 
            ID.HeaderText = "Column1";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 125;
            // 
            // EnsDataGrid
            // 
            EnsDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            EnsDataGrid.BackgroundColor = SystemColors.Control;
            EnsDataGrid.BorderStyle = BorderStyle.None;
            EnsDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            EnsDataGrid.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Moccasin;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            EnsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            EnsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EnsDataGrid.EnableHeadersVisualStyles = false;
            EnsDataGrid.Location = new Point(438, 204);
            EnsDataGrid.MultiSelect = false;
            EnsDataGrid.Name = "EnsDataGrid";
            EnsDataGrid.ReadOnly = true;
            EnsDataGrid.RowHeadersWidth = 51;
            EnsDataGrid.RowTemplate.Height = 29;
            EnsDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            EnsDataGrid.Size = new Size(679, 337);
            EnsDataGrid.TabIndex = 46;
            EnsDataGrid.CellContentClick += EnsDataGrid_CellContentClick;
            // 
            // EnsUcrTb
            // 
            EnsUcrTb.BackColor = SystemColors.Control;
            EnsUcrTb.BorderStyle = BorderStyle.None;
            EnsUcrTb.Location = new Point(243, 385);
            EnsUcrTb.Name = "EnsUcrTb";
            EnsUcrTb.Size = new Size(160, 20);
            EnsUcrTb.TabIndex = 47;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(692, 111);
            label7.Name = "label7";
            label7.Size = new Size(151, 28);
            label7.TabIndex = 48;
            label7.Text = "Kategori Filtrele";
            // 
            // yenilebutton
            // 
            yenilebutton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            yenilebutton.Location = new Point(891, 141);
            yenilebutton.Name = "yenilebutton";
            yenilebutton.Size = new Size(94, 37);
            yenilebutton.TabIndex = 51;
            yenilebutton.Text = "Yenile";
            yenilebutton.UseVisualStyleBackColor = true;
            yenilebutton.Click += yenilebutton_Click;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(239, 189);
            label8.Name = "label8";
            label8.Size = new Size(67, 28);
            label8.TabIndex = 53;
            label8.Text = "Marka";
            // 
            // EnsMarkaCb
            // 
            EnsMarkaCb.FormattingEnabled = true;
            EnsMarkaCb.Items.AddRange(new object[] { "Fender", "Yamaha", "Cort", "Casio", "Cremonia", "Ibanez", "Bağlama", "Gibson", "Godin", "Kawai", "Steinway", "Nuvo", "Amati", "Rösler", "Dominguez" });
            EnsMarkaCb.Location = new Point(243, 226);
            EnsMarkaCb.Name = "EnsMarkaCb";
            EnsMarkaCb.Size = new Size(151, 28);
            EnsMarkaCb.TabIndex = 52;
            // 
            // EnsMikIsim
            // 
            EnsMikIsim.AutoSize = true;
            EnsMikIsim.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EnsMikIsim.Location = new Point(28, 349);
            EnsMikIsim.Name = "EnsMikIsim";
            EnsMikIsim.Size = new Size(69, 28);
            EnsMikIsim.TabIndex = 55;
            EnsMikIsim.Text = "Miktar";
            // 
            // EnsMikTb
            // 
            EnsMikTb.BackColor = SystemColors.Control;
            EnsMikTb.BorderStyle = BorderStyle.None;
            EnsMikTb.Location = new Point(33, 380);
            EnsMikTb.Name = "EnsMikTb";
            EnsMikTb.Size = new Size(160, 20);
            EnsMikTb.TabIndex = 57;
            // 
            // label2
            // 
            label2.BackColor = Color.DarkGray;
            label2.Location = new Point(33, 403);
            label2.Name = "label2";
            label2.Size = new Size(160, 3);
            label2.TabIndex = 56;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(241, 269);
            label9.Name = "label9";
            label9.Size = new Size(67, 28);
            label9.TabIndex = 59;
            label9.Text = "Renk";
            // 
            // EnsRenkCb
            // 
            EnsRenkCb.FormattingEnabled = true;
            EnsRenkCb.Items.AddRange(new object[] { "Siyah", "Beyaz", "Mavi", "Kırmızı", "Turuncu", "Turkuaz", "Kahverengi", "Sarı", "Mor", "Yeşil", "Gri", "Metalik Gri" });
            EnsRenkCb.Location = new Point(243, 305);
            EnsRenkCb.Name = "EnsRenkCb";
            EnsRenkCb.Size = new Size(151, 28);
            EnsRenkCb.TabIndex = 58;
            // 
            // EnsKatFiltreCb
            // 
            EnsKatFiltreCb.FormattingEnabled = true;
            EnsKatFiltreCb.Items.AddRange(new object[] { "Hepsi", "Akustik Gitar", "Elektro Gitar", "Bağlama", "Keman", "Klarnet", "Piano", "Yan Flüt" });
            EnsKatFiltreCb.Location = new Point(692, 149);
            EnsKatFiltreCb.Name = "EnsKatFiltreCb";
            EnsKatFiltreCb.Size = new Size(170, 28);
            EnsKatFiltreCb.TabIndex = 60;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(438, 544);
            label6.Name = "label6";
            label6.Size = new Size(106, 28);
            label6.TabIndex = 61;
            label6.Text = "Satır Sayısı";
            // 
            // EnsSatırSayTb
            // 
            EnsSatırSayTb.BackColor = SystemColors.Control;
            EnsSatırSayTb.BorderStyle = BorderStyle.None;
            EnsSatırSayTb.Enabled = false;
            EnsSatırSayTb.Location = new Point(560, 551);
            EnsSatırSayTb.Name = "EnsSatırSayTb";
            EnsSatırSayTb.ReadOnly = true;
            EnsSatırSayTb.Size = new Size(162, 20);
            EnsSatırSayTb.TabIndex = 62;
            // 
            // label10
            // 
            label10.BackColor = Color.DarkGray;
            label10.Location = new Point(560, 574);
            label10.Name = "label10";
            label10.Size = new Size(160, 3);
            label10.TabIndex = 63;
            // 
            // AnaEkran
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1129, 595);
            Controls.Add(label10);
            Controls.Add(EnsSatırSayTb);
            Controls.Add(label6);
            Controls.Add(EnsKatFiltreCb);
            Controls.Add(label9);
            Controls.Add(EnsRenkCb);
            Controls.Add(EnsMikTb);
            Controls.Add(label2);
            Controls.Add(EnsMikIsim);
            Controls.Add(label8);
            Controls.Add(EnsMarkaCb);
            Controls.Add(yenilebutton);
            Controls.Add(label7);
            Controls.Add(EnsUcrTb);
            Controls.Add(EnsDataGrid);
            Controls.Add(label14);
            Controls.Add(label12);
            Controls.Add(EnsAdTb);
            Controls.Add(label11);
            Controls.Add(EnsGeri);
            Controls.Add(EnsSil);
            Controls.Add(EnsDuzenle);
            Controls.Add(EnsEkle);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(EnsKatCb);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AnaEkran";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AnaEkran";
            Load += AnaEkran_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EnsDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Label label5;
        private Label label1;
        private ComboBox EnsKatCb;
        private Label label3;
        private Label label4;
        private Button EnsEkle;
        private Button EnsDuzenle;
        private Button EnsSil;
        private Button EnsGeri;
        private Label label11;
        private TextBox EnsAdTb;
        private Label label12;
        private Label label14;
        private DataGridViewTextBoxColumn ID;
        private DataGridView EnsDataGrid;
        private TextBox EnsUcrTb;
        private Label label7;
        private Button yenilebutton;
        private Label label8;
        private ComboBox EnsMarkaCb;
        private Label EnsMikIsim;
        private TextBox EnsMikTb;
        private Label label2;
        private Label label9;
        private ComboBox EnsRenkCb;
        private ComboBox EnsKatFiltreCb;
        private Label label6;
        private TextBox EnsSatırSayTb;
        private Label label10;
        private Button altaAlmaButton;
    }
}