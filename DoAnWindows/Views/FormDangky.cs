using DoAnWindows.Controller;
using DoAnWindows.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnWindows.Views
{
    public partial class FormDangky : Form
    {
        public FormDangky()
        {
            InitializeComponent();
        }

        private void buttonDK_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Trim().Length <= 0 || txtPassword.Text.Trim().Length <= 0 || (radioBtnStudent.Checked == false && radioBtnTeacher.Checked == false))
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
            if(radioBtnStudent.Checked==true)
            {
                if (SVController.getSV(txtID.Text.Trim()) != null )
                {
                    USER user = new USER();
                    user.ID = UserController.getIDfromDB() + 1;
                    user.MaUser = txtID.Text.Trim();
                    user.Pass = txtPassword.Text;
                    UserController.AddUser(user);
                    MessageBox.Show("Tạo tài khoản thành công");
                    this.Hide();
                    return;
                }
                else
                {
                    MessageBox.Show("Kiểm tra thông tin User");
                }
            }
            if(radioBtnTeacher.Checked==true)
            {
                if (GVController.getGV(txtID.Text.Trim()) != null)
                {
                    USER user = new USER();
                    user.ID = UserController.getIDfromDB() + 1;
                    user.MaUser = txtID.Text.Trim();
                    user.Pass = txtPassword.Text;
                    UserController.AddUser(user);
                    MessageBox.Show("Tạo tài khoản thành công");
                    this.Hide();
                    return;
                }
                else
                {
                    MessageBox.Show("Kiểm tra thông tin User");
                }
            }
            

        }
    }
}
