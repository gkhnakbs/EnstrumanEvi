namespace AkbasSazEvi
{
    partial class SifreYenile
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
            panel1 = new Panel();
            altaAlmaButton = new Button();
            button3 = new Button();
            label1 = new Label();
            panel2 = new Panel();
            geri = new Button();
            onayla = new Button();
            yeniSifre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            eskiSifre = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AllowDrop = true;
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(altaAlmaButton);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(829, 87);
            panel1.TabIndex = 19;
            // 
            // altaAlmaButton
            // 
            altaAlmaButton.AutoSize = true;
            altaAlmaButton.FlatStyle = FlatStyle.Flat;
            altaAlmaButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            altaAlmaButton.ForeColor = SystemColors.ActiveCaption;
            altaAlmaButton.Location = new Point(734, 0);
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
            button3.Location = new Point(779, 0);
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
            label1.Location = new Point(190, 12);
            label1.Name = "label1";
            label1.Size = new Size(453, 75);
            label1.TabIndex = 15;
            label1.Text = "Enstruman Evi";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(geri);
            panel2.Controls.Add(onayla);
            panel2.Controls.Add(yeniSifre);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(eskiSifre);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(216, 108);
            panel2.Name = "panel2";
            panel2.Size = new Size(426, 388);
            panel2.TabIndex = 20;
            // 
            // geri
            // 
            geri.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            geri.Location = new Point(49, 284);
            geri.Name = "geri";
            geri.Size = new Size(144, 48);
            geri.TabIndex = 6;
            geri.Text = "Geri";
            geri.UseVisualStyleBackColor = true;
            geri.Click += geri_Click;
            // 
            // onayla
            // 
            onayla.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            onayla.Location = new Point(240, 284);
            onayla.Name = "onayla";
            onayla.Size = new Size(144, 48);
            onayla.TabIndex = 5;
            onayla.Text = "Onayla";
            onayla.UseVisualStyleBackColor = true;
            onayla.Click += onayla_Click;
            // 
            // yeniSifre
            // 
            yeniSifre.Location = new Point(142, 183);
            yeniSifre.Name = "yeniSifre";
            yeniSifre.Size = new Size(263, 27);
            yeniSifre.TabIndex = 4;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 183);
            label4.Name = "label4";
            label4.Size = new Size(105, 33);
            label4.TabIndex = 3;
            label4.Text = "Yeni Şifre";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 118);
            label3.Name = "label3";
            label3.Size = new Size(105, 33);
            label3.TabIndex = 2;
            label3.Text = "Eski Şifre";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // eskiSifre
            // 
            eskiSifre.Location = new Point(142, 124);
            eskiSifre.Name = "eskiSifre";
            eskiSifre.Size = new Size(263, 27);
            eskiSifre.TabIndex = 1;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Underline, GraphicsUnit.Point);
            label2.Location = new Point(12, 13);
            label2.Name = "label2";
            label2.Size = new Size(393, 105);
            label2.TabIndex = 0;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SifreYenile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 538);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SifreYenile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SifreYenile";
            Load += SifreYenile_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button altaAlmaButton;
        private Button button3;
        private Label label1;
        private Panel panel2;
        private Button geri;
        private Button onayla;
        private TextBox yeniSifre;
        private Label label4;
        private Label label3;
        private TextBox eskiSifre;
        private Label label2;
    }
}