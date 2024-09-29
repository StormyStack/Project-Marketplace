namespace WinFormsApp1
{
    partial class ProjectBuy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectBuy));
            BuyerDGV = new DataGridView();
            SearchBtn = new Button();
            BuyBtn = new Button();
            Pnametxt = new TextBox();
            label4 = new Label();
            backBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)BuyerDGV).BeginInit();
            SuspendLayout();
            // 
            // BuyerDGV
            // 
            BuyerDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BuyerDGV.Location = new Point(12, 142);
            BuyerDGV.Name = "BuyerDGV";
            BuyerDGV.RowHeadersWidth = 51;
            BuyerDGV.Size = new Size(772, 210);
            BuyerDGV.TabIndex = 51;
            BuyerDGV.CellContentClick += BuyerDGV_CellContentClick;
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = Color.Khaki;
            SearchBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchBtn.ForeColor = SystemColors.ActiveCaptionText;
            SearchBtn.Location = new Point(590, 67);
            SearchBtn.Margin = new Padding(3, 4, 3, 4);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(95, 40);
            SearchBtn.TabIndex = 50;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // BuyBtn
            // 
            BuyBtn.BackColor = Color.Khaki;
            BuyBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BuyBtn.ForeColor = SystemColors.ActiveCaptionText;
            BuyBtn.Location = new Point(145, 381);
            BuyBtn.Margin = new Padding(3, 4, 3, 4);
            BuyBtn.Name = "BuyBtn";
            BuyBtn.Size = new Size(95, 40);
            BuyBtn.TabIndex = 49;
            BuyBtn.Text = "Buy ";
            BuyBtn.UseVisualStyleBackColor = false;
            BuyBtn.Click += BuyBtn_Click;
            // 
            // Pnametxt
            // 
            Pnametxt.BackColor = Color.WhiteSmoke;
            Pnametxt.Location = new Point(26, 76);
            Pnametxt.Margin = new Padding(3, 4, 3, 4);
            Pnametxt.Name = "Pnametxt";
            Pnametxt.Size = new Size(521, 27);
            Pnametxt.TabIndex = 43;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 15.75F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(26, 41);
            label4.Name = "label4";
            label4.Size = new Size(167, 31);
            label4.TabIndex = 42;
            label4.Text = "Project Name:";
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Khaki;
            backBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backBtn.ForeColor = SystemColors.ActiveCaptionText;
            backBtn.Location = new Point(306, 381);
            backBtn.Margin = new Padding(3, 4, 3, 4);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(95, 40);
            backBtn.TabIndex = 52;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // ProjectBuy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(782, 453);
            Controls.Add(backBtn);
            Controls.Add(BuyerDGV);
            Controls.Add(SearchBtn);
            Controls.Add(BuyBtn);
            Controls.Add(Pnametxt);
            Controls.Add(label4);
            Name = "ProjectBuy";
            Text = "ProjectBuy";
            Load += ProjectBuy_Load;
            ((System.ComponentModel.ISupportInitialize)BuyerDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView BuyerDGV;
        private Button SearchBtn;
        private Button BuyBtn;
        private TextBox Pnametxt;
        private Label label4;
        private Button backBtn;
    }
}