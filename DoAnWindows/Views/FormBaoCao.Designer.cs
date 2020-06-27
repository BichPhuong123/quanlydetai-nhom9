namespace DoAnWindows.Views
{
    partial class FormBaoCao
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataBaocao = new System.Windows.Forms.DataGridView();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNhanxet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTailieu = new System.Windows.Forms.DataGridViewLinkColumn();
            this.txtLan = new System.Windows.Forms.TextBox();
            this.rtxtNhanxet = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.labelSolan = new System.Windows.Forms.Label();
            this.labelDT = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.errorLan = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTailieu = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNhanxet = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.progressHT = new System.Windows.Forms.ProgressBar();
            this.labelPercent = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelPercents = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaocao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTailieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNhanxet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(284, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "NỘI DUNG BÁO CÁO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(310, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã đề tài: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(310, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lần báo cáo: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(422, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nhận xét";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Link tài liệu";
            // 
            // dataBaocao
            // 
            this.dataBaocao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataBaocao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBaocao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID,
            this.cNhanxet,
            this.cTailieu});
            this.dataBaocao.Location = new System.Drawing.Point(12, 308);
            this.dataBaocao.Name = "dataBaocao";
            this.dataBaocao.ReadOnly = true;
            this.dataBaocao.Size = new System.Drawing.Size(776, 179);
            this.dataBaocao.TabIndex = 6;
            this.dataBaocao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataBaocao_CellClick);
            // 
            // cID
            // 
            this.cID.HeaderText = "STT";
            this.cID.Name = "cID";
            this.cID.ReadOnly = true;
            // 
            // cNhanxet
            // 
            this.cNhanxet.HeaderText = "Nhận xét";
            this.cNhanxet.Name = "cNhanxet";
            this.cNhanxet.ReadOnly = true;
            // 
            // cTailieu
            // 
            this.cTailieu.HeaderText = "Tài liệu";
            this.cTailieu.Name = "cTailieu";
            this.cTailieu.ReadOnly = true;
            // 
            // txtLan
            // 
            this.txtLan.Location = new System.Drawing.Point(145, 148);
            this.txtLan.Name = "txtLan";
            this.txtLan.Size = new System.Drawing.Size(100, 20);
            this.txtLan.TabIndex = 7;
            // 
            // rtxtNhanxet
            // 
            this.rtxtNhanxet.Location = new System.Drawing.Point(478, 148);
            this.rtxtNhanxet.Name = "rtxtNhanxet";
            this.rtxtNhanxet.Size = new System.Drawing.Size(269, 96);
            this.rtxtNhanxet.TabIndex = 10;
            this.rtxtNhanxet.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(374, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(403, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 12;
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(145, 190);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(234, 20);
            this.txtLink.TabIndex = 13;
            // 
            // labelSolan
            // 
            this.labelSolan.AutoSize = true;
            this.labelSolan.Location = new System.Drawing.Point(404, 82);
            this.labelSolan.Name = "labelSolan";
            this.labelSolan.Size = new System.Drawing.Size(35, 13);
            this.labelSolan.TabIndex = 14;
            this.labelSolan.Text = "label9";
            // 
            // labelDT
            // 
            this.labelDT.AutoSize = true;
            this.labelDT.Location = new System.Drawing.Point(375, 56);
            this.labelDT.Name = "labelDT";
            this.labelDT.Size = new System.Drawing.Size(41, 13);
            this.labelDT.TabIndex = 15;
            this.labelDT.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(72, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Lần báo cáo";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Black;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.BorderSize = 2;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(269, 256);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 31);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Black;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUpdate.FlatAppearance.BorderSize = 2;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(397, 256);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 31);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // errorLan
            // 
            this.errorLan.BlinkRate = 300;
            this.errorLan.ContainerControl = this;
            // 
            // errorTailieu
            // 
            this.errorTailieu.BlinkRate = 300;
            this.errorTailieu.ContainerControl = this;
            // 
            // errorNhanxet
            // 
            this.errorNhanxet.BlinkRate = 300;
            this.errorNhanxet.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(266, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Hoàn thành";
            // 
            // progressHT
            // 
            this.progressHT.Location = new System.Drawing.Point(338, 102);
            this.progressHT.Name = "progressHT";
            this.progressHT.Size = new System.Drawing.Size(100, 23);
            this.progressHT.TabIndex = 23;
            // 
            // labelPercent
            // 
            this.labelPercent.AutoSize = true;
            this.labelPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPercent.ForeColor = System.Drawing.Color.Red;
            this.labelPercent.Location = new System.Drawing.Point(450, 105);
            this.labelPercent.Name = "labelPercent";
            this.labelPercent.Size = new System.Drawing.Size(0, 16);
            this.labelPercent.TabIndex = 24;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelPercents
            // 
            this.labelPercents.AutoSize = true;
            this.labelPercents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPercents.ForeColor = System.Drawing.Color.Red;
            this.labelPercents.Location = new System.Drawing.Point(450, 106);
            this.labelPercents.Name = "labelPercents";
            this.labelPercents.Size = new System.Drawing.Size(25, 15);
            this.labelPercents.TabIndex = 25;
            this.labelPercents.Text = "0%";
            // 
            // FormBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.labelPercents);
            this.Controls.Add(this.labelPercent);
            this.Controls.Add(this.progressHT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelDT);
            this.Controls.Add(this.labelSolan);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rtxtNhanxet);
            this.Controls.Add(this.txtLan);
            this.Controls.Add(this.dataBaocao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormBaoCao";
            this.Text = "Báo cáo đồ án";
            ((System.ComponentModel.ISupportInitialize)(this.dataBaocao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTailieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNhanxet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DataGridView dataBaocao;
        private System.Windows.Forms.TextBox txtLan;
        private System.Windows.Forms.RichTextBox rtxtNhanxet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLink;
        public System.Windows.Forms.Label labelSolan;
        public System.Windows.Forms.Label labelDT;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ErrorProvider errorLan;
        private System.Windows.Forms.ErrorProvider errorTailieu;
        private System.Windows.Forms.ErrorProvider errorNhanxet;
        public System.Windows.Forms.Label labelPercent;
        private System.Windows.Forms.ProgressBar progressHT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNhanxet;
        private System.Windows.Forms.DataGridViewLinkColumn cTailieu;
        private System.Windows.Forms.Label labelPercents;
    }
}