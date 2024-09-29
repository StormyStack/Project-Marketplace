namespace Project_Marketplace
{
    partial class Bkash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bkash));
            label4 = new Label();
            label1 = new Label();
            bksnmbrTxt = new TextBox();
            bksPinTxt = new TextBox();
            BackbksBtn = new Button();
            ConfirmbksBtn = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 15.75F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(214, 160);
            label4.Name = "label4";
            label4.Size = new Size(320, 31);
            label4.TabIndex = 43;
            label4.Text = "Enter Mobile Number Here:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 15.75F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(214, 245);
            label1.Name = "label1";
            label1.Size = new Size(129, 31);
            label1.TabIndex = 44;
            label1.Text = "Enter PIN:";
            // 
            // bksnmbrTxt
            // 
            bksnmbrTxt.Location = new Point(219, 203);
            bksnmbrTxt.Name = "bksnmbrTxt";
            bksnmbrTxt.Size = new Size(359, 27);
            bksnmbrTxt.TabIndex = 45;
            // 
            // bksPinTxt
            // 
            bksPinTxt.Location = new Point(219, 287);
            bksPinTxt.Name = "bksPinTxt";
            bksPinTxt.PasswordChar = '*';
            bksPinTxt.Size = new Size(359, 27);
            bksPinTxt.TabIndex = 46;
            // 
            // BackbksBtn
            // 
            BackbksBtn.BackColor = Color.Transparent;
            BackbksBtn.BackgroundImage = (Image)resources.GetObject("BackbksBtn.BackgroundImage");
            BackbksBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackbksBtn.ForeColor = SystemColors.Control;
            BackbksBtn.Location = new Point(655, 368);
            BackbksBtn.Margin = new Padding(3, 4, 3, 4);
            BackbksBtn.Name = "BackbksBtn";
            BackbksBtn.Size = new Size(95, 40);
            BackbksBtn.TabIndex = 50;
            BackbksBtn.Text = "Back";
            BackbksBtn.UseVisualStyleBackColor = false;
            BackbksBtn.Click += BackbksBtn_Click;
            // 
            // ConfirmbksBtn
            // 
            ConfirmbksBtn.BackColor = Color.WhiteSmoke;
            ConfirmbksBtn.BackgroundImage = (Image)resources.GetObject("ConfirmbksBtn.BackgroundImage");
            ConfirmbksBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ConfirmbksBtn.ForeColor = SystemColors.Control;
            ConfirmbksBtn.Location = new Point(508, 368);
            ConfirmbksBtn.Margin = new Padding(3, 4, 3, 4);
            ConfirmbksBtn.Name = "ConfirmbksBtn";
            ConfirmbksBtn.Size = new Size(101, 40);
            ConfirmbksBtn.TabIndex = 51;
            ConfirmbksBtn.Text = "Confirm";
            ConfirmbksBtn.UseVisualStyleBackColor = false;
            ConfirmbksBtn.Click += ConfirmbksBtn_Click;
            // 
            // Bkash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(ConfirmbksBtn);
            Controls.Add(BackbksBtn);
            Controls.Add(bksPinTxt);
            Controls.Add(bksnmbrTxt);
            Controls.Add(label1);
            Controls.Add(label4);
            DoubleBuffered = true;
            Name = "Bkash";
            Text = "Bkash";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label1;
        private TextBox bksnmbrTxt;
        private TextBox bksPinTxt;
        private Button BackbksBtn;
        private Button ConfirmbksBtn;
    }
}