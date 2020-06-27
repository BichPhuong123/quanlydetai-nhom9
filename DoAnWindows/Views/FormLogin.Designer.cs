namespace DoAnWindows.Views
{
    partial class FormLogin
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
            this.radioBtnTeacher = new System.Windows.Forms.RadioButton();
            this.radioBtnStudent = new System.Windows.Forms.RadioButton();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorID = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorLoai = new System.Windows.Forms.ErrorProvider(this.components);
            this.linkDK = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.errorID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLoai)).BeginInit();
            this.SuspendLayout();
            // 
            // radioBtnTeacher
            // 
            this.radioBtnTeacher.AutoSize = true;
            this.radioBtnTeacher.Location = new System.Drawing.Point(373, 239);
            this.radioBtnTeacher.Margin = new System.Windows.Forms.Padding(2);
            this.radioBtnTeacher.Name = "radioBtnTeacher";
            this.radioBtnTeacher.Size = new System.Drawing.Size(65, 17);
            this.radioBtnTeacher.TabIndex = 13;
            this.radioBtnTeacher.TabStop = true;
            this.radioBtnTeacher.Text = "Teacher";
            this.radioBtnTeacher.UseVisualStyleBackColor = true;
            // 
            // radioBtnStudent
            // 
            this.radioBtnStudent.AutoSize = true;
            this.radioBtnStudent.Location = new System.Drawing.Point(190, 239);
            this.radioBtnStudent.Margin = new System.Windows.Forms.Padding(2);
            this.radioBtnStudent.Name = "radioBtnStudent";
            this.radioBtnStudent.Size = new System.Drawing.Size(62, 17);
            this.radioBtnStudent.TabIndex = 12;
            this.radioBtnStudent.TabStop = true;
            this.radioBtnStudent.Text = "Student";
            this.radioBtnStudent.UseVisualStyleBackColor = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonLogin.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(164, 293);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(112, 42);
            this.buttonLogin.TabIndex = 11;
            this.buttonLogin.Text = "Đăng nhập";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(258, 180);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(176, 20);
            this.txtPassword.TabIndex = 10;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(258, 110);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(176, 20);
            this.txtID.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 183);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(249, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "ĐĂNG NHẬP";
            // 
            // errorID
            // 
            this.errorID.BlinkRate = 300;
            this.errorID.ContainerControl = this;
            // 
            // errorPassword
            // 
            this.errorPassword.BlinkRate = 300;
            this.errorPassword.ContainerControl = this;
            // 
            // errorLoai
            // 
            this.errorLoai.BlinkRate = 300;
            this.errorLoai.ContainerControl = this;
            // 
            // linkDK
            // 
            this.linkDK.AutoSize = true;
            this.linkDK.Location = new System.Drawing.Point(376, 309);
            this.linkDK.Name = "linkDK";
            this.linkDK.Size = new System.Drawing.Size(73, 13);
            this.linkDK.TabIndex = 15;
            this.linkDK.TabStop = true;
            this.linkDK.Text = "Tạo tài khoản";
            this.linkDK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDK_LinkClicked);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(641, 407);
            this.Controls.Add(this.linkDK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioBtnTeacher);
            this.Controls.Add(this.radioBtnStudent);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormLogin";
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.errorID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLoai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RadioButton radioBtnTeacher;
        public System.Windows.Forms.RadioButton radioBtnStudent;
        private System.Windows.Forms.Button buttonLogin;
        public System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorID;
        private System.Windows.Forms.ErrorProvider errorPassword;
        private System.Windows.Forms.ErrorProvider errorLoai;
        private System.Windows.Forms.LinkLabel linkDK;
    }
}