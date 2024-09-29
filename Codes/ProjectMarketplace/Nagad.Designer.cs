namespace Project_Marketplace
{
    partial class Nagad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nagad));
            NagadPassTxt = new TextBox();
            NagadnmbrTxt = new TextBox();
            label1 = new Label();
            label4 = new Label();
            ConfirmngdBtn = new Button();
            BackngdBtn = new Button();
            SuspendLayout();
            // 
            // NagadPassTxt
            // 
            NagadPassTxt.Location = new Point(218, 302);
            NagadPassTxt.Name = "NagadPassTxt";
            NagadPassTxt.PasswordChar = '*';
            NagadPassTxt.Size = new Size(359, 27);
            NagadPassTxt.TabIndex = 50;
            // 
            // NagadnmbrTxt
            // 
            NagadnmbrTxt.Location = new Point(218, 238);
            NagadnmbrTxt.Name = "NagadnmbrTxt";
            NagadnmbrTxt.Size = new Size(359, 27);
            NagadnmbrTxt.TabIndex = 49;
            NagadnmbrTxt.TextChanged += NagadnmbrTxt_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 15.75F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(218, 268);
            label1.Name = "label1";
            label1.Size = new Size(129, 31);
            label1.TabIndex = 48;
            label1.Text = "Enter PIN:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 15.75F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(218, 192);
            label4.Name = "label4";
            label4.Size = new Size(320, 31);
            label4.TabIndex = 47;
            label4.Text = "Enter Your Mobile Number:";
            // 
            // ConfirmngdBtn
            // 
            ConfirmngdBtn.BackColor = Color.Transparent;
            ConfirmngdBtn.BackgroundImage = (Image)resources.GetObject("ConfirmngdBtn.BackgroundImage");
            ConfirmngdBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ConfirmngdBtn.ForeColor = SystemColors.Control;
            ConfirmngdBtn.Location = new Point(513, 389);
            ConfirmngdBtn.Margin = new Padding(3, 4, 3, 4);
            ConfirmngdBtn.Name = "ConfirmngdBtn";
            ConfirmngdBtn.Size = new Size(101, 40);
            ConfirmngdBtn.TabIndex = 53;
            ConfirmngdBtn.Text = "Confirm";
            ConfirmngdBtn.UseVisualStyleBackColor = false;
            ConfirmngdBtn.Click += ConfirmngdBtn_Click;
            // 
            // BackngdBtn
            // 
            BackngdBtn.BackColor = Color.Transparent;
            BackngdBtn.BackgroundImage = (Image)resources.GetObject("BackngdBtn.BackgroundImage");
            BackngdBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackngdBtn.ForeColor = SystemColors.Control;
            BackngdBtn.Location = new Point(656, 389);
            BackngdBtn.Margin = new Padding(3, 4, 3, 4);
            BackngdBtn.Name = "BackngdBtn";
            BackngdBtn.Size = new Size(95, 40);
            BackngdBtn.TabIndex = 52;
            BackngdBtn.Text = "Back";
            BackngdBtn.UseVisualStyleBackColor = false;
            BackngdBtn.Click += BackngdBtn_Click;
            // 
            // Nagad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(ConfirmngdBtn);
            Controls.Add(BackngdBtn);
            Controls.Add(NagadPassTxt);
            Controls.Add(NagadnmbrTxt);
            Controls.Add(label1);
            Controls.Add(label4);
            DoubleBuffered = true;
            Name = "Nagad";
            Text = "Nagad";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NagadPassTxt;
        private TextBox NagadnmbrTxt;
        private Label label1;
        private Label label4;
        private Button ConfirmngdBtn;
        private Button BackngdBtn;
    }
}