namespace Project_Marketplace
{
    partial class StartProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartProject));
            label4 = new Label();
            getStartbtn = new Button();
            label1 = new Label();
            checkBox1 = new CheckBox();
            richTextBox1 = new RichTextBox();
            label9 = new Label();
            label7 = new Label();
            label8 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightCoral;
            label4.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(128, 33);
            label4.Name = "label4";
            label4.Size = new Size(494, 38);
            label4.TabIndex = 41;
            label4.Text = "Welcome to Project MarketPlace";
            // 
            // getStartbtn
            // 
            getStartbtn.BackColor = Color.Black;
            getStartbtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            getStartbtn.ForeColor = Color.WhiteSmoke;
            getStartbtn.Location = new Point(506, 380);
            getStartbtn.Margin = new Padding(3, 4, 3, 4);
            getStartbtn.Name = "getStartbtn";
            getStartbtn.Size = new Size(125, 40);
            getStartbtn.TabIndex = 42;
            getStartbtn.Text = "Get Started";
            getStartbtn.UseVisualStyleBackColor = false;
            getStartbtn.Click += Homebtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(280, 180);
            label1.Name = "label1";
            label1.Size = new Size(191, 23);
            label1.TabIndex = 43;
            label1.Text = "Terms and Conditions";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.LightCoral;
            checkBox1.ForeColor = SystemColors.ActiveCaptionText;
            checkBox1.Location = new Point(248, 335);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(291, 24);
            checkBox1.TabIndex = 48;
            checkBox1.Text = "I agree with these terms and conditions";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.LightCoral;
            richTextBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(42, 79);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(660, 93);
            richTextBox1.TabIndex = 52;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.LightCoral;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(157, 291);
            label9.Name = "label9";
            label9.Size = new Size(422, 22);
            label9.TabIndex = 51;
            label9.Text = "but will no longer have access to the project details.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.LightCoral;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(157, 240);
            label7.Name = "label7";
            label7.Size = new Size(401, 22);
            label7.TabIndex = 49;
            label7.Text = "2.In the event where a seller deletes their project,";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.LightCoral;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(157, 265);
            label8.Name = "label8";
            label8.Size = new Size(379, 22);
            label8.TabIndex = 50;
            label8.Text = "buyers will still be able to view the seller's ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LightCoral;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(157, 215);
            label6.Name = "label6";
            label6.Size = new Size(275, 22);
            label6.TabIndex = 47;
            label6.Text = "1. One Seller can add one project";
            label6.Click += label6_Click;
            // 
            // StartProject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(782, 453);
            Controls.Add(richTextBox1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(checkBox1);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(getStartbtn);
            Controls.Add(label4);
            Name = "StartProject";
            Text = "6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button getStartbtn;
        private Label label1;
        private CheckBox checkBox1;
        private RichTextBox richTextBox1;
        private Label label9;
        private Label label7;
        private Label label8;
        private Label label6;
    }
}