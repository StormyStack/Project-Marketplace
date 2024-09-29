namespace WinFormsApp1
{
    partial class SSignup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SSignup));
            panel1 = new Panel();
            HomeBtn = new Button();
            label8 = new Label();
            Sloginbutton = new Button();
            label7 = new Label();
            SSignupbutton = new Button();
            textBox6 = new TextBox();
            Ssignuppass = new TextBox();
            textBox3 = new TextBox();
            Ssignupemail = new TextBox();
            Ssignupusername = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(HomeBtn);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(Sloginbutton);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(SSignupbutton);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(Ssignuppass);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(Ssignupemail);
            panel1.Controls.Add(Ssignupusername);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(3, 1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(783, 455);
            panel1.TabIndex = 1;
            // 
            // HomeBtn
            // 
            HomeBtn.BackgroundImage = (Image)resources.GetObject("HomeBtn.BackgroundImage");
            HomeBtn.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HomeBtn.ForeColor = SystemColors.Control;
            HomeBtn.Location = new Point(467, 395);
            HomeBtn.Margin = new Padding(3, 4, 3, 4);
            HomeBtn.Name = "HomeBtn";
            HomeBtn.Size = new Size(55, 28);
            HomeBtn.TabIndex = 32;
            HomeBtn.Text = "Home";
            HomeBtn.UseVisualStyleBackColor = true;
            HomeBtn.Click += HomeBtn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.WhiteSmoke;
            label8.Location = new Point(82, 398);
            label8.Name = "label8";
            label8.Size = new Size(178, 20);
            label8.TabIndex = 31;
            label8.Text = "Already have an account?";
            // 
            // Sloginbutton
            // 
            Sloginbutton.BackgroundImage = (Image)resources.GetObject("Sloginbutton.BackgroundImage");
            Sloginbutton.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Sloginbutton.ForeColor = SystemColors.Control;
            Sloginbutton.Location = new Point(257, 394);
            Sloginbutton.Margin = new Padding(3, 4, 3, 4);
            Sloginbutton.Name = "Sloginbutton";
            Sloginbutton.Size = new Size(46, 28);
            Sloginbutton.TabIndex = 29;
            Sloginbutton.Text = "LogIn";
            Sloginbutton.UseVisualStyleBackColor = true;
            Sloginbutton.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(174, 657);
            label7.Name = "label7";
            label7.Size = new Size(178, 20);
            label7.TabIndex = 28;
            label7.Text = "Already have an account?";
            // 
            // SSignupbutton
            // 
            SSignupbutton.BackColor = Color.SlateBlue;
            SSignupbutton.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SSignupbutton.ForeColor = SystemColors.ButtonHighlight;
            SSignupbutton.Location = new Point(130, 339);
            SSignupbutton.Margin = new Padding(3, 4, 3, 4);
            SSignupbutton.Name = "SSignupbutton";
            SSignupbutton.Size = new Size(95, 40);
            SSignupbutton.TabIndex = 27;
            SSignupbutton.Text = "SignUp";
            SSignupbutton.UseVisualStyleBackColor = false;
            SSignupbutton.Click += SSignupbutton_Click;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.WhiteSmoke;
            textBox6.Location = new Point(130, 91);
            textBox6.Margin = new Padding(3, 4, 3, 4);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(244, 27);
            textBox6.TabIndex = 26;
            // 
            // Ssignuppass
            // 
            Ssignuppass.BackColor = Color.WhiteSmoke;
            Ssignuppass.Location = new Point(130, 268);
            Ssignuppass.Margin = new Padding(3, 4, 3, 4);
            Ssignuppass.Name = "Ssignuppass";
            Ssignuppass.Size = new Size(244, 27);
            Ssignuppass.TabIndex = 24;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.WhiteSmoke;
            textBox3.Location = new Point(130, 224);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(244, 27);
            textBox3.TabIndex = 21;
            // 
            // Ssignupemail
            // 
            Ssignupemail.BackColor = Color.WhiteSmoke;
            Ssignupemail.Location = new Point(130, 180);
            Ssignupemail.Margin = new Padding(3, 4, 3, 4);
            Ssignupemail.Name = "Ssignupemail";
            Ssignupemail.Size = new Size(244, 27);
            Ssignupemail.TabIndex = 20;
            // 
            // Ssignupusername
            // 
            Ssignupusername.BackColor = Color.WhiteSmoke;
            Ssignupusername.Location = new Point(130, 134);
            Ssignupusername.Margin = new Padding(3, 4, 3, 4);
            Ssignupusername.Name = "Ssignupusername";
            Ssignupusername.Size = new Size(244, 27);
            Ssignupusername.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Times New Roman", 13.8F);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(18, 137);
            label6.Name = "label6";
            label6.Size = new Size(110, 26);
            label6.TabIndex = 13;
            label6.Text = "Username:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 13.8F);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(18, 183);
            label5.Name = "label5";
            label5.Size = new Size(71, 26);
            label5.TabIndex = 12;
            label5.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 13.8F);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(18, 227);
            label3.Name = "label3";
            label3.Size = new Size(77, 26);
            label3.TabIndex = 11;
            label3.Text = "Phone:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 13.8F);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(18, 271);
            label2.Name = "label2";
            label2.Size = new Size(108, 26);
            label2.TabIndex = 10;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 13.8F);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(18, 90);
            label1.Name = "label1";
            label1.Size = new Size(72, 26);
            label1.TabIndex = 9;
            label1.Text = "Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(284, 19);
            label4.Name = "label4";
            label4.Size = new Size(215, 38);
            label4.TabIndex = 8;
            label4.Text = "Seller SignUp";
            label4.Click += label4_Click;
            // 
            // SSignup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(782, 453);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SSignup";
            Text = "SSignup";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button Sloginbutton;
        private Label label7;
        private Button SSignupbutton;
        private TextBox textBox6;
        private TextBox Ssignuppass;
        private TextBox textBox3;
        private TextBox Ssignupemail;
        private TextBox Ssignupusername;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label8;
        private Button HomeBtn;
    }
}