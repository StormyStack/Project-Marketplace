namespace WinFormsApp1
{
    partial class projectsell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(projectsell));
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            Pnametxt = new TextBox();
            Ctgrytxt = new TextBox();
            Pricetxt = new TextBox();
            ResetBtn = new Button();
            DltBtn = new Button();
            EditBtn = new Button();
            AddBtn = new Button();
            SellerDGV = new DataGridView();
            Back = new Button();
            Homebtn = new Button();
            ((System.ComponentModel.ISupportInitialize)SellerDGV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 13.8F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(23, 124);
            label1.Name = "label1";
            label1.Size = new Size(65, 26);
            label1.TabIndex = 10;
            label1.Text = "Price:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 13.8F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(23, 74);
            label2.Name = "label2";
            label2.Size = new Size(101, 26);
            label2.TabIndex = 11;
            label2.Text = "Category:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 13.8F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(23, 25);
            label4.Name = "label4";
            label4.Size = new Size(143, 26);
            label4.TabIndex = 13;
            label4.Text = "Project Name:";
            // 
            // Pnametxt
            // 
            Pnametxt.BackColor = Color.WhiteSmoke;
            Pnametxt.Location = new Point(163, 26);
            Pnametxt.Margin = new Padding(3, 4, 3, 4);
            Pnametxt.Name = "Pnametxt";
            Pnametxt.Size = new Size(244, 27);
            Pnametxt.TabIndex = 30;
            Pnametxt.TextChanged += Pnametxt_TextChanged;
            // 
            // Ctgrytxt
            // 
            Ctgrytxt.BackColor = Color.WhiteSmoke;
            Ctgrytxt.Location = new Point(163, 74);
            Ctgrytxt.Margin = new Padding(3, 4, 3, 4);
            Ctgrytxt.Name = "Ctgrytxt";
            Ctgrytxt.Size = new Size(244, 27);
            Ctgrytxt.TabIndex = 32;
            // 
            // Pricetxt
            // 
            Pricetxt.BackColor = Color.WhiteSmoke;
            Pricetxt.Location = new Point(163, 124);
            Pricetxt.Margin = new Padding(3, 4, 3, 4);
            Pricetxt.Name = "Pricetxt";
            Pricetxt.Size = new Size(244, 27);
            Pricetxt.TabIndex = 33;
            Pricetxt.TextChanged += Pricetxt_TextChanged;
            // 
            // ResetBtn
            // 
            ResetBtn.BackColor = Color.Khaki;
            ResetBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ResetBtn.ForeColor = SystemColors.ActiveCaptionText;
            ResetBtn.Location = new Point(506, 110);
            ResetBtn.Margin = new Padding(3, 4, 3, 4);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(95, 40);
            ResetBtn.TabIndex = 34;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = false;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // DltBtn
            // 
            DltBtn.BackColor = Color.Khaki;
            DltBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DltBtn.ForeColor = SystemColors.ActiveCaptionText;
            DltBtn.Location = new Point(643, 110);
            DltBtn.Margin = new Padding(3, 4, 3, 4);
            DltBtn.Name = "DltBtn";
            DltBtn.Size = new Size(95, 40);
            DltBtn.TabIndex = 35;
            DltBtn.Text = "Delete";
            DltBtn.UseVisualStyleBackColor = false;
            DltBtn.Click += DltBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.Khaki;
            EditBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EditBtn.ForeColor = SystemColors.ActiveCaptionText;
            EditBtn.Location = new Point(643, 26);
            EditBtn.Margin = new Padding(3, 4, 3, 4);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(95, 40);
            EditBtn.TabIndex = 36;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.Khaki;
            AddBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddBtn.ForeColor = SystemColors.ActiveCaptionText;
            AddBtn.Location = new Point(506, 26);
            AddBtn.Margin = new Padding(3, 4, 3, 4);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(95, 40);
            AddBtn.TabIndex = 37;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // SellerDGV
            // 
            SellerDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SellerDGV.Location = new Point(12, 203);
            SellerDGV.Name = "SellerDGV";
            SellerDGV.RowHeadersWidth = 51;
            SellerDGV.Size = new Size(634, 225);
            SellerDGV.TabIndex = 38;
            SellerDGV.CellClick += SellerDGV_CellContentClick;
            SellerDGV.CellContentClick += SellerDGV_CellContentClick;
            // 
            // Back
            // 
            Back.BackColor = Color.Khaki;
            Back.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Back.ForeColor = Color.Black;
            Back.Location = new Point(694, 330);
            Back.Margin = new Padding(3, 4, 3, 4);
            Back.Name = "Back";
            Back.Size = new Size(95, 40);
            Back.TabIndex = 39;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // Homebtn
            // 
            Homebtn.BackColor = Color.Khaki;
            Homebtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Homebtn.ForeColor = Color.Black;
            Homebtn.Location = new Point(694, 388);
            Homebtn.Margin = new Padding(3, 4, 3, 4);
            Homebtn.Name = "Homebtn";
            Homebtn.Size = new Size(95, 40);
            Homebtn.TabIndex = 40;
            Homebtn.Text = "Home";
            Homebtn.UseVisualStyleBackColor = false;
            Homebtn.Click += Homebtn_Click;
            // 
            // projectsell
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(782, 453);
            Controls.Add(Homebtn);
            Controls.Add(Back);
            Controls.Add(SellerDGV);
            Controls.Add(AddBtn);
            Controls.Add(EditBtn);
            Controls.Add(DltBtn);
            Controls.Add(ResetBtn);
            Controls.Add(Pricetxt);
            Controls.Add(Ctgrytxt);
            Controls.Add(Pnametxt);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "projectsell";
            Text = "projectsell";
            Load += projectsell_Load;
            ((System.ComponentModel.ISupportInitialize)SellerDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox Pnametxt;
        private TextBox Ctgrytxt;
        private TextBox Pricetxt;
        private Button ResetBtn;
        private Button DltBtn;
        private Button EditBtn;
        private Button AddBtn;
        private DataGridView SellerDGV;
        private Button Back;
        private Button Homebtn;
    }
}