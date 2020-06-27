namespace DoAnWindows.Views
{
    partial class FormDeTai
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGV = new System.Windows.Forms.TextBox();
            this.lstSearchSV = new System.Windows.Forms.ListBox();
            this.lstSV = new System.Windows.Forms.ListBox();
            this.lstSearchGV = new System.Windows.Forms.ListBox();
            this.numSolan = new System.Windows.Forms.NumericUpDown();
            this.txtSearchSV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbLoai = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataDetai = new System.Windows.Forms.DataGridView();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSolan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBaocao = new System.Windows.Forms.DataGridViewButtonColumn();
            this.errorID = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorFrom = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorSolan = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorLoai = new System.Windows.Forms.ErrorProvider(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSolan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDetai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSolan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLoai)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Silver;
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNew.FlatAppearance.BorderSize = 2;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(679, 305);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 29);
            this.btnNew.TabIndex = 36;
            this.btnNew.Text = "Tạo mới";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Silver;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.BorderSize = 2;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(533, 305);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 29);
            this.btnDelete.TabIndex = 35;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Silver;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUpdate.FlatAppearance.BorderSize = 2;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(406, 305);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 29);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Silver;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.BorderSize = 2;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(265, 305);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 29);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtGV);
            this.groupBox1.Controls.Add(this.lstSearchSV);
            this.groupBox1.Controls.Add(this.lstSV);
            this.groupBox1.Controls.Add(this.lstSearchGV);
            this.groupBox1.Controls.Add(this.numSolan);
            this.groupBox1.Controls.Add(this.txtSearchSV);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dtTo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtFrom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbLoai);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(988, 203);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đề tài";
            // 
            // txtGV
            // 
            this.txtGV.Location = new System.Drawing.Point(721, 29);
            this.txtGV.Name = "txtGV";
            this.txtGV.Size = new System.Drawing.Size(104, 21);
            this.txtGV.TabIndex = 27;
            this.txtGV.TextChanged += new System.EventHandler(this.txtGV_TextChanged_1);
            // 
            // lstSearchSV
            // 
            this.lstSearchSV.FormattingEnabled = true;
            this.lstSearchSV.ItemHeight = 15;
            this.lstSearchSV.Location = new System.Drawing.Point(840, 137);
            this.lstSearchSV.Name = "lstSearchSV";
            this.lstSearchSV.Size = new System.Drawing.Size(104, 64);
            this.lstSearchSV.TabIndex = 26;
            this.lstSearchSV.Visible = false;
            this.lstSearchSV.DoubleClick += new System.EventHandler(this.lstSearchSV_DoubleClick);
            // 
            // lstSV
            // 
            this.lstSV.FormattingEnabled = true;
            this.lstSV.ItemHeight = 15;
            this.lstSV.Location = new System.Drawing.Point(721, 118);
            this.lstSV.Name = "lstSV";
            this.lstSV.Size = new System.Drawing.Size(104, 79);
            this.lstSV.TabIndex = 25;
            this.lstSV.SelectedIndexChanged += new System.EventHandler(this.lstSV_SelectedIndexChanged);
            this.lstSV.DoubleClick += new System.EventHandler(this.lstSV_DoubleClick);
            // 
            // lstSearchGV
            // 
            this.lstSearchGV.FormattingEnabled = true;
            this.lstSearchGV.ItemHeight = 15;
            this.lstSearchGV.Location = new System.Drawing.Point(721, 50);
            this.lstSearchGV.Name = "lstSearchGV";
            this.lstSearchGV.Size = new System.Drawing.Size(104, 64);
            this.lstSearchGV.TabIndex = 24;
            this.lstSearchGV.Visible = false;
            this.lstSearchGV.SelectedIndexChanged += new System.EventHandler(this.lstSearchGV_SelectedIndexChanged);
            this.lstSearchGV.DoubleClick += new System.EventHandler(this.lstSearchGV_DoubleClick);
            // 
            // numSolan
            // 
            this.numSolan.Location = new System.Drawing.Point(429, 139);
            this.numSolan.Name = "numSolan";
            this.numSolan.Size = new System.Drawing.Size(120, 21);
            this.numSolan.TabIndex = 23;
            // 
            // txtSearchSV
            // 
            this.txtSearchSV.Location = new System.Drawing.Point(840, 118);
            this.txtSearchSV.Name = "txtSearchSV";
            this.txtSearchSV.Size = new System.Drawing.Size(104, 21);
            this.txtSearchSV.TabIndex = 19;
            this.txtSearchSV.TextChanged += new System.EventHandler(this.txtSearchSV_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(633, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "SV thực hiện";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(630, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "GV hướng dẫn";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // dtTo
            // 
            this.dtTo.CustomFormat = "dd/MM,yyyy HH:mm:ss tt";
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(396, 96);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(200, 21);
            this.dtTo.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Kết thúc";
            // 
            // dtFrom
            // 
            this.dtFrom.CustomFormat = "dd/MM,yyyy HH:mm:ss tt";
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(396, 51);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(200, 21);
            this.dtFrom.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Bắt đầu";
            // 
            // cbLoai
            // 
            this.cbLoai.FormattingEnabled = true;
            this.cbLoai.Items.AddRange(new object[] {
            "Đồ án môn học",
            "Tiểu luận chuyên ngành",
            "Đồ án tốt nghiệp"});
            this.cbLoai.Location = new System.Drawing.Point(118, 137);
            this.cbLoai.Name = "cbLoai";
            this.cbLoai.Size = new System.Drawing.Size(154, 23);
            this.cbLoai.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(118, 96);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(154, 21);
            this.txtName.TabIndex = 7;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.Location = new System.Drawing.Point(118, 53);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(154, 21);
            this.txtID.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(319, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số lần báo cáo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Loại đề tài";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên đề tài";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đề tài";
            // 
            // dataDetai
            // 
            this.dataDetai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataDetai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataDetai.BackgroundColor = System.Drawing.Color.White;
            this.dataDetai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDetai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID,
            this.cName,
            this.cLoai,
            this.cFrom,
            this.cTo,
            this.cSolan,
            this.cGV,
            this.cSV,
            this.cBaocao});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataDetai.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataDetai.Location = new System.Drawing.Point(1, 368);
            this.dataDetai.Name = "dataDetai";
            this.dataDetai.ReadOnly = true;
            this.dataDetai.Size = new System.Drawing.Size(1042, 150);
            this.dataDetai.TabIndex = 37;
            this.dataDetai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDetai_CellClick);
            this.dataDetai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDetai_CellContentClick);
            // 
            // cID
            // 
            this.cID.DataPropertyName = "MaDeTai";
            this.cID.HeaderText = "Mã đề tài";
            this.cID.Name = "cID";
            this.cID.ReadOnly = true;
            // 
            // cName
            // 
            this.cName.DataPropertyName = "TenDeTai";
            this.cName.HeaderText = "Tên đề tài";
            this.cName.Name = "cName";
            this.cName.ReadOnly = true;
            // 
            // cLoai
            // 
            this.cLoai.DataPropertyName = "LoaiDeTai";
            this.cLoai.HeaderText = "Loại đề tài";
            this.cLoai.Name = "cLoai";
            this.cLoai.ReadOnly = true;
            // 
            // cFrom
            // 
            this.cFrom.DataPropertyName = "TGBD";
            this.cFrom.HeaderText = "Thời gian bắt đầu";
            this.cFrom.Name = "cFrom";
            this.cFrom.ReadOnly = true;
            // 
            // cTo
            // 
            this.cTo.DataPropertyName = "TGKT";
            this.cTo.HeaderText = "Thời gian kết thúc";
            this.cTo.Name = "cTo";
            this.cTo.ReadOnly = true;
            // 
            // cSolan
            // 
            this.cSolan.DataPropertyName = "Solan";
            this.cSolan.HeaderText = "Số lần báo cáo";
            this.cSolan.Name = "cSolan";
            this.cSolan.ReadOnly = true;
            // 
            // cGV
            // 
            this.cGV.DataPropertyName = "MaGV";
            this.cGV.HeaderText = "GV hướng dẫn";
            this.cGV.Name = "cGV";
            this.cGV.ReadOnly = true;
            // 
            // cSV
            // 
            this.cSV.DataPropertyName = "MaSV";
            this.cSV.HeaderText = "SV thực hiện";
            this.cSV.Name = "cSV";
            this.cSV.ReadOnly = true;
            // 
            // cBaocao
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.cBaocao.DefaultCellStyle = dataGridViewCellStyle1;
            this.cBaocao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBaocao.HeaderText = "";
            this.cBaocao.Name = "cBaocao";
            this.cBaocao.ReadOnly = true;
            this.cBaocao.Text = "Báo cáo";
            this.cBaocao.UseColumnTextForButtonValue = true;
            // 
            // errorID
            // 
            this.errorID.BlinkRate = 300;
            this.errorID.ContainerControl = this;
            // 
            // errorName
            // 
            this.errorName.BlinkRate = 300;
            this.errorName.ContainerControl = this;
            // 
            // errorFrom
            // 
            this.errorFrom.BlinkRate = 300;
            this.errorFrom.ContainerControl = this;
            // 
            // errorTo
            // 
            this.errorTo.BlinkRate = 300;
            this.errorTo.ContainerControl = this;
            // 
            // errorSolan
            // 
            this.errorSolan.BlinkRate = 300;
            this.errorSolan.ContainerControl = this;
            // 
            // errorLoai
            // 
            this.errorLoai.BlinkRate = 300;
            this.errorLoai.ContainerControl = this;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(513, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 29);
            this.label9.TabIndex = 38;
            this.label9.Text = "ĐỀ TÀI";
            // 
            // FormDeTai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1046, 530);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataDetai);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormDeTai";
            this.Text = "Quản lý đề tài";
            this.Load += new System.EventHandler(this.FormDeTai_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSolan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDetai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSolan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLoai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnNew;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLoai;
        private System.Windows.Forms.DataGridView dataDetai;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSearchSV;
        private System.Windows.Forms.ErrorProvider errorID;
        private System.Windows.Forms.ErrorProvider errorName;
        private System.Windows.Forms.ErrorProvider errorFrom;
        private System.Windows.Forms.ErrorProvider errorTo;
        private System.Windows.Forms.ErrorProvider errorSolan;
        private System.Windows.Forms.ErrorProvider errorLoai;
        private System.Windows.Forms.NumericUpDown numSolan;
        private System.Windows.Forms.ListBox lstSearchSV;
        private System.Windows.Forms.ListBox lstSV;
        private System.Windows.Forms.ListBox lstSearchGV;
        private System.Windows.Forms.TextBox txtGV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSolan;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSV;
        private System.Windows.Forms.DataGridViewButtonColumn cBaocao;
    }
}