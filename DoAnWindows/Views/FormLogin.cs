using DoAnWindows.Controller;
using DoAnWindows.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnWindows.Views
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Trim().Length <= 0 || txtPassword.Text.Trim().Length <= 0||(radioBtnStudent.Checked == false && radioBtnTeacher.Checked == false) )
            {

                if (txtID.Text.Trim().Length <= 0)
                    errorID.SetError(txtID, "Phải nhập ID");
                else
                    errorID.SetError(txtID, "");
                if (txtPassword.Text.Trim().Length <= 0)
                    errorPassword.SetError(txtPassword, "Phải nhập mật khẩu");
                else
                    errorPassword.SetError(txtPassword, "");
                if (radioBtnStudent.Checked == false && radioBtnTeacher.Checked == false)
                    errorLoai.SetError(radioBtnTeacher, "Phải chọn loại tài khoản");
                else
                    errorLoai.SetError(radioBtnTeacher, "");
                
                return;
            }

            errorID.SetError(txtID, "");
            errorPassword.SetError(txtPassword, "");
            errorLoai.SetError(radioBtnTeacher, "");
            
           if(UserController.getuser(txtID.Text.Trim(),txtPassword.Text.Trim()) ==null)
            {
                MessageBox.Show("Kiểm tra ID và mật khẩu");
                return;
            }
           else
            {
                if (radioBtnStudent.Checked == true)
                {
                    if (SVController.getSV(txtID.Text.Trim()) != null)
                    {
                        USER user = new USER();
                        user.ID = UserController.getIDfromDB() + 1;
                        user.MaUser = txtID.Text.Trim();
                        user.Pass = txtPassword.Text;
                        

                        if (UserController.getUser(txtID.Text.Trim()).MaUser != user.MaUser)
                        {
                            UserController.AddUser(user);
                            this.Hide();
                        }

                        //main.Show();
                        //main.btnSignIn.Text = txtID.Text.Trim();
                        //main.fileToolStripMenuItem.Enabled = true;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Kiểm tra ID và mật khẩu");
                        return;
                    }
                }
                if (radioBtnTeacher.Checked == true)
                {
                    if (GVController.getGV(txtID.Text.Trim()) != null)
                    {
                        USER user = new USER();
                        user.ID = UserController.getIDfromDB() + 1;
                        user.MaUser = txtID.Text.Trim();
                        user.Pass = txtPassword.Text;
                        if(UserController.getUser(txtID.Text.Trim()).MaUser!= user.MaUser)
                        {
                            UserController.AddUser(user);
                            this.Hide();
                        }
                        

                       
                       
                        //main.btnSignIn.Text = txtID.Text.Trim();
                        
                        //main.fileToolStripMenuItem.Enabled = true;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Kiểm tra ID và mật khẩu");
                        return;
                    }
                }
               
               
            }
        }

        private void linkDK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDangky formdk = new FormDangky();
            formdk.Show();
            
        }
    }
}
