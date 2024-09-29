namespace WinFormsApp1
{
    partial class Blogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Blogin));
            screateaccount = new Button();
            Bloginpassword = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            BLoginbutton = new Button();
            Bloginusername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // screateaccount
            // 
            screateaccount.BackColor = Color.Khaki;
            screateaccount.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            screateaccount.ForeColor = SystemColors.ActiveCaptionText;
            screateaccount.Location = new Point(136, 294);
            screateaccount.Name = "screateaccount";
            screateaccount.Size = new Size(136, 26);
            screateaccount.TabIndex = 38;
            screateaccount.Text = "Create new account";
            screateaccount.UseVisualStyleBackColor = false;
            screateaccount.Click += screateaccount_Click;
            // 
            // Bloginpassword
            // 
            Bloginpassword.Location = new Point(110, 205);
            Bloginpassword.Name = "Bloginpassword";
            Bloginpassword.PasswordChar = '*';
            Bloginpassword.Size = new Size(214, 23);
            Bloginpassword.TabIndex = 37;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.ErrorImage = (Image)resources.GetObject("pictureBox2.ErrorImage");
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(69, 188);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 35;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(69, 124);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // BLoginbutton
            // 
            BLoginbutton.BackColor = Color.Khaki;
            BLoginbutton.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BLoginbutton.ForeColor = SystemColors.ActiveCaptionText;
            BLoginbutton.Location = new Point(161, 258);
            BLoginbutton.Name = "BLoginbutton";
            BLoginbutton.Size = new Size(83, 30);
            BLoginbutton.TabIndex = 33;
            BLoginbutton.Text = "Log in";
            BLoginbutton.UseVisualStyleBackColor = false;
            BLoginbutton.Click += BLoginbutton_Click;
            // 
            // Bloginusername
            // 
            Bloginusername.Location = new Point(108, 138);
            Bloginusername.Name = "Bloginusername";
            Bloginusername.Size = new Size(214, 23);
            Bloginusername.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 15.75F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(110, 178);
            label2.Name = "label2";
            label2.Size = new Size(90, 23);
            label2.TabIndex = 31;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 15.75F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(110, 112);
            label1.Name = "label1";
            label1.Size = new Size(103, 23);
            label1.TabIndex = 30;
            label1.Text = "User Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(118, 42);
            label4.Name = "label4";
            label4.Size = new Size(159, 31);
            label4.TabIndex = 29;
            label4.Text = "Buyer Login";
            // 
            // button1
            // 
            button1.BackColor = Color.Khaki;
            button1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(370, 294);
            button1.Name = "button1";
            button1.Size = new Size(53, 26);
            button1.TabIndex = 49;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Blogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(684, 340);
            Controls.Add(button1);
            Controls.Add(screateaccount);
            Controls.Add(Bloginpassword);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(BLoginbutton);
            Controls.Add(Bloginusername);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label4);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Blogin";
            Text = "Blogin";
            Load += Blogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button screateaccount;
        private TextBox Bloginpassword;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button BLoginbutton;
        private TextBox Bloginusername;
        private Label label2;
        private Label label1;
        private Label label4;
        private Button button1;
    }
}