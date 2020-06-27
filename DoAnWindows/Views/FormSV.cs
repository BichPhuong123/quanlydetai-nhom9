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
    public partial class FormSV : Form
    {
        public FormSV()
        {
            InitializeComponent();
        }

        private void FormSV_Load(object sender, EventArgs e)
        {
            string displayDT;
            List<SINHVIEN> lstSV = SVController.getListSV();

            for (int i = 0; i < lstSV.Count; i++)
            {

                dataSV.Rows.Add(lstSV[i]);
                dataSV.Rows[i].Cells[0].Value = lstSV[i].MaSV;
                dataSV.Rows[i].Cells[1].Value = lstSV[i].HoTen;
                dataSV.Rows[i].Cells[2].Value = lstSV[i].Gioitinh;
                dataSV.Rows[i].Cells[3].Value = lstSV[i].Ngaysinh;
                dataSV.Rows[i].Cells[4].Value = lstSV[i].SDT;
                dataSV.Rows[i].Cells[5].Value = lstSV[i].Email;
                displayDT = "";
                foreach (DETAI dt in lstSV[i].DETAIs)
                {
                    displayDT = displayDT + dt + "   ";
                }
                dataSV.Rows[i].Cells[6].Value = displayDT;


            }
            

        }

       
       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Trim().Length <= 0 || txtName.Text.Trim().Length <= 0 || (rbMale.Checked == false && rbFemale.Checked == false) || dtBirthday.Value >= DateTime.Now || txtPhone.Text.Trim().Length <= 0 || txtEmail.Text.Trim().Length <= 0 || GVController.getGV(txtID.Text.Trim()) != null)
            {
                if (txtID.Text.Trim().Length <= 0)
                    errorID.SetError(txtID, "Phải nhập mã giáo viên");
                else if (SVController.getSV(txtID.Text.Trim()) != null)
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
            SINHVIEN SV = new SINHVIEN();
            SV.MaSV = txtID.Text.Trim();
            SV.HoTen = txtName.Text.Trim();
            if (rbMale.Checked == true)
            {
                SV.Gioitinh = rbMale.Text;
            }
            if (rbFemale.Checked == true)
            {
                SV.Gioitinh = rbFemale.Text;
            }

            SV.Ngaysinh = DateTime.Parse(dtBirthday.Value.ToString("MM/dd/yyyy"));
            SV.SDT = txtPhone.Text.Trim();
            SV.Email = txtEmail.Text.Trim();
            if (pictureBoxAvt.Image != null)
            {
                MemoryStream stream = new MemoryStream();
                pictureBoxAvt.Image.Save(stream, ImageFormat.Jpeg);
                SV.Picture = stream.ToArray();
            }


            //them user vao DB
            if (SVController.AddSV(SV) == false)
            {
                MessageBox.Show("Lỗi thêm giáo viên");
                return;
            }
            int i = dataSV.Rows.Count - 1;
            dataSV.Rows.Add(SV);
            dataSV.Rows[i].Cells[0].Value = SV.MaSV;
            dataSV.Rows[i].Cells[1].Value = SV.HoTen;
            dataSV.Rows[i].Cells[2].Value = SV.Gioitinh;
            dataSV.Rows[i].Cells[3].Value = SV.Ngaysinh;
            dataSV.Rows[i].Cells[4].Value = SV.SDT;
            dataSV.Rows[i].Cells[5].Value = SV.Email;
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

        private void dataSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                errorID.SetError(txtID, "");
                errorName.SetError(txtName, "");
                errorGioitinh.SetError(rbFemale, "");
                errorBirthday.SetError(dtBirthday, "");
                errorPhone.SetError(txtPhone, "");
                errorEmail.SetError(txtEmail, "");
                txtID.Text = dataSV.CurrentRow.Cells[0].Value.ToString();
                txtID.Enabled = false;
                txtName.Text = dataSV.CurrentRow.Cells[1].Value.ToString();
                if (dataSV.CurrentRow.Cells[2].Value.ToString().Trim() == "Nam")
                    rbMale.Checked = true;
                else
                    rbFemale.Checked = true;
                dtBirthday.Value = DateTime.Parse(dataSV.CurrentRow.Cells[3].Value.ToString());
                txtPhone.Text = dataSV.CurrentRow.Cells[4].Value.ToString();
                txtEmail.Text = dataSV.CurrentRow.Cells[5].Value.ToString();
                SINHVIEN sv = SVController.getSV(txtID.Text);
                if (sv == null)
                    return;
                if (sv.Picture == null)
                {
                    pictureBoxAvt.Image = null;
                    return;
                }

                MemoryStream memory = new MemoryStream(sv.Picture.ToArray());
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

        private void btnAvt_Click(object sender, EventArgs e)
        {
            string imgLoc = "";
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imgLoc = dlg.FileName.ToString();
                pictureBoxAvt.ImageLocation = imgLoc;
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
            if (dataSV.SelectedRows.Count <= 0)
                return;
            SINHVIEN sv = SVController.getSV(dataSV.CurrentRow.Cells[0].Value.ToString());
            SVController.DeleteSV(sv);

            int rowIndex = dataSV.CurrentCell.RowIndex;
            dataSV.Rows.RemoveAt(rowIndex);

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataSV.SelectedRows.Count < 0)
                return;
            txtID.Enabled = true;
            if (txtName.Text.Trim().Length <= 0 || (rbMale.Checked == false && rbFemale.Checked == false) || dtBirthday.Value >= DateTime.Now || txtPhone.Text.Trim().Length <= 0 || txtEmail.Text.Trim().Length <= 0)
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

            SINHVIEN sv = SVController.getSV(dataSV.CurrentRow.Cells[0].Value.ToString());
            sv.HoTen = txtName.Text.Trim();
            if (rbMale.Checked == true)
            {
                sv.Gioitinh = rbMale.Text;
            }
            if (rbFemale.Checked == true)
            {
                sv.Gioitinh = rbFemale.Text;
            }

            sv.Ngaysinh = DateTime.Parse(dtBirthday.Value.ToString("MM/dd/yyyy"));
            sv.SDT = txtPhone.Text.Trim();
            sv.Email = txtEmail.Text.Trim();
            if (pictureBoxAvt.Image != null)
            {
                MemoryStream stream = new MemoryStream();
                pictureBoxAvt.Image.Save(stream, ImageFormat.Jpeg);
                sv.Picture = stream.ToArray();
            }

            SVController.UpdateSV(sv);
            dataSV.CurrentRow.Cells[0].Value = sv.MaSV;
            dataSV.CurrentRow.Cells[1].Value = sv.HoTen;
            dataSV.CurrentRow.Cells[2].Value = sv.Gioitinh;
            dataSV.CurrentRow.Cells[3].Value = sv.Ngaysinh;
            dataSV.CurrentRow.Cells[4].Value = sv.SDT;
            dataSV.CurrentRow.Cells[5].Value = sv.Email;
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
    }
}        
   
