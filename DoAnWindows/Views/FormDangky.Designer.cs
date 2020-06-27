namespace DoAnWindows.Views
{
    partial class FormDangky
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
            this.label3 = new System.Windows.Forms.Label();
            this.radioBtnTeacher = new System.Windows.Forms.RadioButton();
            this.radioBtnStudent = new System.Windows.Forms.RadioButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDK = new System.Windows.Forms.Button();
            this.errorLoai = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorID = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPassword = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorLoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(211, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "ĐĂNG KÝ";
            // 
            // radioBtnTeacher
            // 
            this.radioBtnTeacher.AutoSize = true;
            this.radioBtnTeacher.Location = new System.Drawing.Point(335, 248);
            this.radioBtnTeacher.Margin = new System.Windows.Forms.Padding(2);
            this.radioBtnTeacher.Name = "radioBtnTeacher";
            this.radioBtnTeacher.Size = new System.Drawing.Size(65, 17);
            this.radioBtnTeacher.TabIndex = 20;
            this.radioBtnTeacher.TabStop = true;
            this.radioBtnTeacher.Text = "Teacher";
            this.radioBtnTeacher.UseVisualStyleBackColor = true;
            // 
            // radioBtnStudent
            // 
            this.radioBtnStudent.AutoSize = true;
            this.radioBtnStudent.Location = new System.Drawing.Point(152, 248);
            this.radioBtnStudent.Margin = new System.Windows.Forms.Padding(2);
            this.radioBtnStudent.Name = "radioBtnStudent";
            this.radioBtnStudent.Size = new System.Drawing.Size(62, 17);
            this.radioBtnStudent.TabIndex = 19;
            this.radioBtnStudent.TabStop = true;
            this.radioBtnStudent.Text = "Student";
            this.radioBtnStudent.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(220, 189);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(176, 20);
            this.txtPassword.TabIndex = 18;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(220, 119);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(176, 20);
            this.txtID.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tên đăng nhập";
            // 
            // buttonDK
            // 
            this.buttonDK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDK.Location = new System.Drawing.Point(220, 299);
            this.buttonDK.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDK.Name = "buttonDK";
            this.buttonDK.Size = new System.Drawing.Size(112, 42);
            this.buttonDK.TabIndex = 23;
            this.buttonDK.Text = "Đăng ký";
            this.buttonDK.UseVisualStyleBackColor = false;
            this.buttonDK.Click += new System.EventHandler(this.buttonDK_Click);
            // 
            // errorLoai
            // 
            this.errorLoai.BlinkRate = 300;
            this.errorLoai.ContainerControl = this;
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
            // FormDangky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(577, 404);
            this.Controls.Add(this.buttonDK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioBtnTeacher);
            this.Controls.Add(this.radioBtnStudent);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDangky";
            this.Text = "Đăng ký";
            ((System.ComponentModel.ISupportInitialize)(this.errorLoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioBtnTeacher;
        private System.Windows.Forms.RadioButton radioBtnStudent;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDK;
        private System.Windows.Forms.ErrorProvider errorLoai;
        private System.Windows.Forms.ErrorProvider errorID;
        private System.Windows.Forms.ErrorProvider errorPassword;
    }
}