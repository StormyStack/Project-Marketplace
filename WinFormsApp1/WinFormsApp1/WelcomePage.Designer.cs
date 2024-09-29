namespace Project_Marketplace
{
    partial class WelcomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomePage));
            label4 = new Label();
            Adminbtn = new Button();
            SellerBtn = new Button();
            BuyerBtn = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Khaki;
            label4.Location = new Point(140, 27);
            label4.Name = "label4";
            label4.Size = new Size(494, 38);
            label4.TabIndex = 40;
            label4.Text = "Welcome to Project MarketPlace";
            // 
            // Adminbtn
            // 
            Adminbtn.BackColor = Color.Khaki;
            Adminbtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Adminbtn.ForeColor = SystemColors.ActiveCaptionText;
            Adminbtn.Location = new Point(343, 147);
            Adminbtn.Margin = new Padding(3, 4, 3, 4);
            Adminbtn.Name = "Adminbtn";
            Adminbtn.Size = new Size(95, 40);
            Adminbtn.TabIndex = 44;
            Adminbtn.Text = "Admin";
            Adminbtn.UseVisualStyleBackColor = false;
            Adminbtn.Click += Adminbtn_Click;
            // 
            // SellerBtn
            // 
            SellerBtn.BackColor = Color.Khaki;
            SellerBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SellerBtn.ForeColor = SystemColors.ActiveCaptionText;
            SellerBtn.Location = new Point(343, 215);
            SellerBtn.Margin = new Padding(3, 4, 3, 4);
            SellerBtn.Name = "SellerBtn";
            SellerBtn.Size = new Size(95, 40);
            SellerBtn.TabIndex = 45;
            SellerBtn.Text = "Seller";
            SellerBtn.UseVisualStyleBackColor = false;
            SellerBtn.Click += SellerBtn_Click;
            // 
            // BuyerBtn
            // 
            BuyerBtn.BackColor = Color.Khaki;
            BuyerBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BuyerBtn.ForeColor = SystemColors.ActiveCaptionText;
            BuyerBtn.Location = new Point(343, 280);
            BuyerBtn.Margin = new Padding(3, 4, 3, 4);
            BuyerBtn.Name = "BuyerBtn";
            BuyerBtn.Size = new Size(95, 40);
            BuyerBtn.TabIndex = 46;
            BuyerBtn.Text = "Buyer";
            BuyerBtn.UseVisualStyleBackColor = false;
            BuyerBtn.Click += BuyerBtn_Click;
            // 
            // WelcomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(782, 453);
            Controls.Add(BuyerBtn);
            Controls.Add(SellerBtn);
            Controls.Add(Adminbtn);
            Controls.Add(label4);
            Name = "WelcomePage";
            Text = "WelcomePage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button Adminbtn;
        private Button SellerBtn;
        private Button BuyerBtn;
    }
}