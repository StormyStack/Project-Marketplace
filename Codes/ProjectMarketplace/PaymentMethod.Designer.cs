namespace Project_Marketplace
{
    partial class PaymentMethod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentMethod));
            label4 = new Label();
            bksCB = new CheckBox();
            ngdCB = new CheckBox();
            BackpaymentBtn = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 15.75F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(232, 9);
            label4.Name = "label4";
            label4.Size = new Size(264, 31);
            label4.TabIndex = 48;
            label4.Text = "confirm Your Payment:";
            // 
            // bksCB
            // 
            bksCB.AutoSize = true;
            bksCB.Location = new Point(163, 242);
            bksCB.Name = "bksCB";
            bksCB.Size = new Size(18, 17);
            bksCB.TabIndex = 49;
            bksCB.UseVisualStyleBackColor = true;
            bksCB.CheckedChanged += bksCB_CheckedChanged;
            // 
            // ngdCB
            // 
            ngdCB.AutoSize = true;
            ngdCB.Location = new Point(570, 242);
            ngdCB.Name = "ngdCB";
            ngdCB.Size = new Size(18, 17);
            ngdCB.TabIndex = 50;
            ngdCB.UseVisualStyleBackColor = true;
            ngdCB.CheckedChanged += ngdCB_CheckedChanged;
            // 
            // BackpaymentBtn
            // 
            BackpaymentBtn.BackColor = Color.Transparent;
            BackpaymentBtn.BackgroundImage = (Image)resources.GetObject("BackpaymentBtn.BackgroundImage");
            BackpaymentBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackpaymentBtn.ForeColor = SystemColors.Control;
            BackpaymentBtn.Location = new Point(579, 352);
            BackpaymentBtn.Margin = new Padding(3, 4, 3, 4);
            BackpaymentBtn.Name = "BackpaymentBtn";
            BackpaymentBtn.Size = new Size(95, 40);
            BackpaymentBtn.TabIndex = 53;
            BackpaymentBtn.Text = "Back";
            BackpaymentBtn.UseVisualStyleBackColor = false;
            BackpaymentBtn.Click += BackngdBtn_Click;
            // 
            // PaymentMethod
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(727, 419);
            Controls.Add(BackpaymentBtn);
            Controls.Add(ngdCB);
            Controls.Add(bksCB);
            Controls.Add(label4);
            DoubleBuffered = true;
            Name = "PaymentMethod";
            Text = "PaymentMethod";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private CheckBox bksCB;
        private CheckBox ngdCB;
        private Button BackpaymentBtn;
    }
}