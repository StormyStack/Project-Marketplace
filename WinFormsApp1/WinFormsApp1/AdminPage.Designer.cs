namespace WinFormsApp1
{
    partial class AdminPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
            label4 = new Label();
            label1 = new Label();
            BuyerInfoDGV = new DataGridView();
            SellerInfoDGV = new DataGridView();
            label3 = new Label();
            ProjectDGV = new DataGridView();
            label2 = new Label();
            BackbksBtn = new Button();
            HomeBtn = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)BuyerInfoDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SellerInfoDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProjectDGV).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(221, 53);
            label4.Name = "label4";
            label4.Size = new Size(136, 29);
            label4.TabIndex = 43;
            label4.Text = "Buyer Info:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(886, 53);
            label1.Name = "label1";
            label1.Size = new Size(132, 29);
            label1.TabIndex = 44;
            label1.Text = "Seller Info:";
            // 
            // BuyerInfoDGV
            // 
            BuyerInfoDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BuyerInfoDGV.Location = new Point(33, 103);
            BuyerInfoDGV.Name = "BuyerInfoDGV";
            BuyerInfoDGV.RowHeadersWidth = 51;
            BuyerInfoDGV.Size = new Size(531, 188);
            BuyerInfoDGV.TabIndex = 45;
            // 
            // SellerInfoDGV
            // 
            SellerInfoDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SellerInfoDGV.Location = new Point(676, 103);
            SellerInfoDGV.Name = "SellerInfoDGV";
            SellerInfoDGV.RowHeadersWidth = 51;
            SellerInfoDGV.Size = new Size(514, 188);
            SellerInfoDGV.TabIndex = 46;
            SellerInfoDGV.CellContentClick += SellerInfoDGV_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(506, 9);
            label3.Name = "label3";
            label3.Size = new Size(207, 38);
            label3.TabIndex = 48;
            label3.Text = "Admin Panel";
            // 
            // ProjectDGV
            // 
            ProjectDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProjectDGV.Location = new Point(282, 356);
            ProjectDGV.Name = "ProjectDGV";
            ProjectDGV.RowHeadersWidth = 51;
            ProjectDGV.Size = new Size(752, 250);
            ProjectDGV.TabIndex = 49;
            ProjectDGV.CellContentClick += ProjectDGV_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SandyBrown;
            label2.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(546, 324);
            label2.Name = "label2";
            label2.Size = new Size(158, 29);
            label2.TabIndex = 50;
            label2.Text = "Projects Info:";
            label2.Click += label2_Click;
            // 
            // BackbksBtn
            // 
            BackbksBtn.BackColor = Color.Transparent;
            BackbksBtn.BackgroundImage = (Image)resources.GetObject("BackbksBtn.BackgroundImage");
            BackbksBtn.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackbksBtn.ForeColor = SystemColors.Control;
            BackbksBtn.Location = new Point(1120, 809);
            BackbksBtn.Margin = new Padding(3, 4, 3, 4);
            BackbksBtn.Name = "BackbksBtn";
            BackbksBtn.Size = new Size(99, 42);
            BackbksBtn.TabIndex = 51;
            BackbksBtn.Text = "Back";
            BackbksBtn.UseVisualStyleBackColor = false;
            BackbksBtn.Click += BackbksBtn_Click;
            // 
            // HomeBtn
            // 
            HomeBtn.BackColor = Color.Transparent;
            HomeBtn.BackgroundImage = (Image)resources.GetObject("HomeBtn.BackgroundImage");
            HomeBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HomeBtn.ForeColor = SystemColors.Control;
            HomeBtn.Location = new Point(1094, 568);
            HomeBtn.Margin = new Padding(3, 4, 3, 4);
            HomeBtn.Name = "HomeBtn";
            HomeBtn.Size = new Size(95, 40);
            HomeBtn.TabIndex = 52;
            HomeBtn.Text = "Home";
            HomeBtn.UseVisualStyleBackColor = false;
            HomeBtn.Click += HomeBtn_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.ForeColor = Color.White;
            button1.Location = new Point(54, 376);
            button1.Name = "button1";
            button1.Size = new Size(112, 47);
            button1.TabIndex = 53;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AdminPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1223, 632);
            Controls.Add(button1);
            Controls.Add(HomeBtn);
            Controls.Add(BackbksBtn);
            Controls.Add(label2);
            Controls.Add(ProjectDGV);
            Controls.Add(label3);
            Controls.Add(SellerInfoDGV);
            Controls.Add(BuyerInfoDGV);
            Controls.Add(label1);
            Controls.Add(label4);
            Name = "AdminPage";
            Text = "AdminPage";
            Load += AdminPage_Load;
            ((System.ComponentModel.ISupportInitialize)BuyerInfoDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)SellerInfoDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProjectDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label1;
        private DataGridView BuyerInfoDGV;
        private DataGridView SellerInfoDGV;
        private Label label3;
        private DataGridView ProjectDGV;
        private Label label2;
        private Button BackbksBtn;
        private Button HomeBtn;
        private Button button1;
    }
}