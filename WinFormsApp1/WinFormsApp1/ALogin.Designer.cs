namespace Project_Marketplace
{
    partial class ALogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ALogin));
            Aloginpassword = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ALoginbutton = new Button();
            Aloginusername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            screateaccount = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Aloginpassword
            // 
            Aloginpassword.Location = new Point(132, 267);
            Aloginpassword.Margin = new Padding(3, 4, 3, 4);
            Aloginpassword.Name = "Aloginpassword";
            Aloginpassword.PasswordChar = '*';
            Aloginpassword.Size = new Size(242, 27);
            Aloginpassword.TabIndex = 47;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.ErrorImage = (Image)resources.GetObject("pictureBox2.ErrorImage");
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(85, 244);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 45;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(85, 159);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            // 
            // ALoginbutton
            // 
            ALoginbutton.BackColor = Color.Khaki;
            ALoginbutton.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ALoginbutton.ForeColor = SystemColors.ActiveCaptionText;
            ALoginbutton.Location = new Point(185, 356);
            ALoginbutton.Margin = new Padding(3, 4, 3, 4);
            ALoginbutton.Name = "ALoginbutton";
            ALoginbutton.Size = new Size(95, 40);
            ALoginbutton.TabIndex = 43;
            ALoginbutton.Text = "Log in";
            ALoginbutton.UseVisualStyleBackColor = false;
            ALoginbutton.Click += ALoginbutton_Click;
            // 
            // Aloginusername
            // 
            Aloginusername.Location = new Point(130, 178);
            Aloginusername.Margin = new Padding(3, 4, 3, 4);
            Aloginusername.Name = "Aloginusername";
            Aloginusername.Size = new Size(244, 27);
            Aloginusername.TabIndex = 42;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 15.75F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(132, 232);
            label2.Name = "label2";
            label2.Size = new Size(117, 31);
            label2.TabIndex = 41;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 15.75F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(132, 143);
            label1.Name = "label1";
            label1.Size = new Size(134, 31);
            label1.TabIndex = 40;
            label1.Text = "User Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(119, 49);
            label4.Name = "label4";
            label4.Size = new Size(211, 38);
            label4.TabIndex = 39;
            label4.Text = "Admin Login";
            // 
            // screateaccount
            // 
            screateaccount.BackColor = Color.Khaki;
            screateaccount.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            screateaccount.ForeColor = SystemColors.ActiveCaptionText;
            screateaccount.Location = new Point(203, 404);
            screateaccount.Margin = new Padding(3, 4, 3, 4);
            screateaccount.Name = "screateaccount";
            screateaccount.Size = new Size(61, 34);
            screateaccount.TabIndex = 48;
            screateaccount.Text = "Home";
            screateaccount.UseVisualStyleBackColor = false;
            screateaccount.Click += screateaccount_Click;
            // 
            // ALogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(782, 453);
            Controls.Add(screateaccount);
            Controls.Add(Aloginpassword);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(ALoginbutton);
            Controls.Add(Aloginusername);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label4);
            DoubleBuffered = true;
            Name = "ALogin";
            Text = "ALogin";
            Load += ALogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox Aloginpassword;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button ALoginbutton;
        private TextBox Aloginusername;
        private Label label2;
        private Label label1;
        private Label label4;
        private Button screateaccount;
    }
}