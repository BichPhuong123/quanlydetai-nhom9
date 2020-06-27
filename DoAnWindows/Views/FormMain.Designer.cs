namespace DoAnWindows.Views
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mGV = new System.Windows.Forms.ToolStripMenuItem();
            this.mSV = new System.Windows.Forms.ToolStripMenuItem();
            this.mDetai = new System.Windows.Forms.ToolStripMenuItem();
            this.mHome = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSV = new System.Windows.Forms.Button();
            this.btnDetai = new System.Windows.Forms.Button();
            this.btnGV = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstSearchDT = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listSearch = new System.Windows.Forms.ListView();
            this.cDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cGV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.mHome});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1005, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mGV,
            this.mSV,
            this.mDetai});
            this.fileToolStripMenuItem.Enabled = false;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mGV
            // 
            this.mGV.Name = "mGV";
            this.mGV.Size = new System.Drawing.Size(166, 22);
            this.mGV.Text = "Quản lý giáo viên";
            this.mGV.Click += new System.EventHandler(this.mGV_Click);
            // 
            // mSV
            // 
            this.mSV.Name = "mSV";
            this.mSV.Size = new System.Drawing.Size(166, 22);
            this.mSV.Text = "Quản lý sinh viên";
            this.mSV.Click += new System.EventHandler(this.mSV_Click);
            // 
            // mDetai
            // 
            this.mDetai.Name = "mDetai";
            this.mDetai.Size = new System.Drawing.Size(166, 22);
            this.mDetai.Text = "Quản lý đề tài";
            this.mDetai.Click += new System.EventHandler(this.mDetai_Click);
            // 
            // mHome
            // 
            this.mHome.Name = "mHome";
            this.mHome.Size = new System.Drawing.Size(52, 20);
            this.mHome.Text = "Home";
            this.mHome.Click += new System.EventHandler(this.mHome_Click);
            // 
            // tabMain
            // 
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabMain.Location = new System.Drawing.Point(0, 24);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1005, 28);
            this.tabMain.TabIndex = 2;
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabMain_SelectedIndexChanged);
            // 
            // btnSignIn
            // 
            this.btnSignIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSignIn.BackColor = System.Drawing.Color.Black;
            this.btnSignIn.FlatAppearance.BorderSize = 0;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.Location = new System.Drawing.Point(921, 24);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(82, 28);
            this.btnSignIn.TabIndex = 4;
            this.btnSignIn.Text = "Đăng nhập";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnSV);
            this.panel1.Controls.Add(this.btnDetai);
            this.panel1.Controls.Add(this.btnGV);
            this.panel1.Location = new System.Drawing.Point(1, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 450);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(30, 303);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 107);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(30, 152);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 112);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnSV
            // 
            this.btnSV.Enabled = false;
            this.btnSV.FlatAppearance.BorderSize = 0;
            this.btnSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSV.ForeColor = System.Drawing.Color.Black;
            this.btnSV.Location = new System.Drawing.Point(30, 270);
            this.btnSV.Name = "btnSV";
            this.btnSV.Size = new System.Drawing.Size(101, 23);
            this.btnSV.TabIndex = 3;
            this.btnSV.Text = "Sinh viên";
            this.btnSV.UseVisualStyleBackColor = true;
            this.btnSV.Click += new System.EventHandler(this.btnSV_Click);
            // 
            // btnDetai
            // 
            this.btnDetai.Enabled = false;
            this.btnDetai.FlatAppearance.BorderSize = 0;
            this.btnDetai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetai.ForeColor = System.Drawing.Color.Black;
            this.btnDetai.Location = new System.Drawing.Point(30, 416);
            this.btnDetai.Name = "btnDetai";
            this.btnDetai.Size = new System.Drawing.Size(101, 23);
            this.btnDetai.TabIndex = 2;
            this.btnDetai.Text = "Đề tài";
            this.btnDetai.UseVisualStyleBackColor = true;
            this.btnDetai.Click += new System.EventHandler(this.btnDetai_Click);
            // 
            // btnGV
            // 
            this.btnGV.Enabled = false;
            this.btnGV.FlatAppearance.BorderSize = 0;
            this.btnGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGV.ForeColor = System.Drawing.Color.Black;
            this.btnGV.Location = new System.Drawing.Point(11, 125);
            this.btnGV.Name = "btnGV";
            this.btnGV.Size = new System.Drawing.Size(127, 23);
            this.btnGV.TabIndex = 0;
            this.btnGV.Text = "Giáo viên";
            this.btnGV.UseVisualStyleBackColor = true;
            this.btnGV.Click += new System.EventHandler(this.btnGV_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(0, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(275, 20);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Black;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearch.FlatAppearance.BorderSize = 2;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(0, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 31);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.lstSearchDT);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Location = new System.Drawing.Point(446, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(276, 120);
            this.panel2.TabIndex = 10;
            // 
            // lstSearchDT
            // 
            this.lstSearchDT.FormattingEnabled = true;
            this.lstSearchDT.Location = new System.Drawing.Point(0, 23);
            this.lstSearchDT.Name = "lstSearchDT";
            this.lstSearchDT.Size = new System.Drawing.Size(276, 95);
            this.lstSearchDT.TabIndex = 7;
            this.lstSearchDT.Visible = false;
            this.lstSearchDT.DoubleClick += new System.EventHandler(this.lstSearchDT_DoubleClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Location = new System.Drawing.Point(728, 105);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(77, 31);
            this.panel3.TabIndex = 11;
            // 
            // listSearch
            // 
            this.listSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.listSearch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cDT,
            this.cGV,
            this.cSV,
            this.cTT});
            this.listSearch.HideSelection = false;
            this.listSearch.Location = new System.Drawing.Point(286, 260);
            this.listSearch.Name = "listSearch";
            this.listSearch.Size = new System.Drawing.Size(615, 154);
            this.listSearch.TabIndex = 13;
            this.listSearch.UseCompatibleStateImageBehavior = false;
            this.listSearch.View = System.Windows.Forms.View.Details;
            this.listSearch.Visible = false;
            // 
            // cDT
            // 
            this.cDT.Text = "Mã đề tài";
            this.cDT.Width = 95;
            // 
            // cGV
            // 
            this.cGV.Text = "Mã giáo viên";
            this.cGV.Width = 146;
            // 
            // cSV
            // 
            this.cSV.Text = "Sinh viên thực hiện";
            this.cSV.Width = 232;
            // 
            // cTT
            // 
            this.cTT.Text = "Hoàn thành";
            this.cTT.Width = 138;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1005, 504);
            this.Controls.Add(this.listSearch);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Quản lý đồ án";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.MdiChildActivate += new System.EventHandler(this.FormMain_MdiChildActivate);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mGV;
        private System.Windows.Forms.ToolStripMenuItem mSV;
        private System.Windows.Forms.ToolStripMenuItem mDetai;
        private System.Windows.Forms.ToolStripMenuItem mHome;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.Button btnSV;
        public System.Windows.Forms.Button btnDetai;
        public System.Windows.Forms.Button btnGV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView listSearch;
        private System.Windows.Forms.ColumnHeader cDT;
        private System.Windows.Forms.ColumnHeader cGV;
        private System.Windows.Forms.ColumnHeader cSV;
        private System.Windows.Forms.ColumnHeader cTT;
        private System.Windows.Forms.ListBox lstSearchDT;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}



