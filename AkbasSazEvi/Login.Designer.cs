namespace AkbasSazEvi
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            button1 = new Button();
            label6 = new Label();
            label7 = new Label();
            label1 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            altaAlmaButton = new Button();
            button2 = new Button();
            adminLoginButton = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // usernameTextBox
            // 
            usernameTextBox.BackColor = Color.Moccasin;
            usernameTextBox.BorderStyle = BorderStyle.None;
            usernameTextBox.Location = new Point(299, 275);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(182, 20);
            usernameTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = Color.Moccasin;
            passwordTextBox.BorderStyle = BorderStyle.None;
            passwordTextBox.Location = new Point(299, 317);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(182, 20);
            passwordTextBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(172, 313);
            label3.Name = "label3";
            label3.Size = new Size(108, 30);
            label3.TabIndex = 5;
            label3.Text = "Password:";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(172, 269);
            label4.Name = "label4";
            label4.Size = new Size(108, 30);
            label4.TabIndex = 6;
            label4.Text = "Username:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(569, 183);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(223, 222);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.BackColor = Color.Moccasin;
            label2.Font = new Font("Consolas", 32F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = Color.Orange;
            label2.Location = new Point(298, 126);
            label2.Name = "label2";
            label2.Size = new Size(182, 69);
            label2.TabIndex = 8;
            label2.Text = "Login";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.Moccasin;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(417, 397);
            button1.Name = "button1";
            button1.Size = new Size(111, 69);
            button1.TabIndex = 9;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.BackColor = Color.DarkOrange;
            label6.Location = new Point(298, 340);
            label6.Name = "label6";
            label6.Size = new Size(182, 3);
            label6.TabIndex = 12;
            // 
            // label7
            // 
            label7.BackColor = Color.DarkOrange;
            label7.Location = new Point(298, 298);
            label7.Name = "label7";
            label7.Size = new Size(182, 3);
            label7.TabIndex = 13;
            // 
            // label1
            // 
            label1.BackColor = Color.Black;
            label1.Font = new Font("Consolas", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(206, 11);
            label1.Name = "label1";
            label1.Size = new Size(429, 70);
            label1.TabIndex = 1;
            label1.Text = "Akbas Saz Evi";
            label1.TextAlign = ContentAlignment.TopCenter;
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
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(altaAlmaButton);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(829, 82);
            panel1.TabIndex = 16;
            // 
            // altaAlmaButton
            // 
            altaAlmaButton.AutoSize = true;
            altaAlmaButton.FlatStyle = FlatStyle.Flat;
            altaAlmaButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            altaAlmaButton.ForeColor = SystemColors.ActiveCaption;
            altaAlmaButton.Location = new Point(735, 0);
            altaAlmaButton.Name = "altaAlmaButton";
            altaAlmaButton.Size = new Size(46, 44);
            altaAlmaButton.TabIndex = 19;
            altaAlmaButton.Text = "__";
            altaAlmaButton.UseVisualStyleBackColor = true;
            altaAlmaButton.Click += altaAlmaButton_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaption;
            button2.Location = new Point(781, 0);
            button2.Name = "button2";
            button2.Size = new Size(46, 44);
            button2.TabIndex = 17;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button3_Click;
            // 
            // adminLoginButton
            // 
            adminLoginButton.BackColor = Color.Moccasin;
            adminLoginButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            adminLoginButton.Location = new Point(231, 397);
            adminLoginButton.Name = "adminLoginButton";
            adminLoginButton.Size = new Size(106, 69);
            adminLoginButton.TabIndex = 17;
            adminLoginButton.Text = "Admin Login";
            adminLoginButton.UseVisualStyleBackColor = false;
            adminLoginButton.Click += adminLoginButton_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Moccasin;
            button3.FlatAppearance.BorderColor = Color.White;
            button3.FlatAppearance.BorderSize = 0;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(633, 444);
            button3.Name = "button3";
            button3.Size = new Size(111, 69);
            button3.TabIndex = 18;
            button3.Text = "Sign Up";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.Moccasin;
            ClientSize = new Size(827, 538);
            Controls.Add(button3);
            Controls.Add(adminLoginButton);
            Controls.Add(panel1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox2;
        private Label label2;
        private Button button1;
        private Label label6;
        private Label label7;
        private Label label1;
        private Label label5;
        private Panel panel1;
        private Button button2;
        private Button altaAlmaButton;
        private Button adminLoginButton;
        private Button button3;
    }
}