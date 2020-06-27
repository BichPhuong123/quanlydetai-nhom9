using DoAnWindows.Controller;
using DoAnWindows.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnWindows.Views
{
    public partial class FormGV : Form
    {
        public FormGV()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLYDOANDataSet.GIAOVIEN' table. You can move, or remove it, as needed.
            //this.gIAOVIENTableAdapter.Fill(this.qUANLYDOANDataSet.GIAOVIEN);
            string displayDT;
            List<GIAOVIEN> lstGV = GVController.getListGV();

            for (int i = 0; i < lstGV.Count; i++)
            {

                dataGV.Rows.Add(lstGV[i]);
                dataGV.Rows[i].Cells[0].Value = lstGV[i].MaGV;
                dataGV.Rows[i].Cells[1].Value = lstGV[i].HoTen;
                dataGV.Rows[i].Cells[2].Value = lstGV[i].Phai;
                dataGV.Rows[i].Cells[3].Value = lstGV[i].Ngaysinh;
                dataGV.Rows[i].Cells[4].Value = lstGV[i].SDT;
                dataGV.Rows[i].Cells[5].Value = lstGV[i].Email;
                displayDT = "";
                foreach (DETAI dt in lstGV[i].DETAIs)
                {
                    displayDT = displayDT + dt + "   ";
                }
                dataGV.Rows[i].Cells[6].Value = displayDT;


            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Trim().Length <= 0 || txtName.Text.Trim().Length <= 0 || (rbMale.Checked==false&&rbFemale.Checked==false)|| dtBirthday.Value >= DateTime.Now || txtPhone.Text.Trim().Length <= 0 || txtEmail.Text.Trim().Length <= 0|| GVController.getGV(txtID.Text.Trim()) != null)
            {
                if (txtID.Text.Trim().Length <= 0)
                    errorID.SetError(txtID, "Phải nhập mã giáo viên");
                else if (GVController.getGV(txtID.Text.Trim()) != null)
                {
                    errorID.SetError(txtID, "Mã giáo viên đã tồn tại");
                    
                }
                else
                    errorID.SetError(txtID, "");
                if (txtName.Text.Trim().Length <= 0)
                    errorName.SetError(txtName, "Phải nhập họ tên");
                else
                    errorName.SetError(txtName, "");
                if (dtBirthday.Value >= DateTime.Now)
                    errorBirthday.SetError(dtBirthday, "Ngày sinh không hợp lệ");
                else
                    errorBirthday.SetError(dtBirthday, "");
                if (rbMale.Checked == false && rbFemale.Checked == false)
                    errorGioitinh.SetError(rbFemale, "Phải chọn giới tính");
                else
                    errorGioitinh.SetError(rbFemale, "");
                if (txtPhone.Text.Trim().Length <= 0)
                    errorPhone.SetError(txtPhone, "Phải nhập số điện thoại");
                else
                    errorPhone.SetError(txtPhone, "");
                if (txtEmail.Text.Trim().Length <= 0)
                    errorEmail.SetError(txtEmail, "Phải nhập Email");
                else
                    errorEmail.SetError(txtEmail, "");
                return;
            }
            errorID.SetError(txtID, "");
            errorName.SetError(txtName, "");
            errorGioitinh.SetError(rbFemale, "");
            errorBirthday.SetError(dtBirthday, "");
            errorPhone.SetError(txtPhone, "");
            errorEmail.SetError(txtEmail, "");
            GIAOVIEN GV = new GIAOVIEN();
            GV.MaGV= txtID.Text.Trim();
            GV.HoTen = txtName.Text.Trim();
            if(rbMale.Checked==true)
            {
                GV.Phai = rbMale.Text;
            }
            if (rbFemale.Checked == true)
            {
                GV.Phai = rbFemale.Text;
            }
            
            GV.Ngaysinh = DateTime.Parse(dtBirthday.Value.ToString("MM/dd/yyyy"));
            GV.SDT = txtPhone.Text.Trim();
            GV.Email = txtEmail.Text.Trim();
            if (pictureBoxAvt.Image != null)
            {
                MemoryStream stream = new MemoryStream();
                pictureBoxAvt.Image.Save(stream, ImageFormat.Jpeg);
                GV.Picture = stream.ToArray();
            }
           

            //them user vao DB
            if (GVController.AddGV(GV) == false)
            {
                MessageBox.Show("Lỗi thêm giáo viên");
                return;
            }
            int i = dataGV.Rows.Count - 1;
            dataGV.Rows.Add(GV);
            dataGV.Rows[i].Cells[0].Value = GV.MaGV;
            dataGV.Rows[i].Cells[1].Value = GV.HoTen;
            dataGV.Rows[i].Cells[2].Value = GV.Phai;
            dataGV.Rows[i].Cells[3].Value = GV.Ngaysinh;
            dataGV.Rows[i].Cells[4].Value = GV.SDT;
            dataGV.Rows[i].Cells[5].Value = GV.Email;
            txtID.Clear();
            txtName.Clear();
            if (rbMale.Checked == true)
            {
                rbMale.Checked = false;
            }
            if (rbFemale.Checked == true)
            {
                rbFemale.Checked = false;
            }
            dtBirthday.ResetText();
            txtPhone.Clear();
            txtEmail.Clear();
            pictureBoxAvt.Image = null;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGV.SelectedRows.Count < 0)
                return;
            txtID.Enabled = true;
            if (txtName.Text.Trim().Length <= 0 || (rbMale.Checked == false && rbFemale.Checked == false) || dtBirthday.Value >= DateTime.Now || txtPhone.Text.Trim().Length <= 0 || txtEmail.Text.Trim().Length <= 0 )
            {
              
                if (txtName.Text.Trim().Length <= 0)
                    errorName.SetError(txtName, "Phải nhập họ tên");
                else
                    errorName.SetError(txtName, "");
                if (dtBirthday.Value >= DateTime.Now)
                    errorBirthday.SetError(dtBirthday, "Ngày sinh không hợp lệ");
                else
                    errorBirthday.SetError(dtBirthday, "");
                if (rbMale.Checked == false && rbFemale.Checked == false)
                    errorGioitinh.SetError(rbFemale, "Phải chọn giới tính");
                else
                    errorGioitinh.SetError(rbFemale, "");
                if (txtPhone.Text.Trim().Length <= 0)
                    errorPhone.SetError(txtPhone, "Phải nhập số điện thoại");
                else
                    errorPhone.SetError(txtPhone, "");
                if (txtEmail.Text.Trim().Length <= 0)
                    errorEmail.SetError(txtEmail, "Phải nhập Email");
                else
                    errorEmail.SetError(txtEmail, "");
                return;
            }
           
            errorName.SetError(txtName, "");
            errorGioitinh.SetError(rbFemale, "");
            errorBirthday.SetError(dtBirthday, "");
            errorPhone.SetError(txtPhone, "");
            errorEmail.SetError(txtEmail, "");
           
            GIAOVIEN gv = GVController.getGV(dataGV.CurrentRow.Cells[0].Value.ToString());
            gv.HoTen = txtName.Text.Trim();
            if (rbMale.Checked == true)
            {
                gv.Phai = rbMale.Text;
            }
            if (rbFemale.Checked == true)
            {
                gv.Phai = rbFemale.Text;
            }

            gv.Ngaysinh = DateTime.Parse(dtBirthday.Value.ToString("MM/dd/yyyy"));
            gv.SDT = txtPhone.Text.Trim();
            gv.Email = txtEmail.Text.Trim();
            if (pictureBoxAvt.Image != null)
            {
                MemoryStream stream = new MemoryStream();
                pictureBoxAvt.Image.Save(stream, ImageFormat.Jpeg);
                gv.Picture = stream.ToArray();
            }

            GVController.UpdateGV(gv);
            dataGV.CurrentRow.Cells[0].Value = gv.MaGV;
            dataGV.CurrentRow.Cells[1].Value = gv.HoTen;
            dataGV.CurrentRow.Cells[2].Value = gv.Phai;
            dataGV.CurrentRow.Cells[3].Value = gv.Ngaysinh;
            dataGV.CurrentRow.Cells[4].Value = gv.SDT;
            dataGV.CurrentRow.Cells[5].Value = gv.Email;
            txtID.Clear();
            txtName.Clear();
            if (rbMale.Checked == true)
            {
                rbMale.Checked = false;
            }
            if (rbFemale.Checked == true)
            {
                rbFemale.Checked = false;
            }
            dtBirthday.ResetText();
            txtPhone.Clear();
            txtEmail.Clear();
            pictureBoxAvt.Image = null;
        }

        private void dataGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                errorID.SetError(txtID, "");
                errorName.SetError(txtName, "");
                errorGioitinh.SetError(rbFemale, "");
                errorBirthday.SetError(dtBirthday, "");
                errorPhone.SetError(txtPhone, "");
                errorEmail.SetError(txtEmail, "");
                txtID.Text = dataGV.CurrentRow.Cells[0].Value.ToString();
                txtID.Enabled = false;
                txtName.Text = dataGV.CurrentRow.Cells[1].Value.ToString();
                if (dataGV.CurrentRow.Cells[2].Value.ToString().Trim()=="Nam")
                    rbMale.Checked = true;
                else
                    rbFemale.Checked = true;
                dtBirthday.Value =DateTime.Parse(dataGV.CurrentRow.Cells[3].Value.ToString());
                txtPhone.Text = dataGV.CurrentRow.Cells[4].Value.ToString();
                txtEmail.Text = dataGV.CurrentRow.Cells[5].Value.ToString();
                GIAOVIEN gv = GVController.getGV(txtID.Text);
                if (gv == null)
                    return;
                if (gv.Picture == null)
                {
                    pictureBoxAvt.Image = null;
                    return;
                }
                   
                MemoryStream memory = new MemoryStream(gv.Picture.ToArray());
                Image img = Image.FromStream(memory);
                if (img == null)
                    return;
                pictureBoxAvt.Image = img;

            }
            catch
            {
                return;
            }
            
            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtID.Enabled = true;
            txtID.Clear();
            txtName.Clear();
            if (rbMale.Checked == true)
            {
                rbMale.Checked = false;
            }
            if (rbFemale.Checked == true)
            {
                rbFemale.Checked = false;
            }
            dtBirthday.ResetText();
            txtPhone.Clear();
            txtEmail.Clear();
            errorID.SetError(txtID, "");
            errorName.SetError(txtName, "");
            errorGioitinh.SetError(rbFemale, "");
            errorBirthday.SetError(dtBirthday, "");
            errorPhone.SetError(txtPhone, "");
            errorEmail.SetError(txtEmail, "");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGV.SelectedRows.Count <= 0)
                return;
            GIAOVIEN gv = GVController.getGV(dataGV.CurrentRow.Cells[0].Value.ToString());
            GVController.DeleteGV(gv);

            int rowIndex = dataGV.CurrentCell.RowIndex;
            dataGV.Rows.RemoveAt(rowIndex);

            txtID.Enabled = true;
            txtID.Clear();
            txtName.Clear();
            if (rbMale.Checked == true)
            {
                rbMale.Checked = false;
            }
            if (rbFemale.Checked == true)
            {
                rbFemale.Checked = false;
            }
            dtBirthday.ResetText();
            txtPhone.Clear();
            txtEmail.Clear();
            pictureBoxAvt.Image = null;
            MessageBox.Show("Đã xóa", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAvt_Click(object sender, EventArgs e)
        {
            string imgLoc = "";
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg";
            if (dlg.ShowDialog()==DialogResult.OK)
            {
                imgLoc = dlg.FileName.ToString();
                pictureBoxAvt.ImageLocation = imgLoc;
            }
        }
    }
}
