namespace AkbasSazEvi
{
    partial class MenuSecmeAdmin
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
            sifreYenile = new Button();
            enstrumanYonetim = new Button();
            label2 = new Label();
            button6 = new Button();
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
            panel1.TabIndex = 18;
            // 
            // altaAlmaButton
            // 
            altaAlmaButton.AutoSize = true;
            altaAlmaButton.FlatStyle = FlatStyle.Flat;
            altaAlmaButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            altaAlmaButton.ForeColor = SystemColors.ActiveCaption;
            altaAlmaButton.Location = new Point(732, 0);
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
            button3.Location = new Point(778, 0);
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
            panel2.BackColor = Color.DarkGray;
            panel2.Controls.Add(sifreYenile);
            panel2.Controls.Add(enstrumanYonetim);
            panel2.Location = new Point(220, 176);
            panel2.Name = "panel2";
            panel2.Size = new Size(408, 335);
            panel2.TabIndex = 19;
            // 
            // sifreYenile
            // 
            sifreYenile.BackColor = Color.Moccasin;
            sifreYenile.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            sifreYenile.ForeColor = Color.Black;
            sifreYenile.Location = new Point(111, 189);
            sifreYenile.Name = "sifreYenile";
            sifreYenile.Size = new Size(203, 71);
            sifreYenile.TabIndex = 5;
            sifreYenile.Text = "Şifre Yenile";
            sifreYenile.UseVisualStyleBackColor = false;
            sifreYenile.Click += sifreYenile_Click;
            // 
            // enstrumanYonetim
            // 
            enstrumanYonetim.BackColor = Color.Moccasin;
            enstrumanYonetim.FlatAppearance.BorderSize = 0;
            enstrumanYonetim.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            enstrumanYonetim.ForeColor = Color.Black;
            enstrumanYonetim.Location = new Point(111, 46);
            enstrumanYonetim.Name = "enstrumanYonetim";
            enstrumanYonetim.Size = new Size(203, 74);
            enstrumanYonetim.TabIndex = 0;
            enstrumanYonetim.Text = "Enstrüman Yönetim";
            enstrumanYonetim.UseVisualStyleBackColor = false;
            enstrumanYonetim.Click += enstrumanYonetim_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Arial Rounded MT Bold", 19.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(294, 102);
            label2.Name = "label2";
            label2.Size = new Size(278, 58);
            label2.TabIndex = 20;
            label2.Text = "Admin Ana Menü";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button6
            // 
            button6.BackColor = Color.Black;
            button6.ForeColor = Color.White;
            button6.Location = new Point(688, 463);
            button6.Name = "button6";
            button6.Size = new Size(97, 48);
            button6.TabIndex = 4;
            button6.Text = "Çıkış Yap";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // MenuSecmeAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(827, 538);
            Controls.Add(button6);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuSecmeAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuSecme";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button altaAlmaButton;
        private Button button3;
        private Label label1;
        private Panel panel2;
        private Button enstrumanYonetim;
        private Label label2;
        private Button button6;
        private Button sifreYenile;
    }
}