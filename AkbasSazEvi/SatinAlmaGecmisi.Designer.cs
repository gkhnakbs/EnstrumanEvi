namespace AkbasSazEvi
{
    partial class SatinAlmaGecmisi
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
            button4 = new Button();
            label2 = new Label();
            panel1 = new Panel();
            altaAlmaButton = new Button();
            button3 = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = Color.Moccasin;
            button4.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(653, 477);
            button4.Name = "button4";
            button4.Size = new Size(148, 49);
            button4.TabIndex = 22;
            button4.Text = "Geri";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Arial Rounded MT Bold", 17F, FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(288, 99);
            label2.Name = "label2";
            label2.Size = new Size(291, 38);
            label2.TabIndex = 25;
            label2.Text = "Satın Alma Geçmişi";
            // 
            // panel1
            // 
            panel1.AllowDrop = true;
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(altaAlmaButton);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(829, 87);
            panel1.TabIndex = 23;
            // 
            // altaAlmaButton
            // 
            altaAlmaButton.AutoSize = true;
            altaAlmaButton.FlatStyle = FlatStyle.Flat;
            altaAlmaButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            altaAlmaButton.ForeColor = SystemColors.ActiveCaption;
            altaAlmaButton.Location = new Point(732, 2);
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
            button3.Location = new Point(778, 2);
            button3.Name = "button3";
            button3.Size = new Size(51, 44);
            button3.TabIndex = 17;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Black;
            label1.Font = new Font("Arial Rounded MT Bold", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(194, 12);
            label1.Name = "label1";
            label1.Size = new Size(453, 75);
            label1.TabIndex = 15;
            label1.Text = "Enstruman Evi";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 143);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(803, 328);
            dataGridView1.TabIndex = 26;
            // 
            // SatinAlmaGecmisi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 538);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SatinAlmaGecmisi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SatinAlmaGecmisi";
            Load += SatinAlmaGecmisi_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button4;
        private Label label2;
        private Panel panel1;
        private Button altaAlmaButton;
        private Button button3;
        private Label label1;
        private DataGridView dataGridView1;
    }
}