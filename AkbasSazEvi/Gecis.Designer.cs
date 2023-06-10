namespace AkbasSazEvi
{
    partial class Gecis
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
            components = new System.ComponentModel.Container();
            label2 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            yuzdeSayici = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(255, 158);
            label2.Name = "label2";
            label2.Size = new Size(313, 80);
            label2.TabIndex = 9;
            label2.Text = "Hosgeldiniz..";
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label5);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(832, 82);
            panel1.TabIndex = 17;
            // 
            // label5
            // 
            label5.BackColor = Color.Black;
            label5.Font = new Font("Consolas", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaption;
            label5.Location = new Point(201, 12);
            label5.Name = "label5";
            label5.Size = new Size(429, 70);
            label5.TabIndex = 15;
            label5.Text = "Enstruman Evi";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // progressBar1
            // 
            progressBar1.ForeColor = Color.DarkOrange;
            progressBar1.Location = new Point(0, 360);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(829, 29);
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 18;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // yuzdeSayici
            // 
            yuzdeSayici.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            yuzdeSayici.Location = new Point(358, 308);
            yuzdeSayici.Name = "yuzdeSayici";
            yuzdeSayici.Size = new Size(101, 49);
            yuzdeSayici.TabIndex = 19;
            yuzdeSayici.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Gecis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(826, 458);
            Controls.Add(yuzdeSayici);
            Controls.Add(progressBar1);
            Controls.Add(panel1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Gecis";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Gecis_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Panel panel1;
        private Label label5;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private Label yuzdeSayici;
    }
}