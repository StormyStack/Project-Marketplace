namespace WinFormsApp1
{
    partial class SLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SLogin));
            Sloginpassword = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            SLoginbutton = new Button();
            Sloginusername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            screateaccount = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Sloginpassword
            // 
            Sloginpassword.Location = new Point(126, 272);
            Sloginpassword.Margin = new Padding(3, 4, 3, 4);
            Sloginpassword.Name = "Sloginpassword";
            Sloginpassword.PasswordChar = '*';
            Sloginpassword.Size = new Size(244, 27);
            Sloginpassword.TabIndex = 27;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.ErrorImage = (Image)resources.GetObject("pictureBox2.ErrorImage");
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(79, 249);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(79, 164);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // SLoginbutton
            // 
            SLoginbutton.BackColor = Color.Khaki;
            SLoginbutton.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SLoginbutton.ForeColor = SystemColors.ActiveCaptionText;
            SLoginbutton.Location = new Point(184, 337);
            SLoginbutton.Margin = new Padding(3, 4, 3, 4);
            SLoginbutton.Name = "SLoginbutton";
            SLoginbutton.Size = new Size(95, 40);
            SLoginbutton.TabIndex = 22;
            SLoginbutton.Text = "Log in";
            SLoginbutton.UseVisualStyleBackColor = false;
            SLoginbutton.Click += SLoginbutton_Click;
            // 
            // Sloginusername
            // 
            Sloginusername.Location = new Point(124, 183);
            Sloginusername.Margin = new Padding(3, 4, 3, 4);
            Sloginusername.Name = "Sloginusername";
            Sloginusername.Size = new Size(244, 27);
            Sloginusername.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 15.75F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(126, 237);
            label2.Name = "label2";
            label2.Size = new Size(117, 31);
            label2.TabIndex = 20;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 15.75F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(126, 148);
            label1.Name = "label1";
            label1.Size = new Size(134, 31);
            label1.TabIndex = 19;
            label1.Text = "User Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(143, 54);
            label4.Name = "label4";
            label4.Size = new Size(192, 38);
            label4.TabIndex = 18;
            label4.Text = "Seller Login";
            // 
            // screateaccount
            // 
            screateaccount.BackColor = Color.Khaki;
            screateaccount.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            screateaccount.ForeColor = SystemColors.ActiveCaptionText;
            screateaccount.Location = new Point(158, 385);
            screateaccount.Margin = new Padding(3, 4, 3, 4);
            screateaccount.Name = "screateaccount";
            screateaccount.Size = new Size(156, 34);
            screateaccount.TabIndex = 28;
            screateaccount.Text = "Create new account";
            screateaccount.UseVisualStyleBackColor = false;
            screateaccount.Click += screateaccount_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Khaki;
            button1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(433, 391);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(55, 28);
            button1.TabIndex = 50;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // SLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(782, 453);
            Controls.Add(button1);
            Controls.Add(screateaccount);
            Controls.Add(Sloginpassword);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(SLoginbutton);
            Controls.Add(Sloginusername);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label4);
            DoubleBuffered = true;
            Name = "SLogin";
            Text = "SLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Sloginpassword;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button SLoginbutton;
        private TextBox Sloginusername;
        private Label label2;
        private Label label1;
        private Label label4;
        private Button screateaccount;
        private Button button1;
    }
}