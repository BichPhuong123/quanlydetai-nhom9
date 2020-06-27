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
    public partial class FormDeTai : Form
    {
        
        public FormDeTai()
        {
            InitializeComponent();
        }

        private void FormDeTai_Load(object sender, EventArgs e)
        {

            string displaySV;
            List<DETAI> lstDT = DetaiController.getListDT();

            for (int i = 0; i < lstDT.Count; i++)
            {
                
                dataDetai.Rows.Add(lstDT[i]);
                dataDetai.Rows[i].Cells[0].Value = lstDT[i].MaDeTai;
                dataDetai.Rows[i].Cells[1].Value = lstDT[i].TenDeTai;
                dataDetai.Rows[i].Cells[2].Value = lstDT[i].LoaiDeTai;
                dataDetai.Rows[i].Cells[3].Value = lstDT[i].TGBD;
                dataDetai.Rows[i].Cells[4].Value = lstDT[i].TGKT;
                dataDetai.Rows[i].Cells[5].Value = lstDT[i].Solan;

                dataDetai.Rows[i].Cells[6].Value = lstDT[i].MaGV;

                displaySV = "";
                foreach(SINHVIEN s in lstDT[i].SINHVIENs)
                {
                    displaySV = displaySV + s + "   " ;
                }
                dataDetai.Rows[i].Cells[7].Value = displaySV;
            }
            



        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Trim().Length <= 0 || txtName.Text.Trim().Length <= 0 || cbLoai.SelectedIndex<0 || dtFrom.Value <= DateTime.Now || dtTo.Value <= dtFrom.Value || numSolan.Value==0 || DetaiController.getDT(txtID.Text.Trim()) != null)
            {
                if (txtID.Text.Trim().Length <= 0)
                    errorID.SetError(txtID, "Phải nhập mã đề tài");
                else if (DetaiController.getDT(txtID.Text.Trim()) != null)
                {
                    errorID.SetError(txtID, "Mã đề tài đã tồn tại");

                }
                else
                    errorID.SetError(txtID, "");
                if (txtName.Text.Trim().Length <= 0)
                    errorName.SetError(txtName, "Phải nhập tên đề tài");
                else
                    errorName.SetError(txtName, "");
                if (dtFrom.Value <= DateTime.Now)
                    errorFrom.SetError(dtFrom, "Ngày bắt đầu không hợp lệ");
                else
                    errorFrom.SetError(dtFrom, "");
                if (dtTo.Value <= dtFrom.Value)
                    errorTo.SetError(dtTo, "Ngày kết thúc không hợp lệ");
                else
                    errorTo.SetError(dtTo, "");
                if (numSolan.Value == 0)
                    errorSolan.SetError(numSolan, "Số lần báo cáo không hợp lệ");
                else
                    errorSolan.SetError(numSolan, "");
                if (cbLoai.SelectedIndex < 0)
                    errorLoai.SetError(cbLoai, "Phải chọn loại đề tài");
                else
                    errorLoai.SetError(cbLoai, "");
                return;
            }
            errorID.SetError(txtID, "");
            errorName.SetError(txtName, "");
            errorTo.SetError(dtTo, "");
            errorFrom.SetError(dtFrom, "");
            errorSolan.SetError(numSolan, "");
            errorLoai.SetError(cbLoai, "");
            DETAI DT = new DETAI();
            DT.MaDeTai = txtID.Text.Trim();
            DT.TenDeTai = txtName.Text.Trim();
            DT.LoaiDeTai = cbLoai.SelectedItem.ToString();
            DT.TGBD= dtFrom.Value;
            DT.TGKT = dtTo.Value;
            DT.Solan =Convert.ToInt32(numSolan.Value);
            if (GVController.getGV(txtGV.Text.Trim()) != null)
                DT.MaGV = txtGV.Text.Trim() ;

            DT.SINHVIENs = new List<SINHVIEN>();
            string displaySV = "";
            for (int j = 0; j < lstSV.Items.Count; j++)
            {
                displaySV = displaySV + lstSV.Items[j] + " ";
                DT.SINHVIENs.Add(lstSV.Items[j] as SINHVIEN);
            }

            //them de tai vao DB
            DetaiController.AddDT(DT);
            int i = dataDetai.Rows.Count - 1;
            dataDetai.Rows.Add(DT);
            
            dataDetai.Rows[i].Cells[0].Value = DT.MaDeTai;
            dataDetai.Rows[i].Cells[1].Value = DT.TenDeTai;
            dataDetai.Rows[i].Cells[2].Value = DT.LoaiDeTai;
            dataDetai.Rows[i].Cells[3].Value = DT.TGBD;
            dataDetai.Rows[i].Cells[4].Value = DT.TGKT;
            dataDetai.Rows[i].Cells[5].Value = DT.Solan;
            dataDetai.Rows[i].Cells[6].Value = DT.MaGV;

            dataDetai.Rows[i].Cells[7].Value = displaySV;



            txtID.Clear();
            txtName.Clear();
            cbLoai.Text = "";
            dtFrom.ResetText();
            dtTo.ResetText();
            numSolan.Value = 0;
            txtGV.Clear();
            lstSearchGV.Visible = false;
            lstSV.Items.Clear();
            txtSearchSV.Clear();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtGV_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lstSearchGV_DoubleClick(object sender, EventArgs e)
        {
            if (lstSearchGV.SelectedIndex >= 0)
            {
                txtGV.Text = lstSearchGV.SelectedItem.ToString();
            }
            lstSearchGV.Visible = false;
        }

        private void lstSearchGV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSearchSV_TextChanged(object sender, EventArgs e)
        {
            lstSearchSV.Items.Clear();
            List<SINHVIEN> searchSV = SVController.getListSV(txtSearchSV.Text.Trim());
            if (searchSV.Count > 0)
            {
                lstSearchSV.Visible = true;
            }
            else
            {
                lstSearchSV.Visible = false;
            }
            for (int i = 0; i < searchSV.Count; i++)
            {
                lstSearchSV.Items.Add(searchSV[i]);
            }
        }

        private void lstSearchSV_DoubleClick(object sender, EventArgs e)
        {
            if (lstSearchSV.SelectedIndex >= 0)
            {
                
                if (!(lstSV.Items.Contains(lstSearchSV.SelectedItem)))
                    lstSV.Items.Add(lstSearchSV.SelectedItem);
            }
            lstSearchSV.Visible = false;
        }

        private void lstSV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstSV_DoubleClick(object sender, EventArgs e)
        {
            if (lstSV.SelectedIndex >= 0)
            {
                lstSV.Items.RemoveAt(lstSV.SelectedIndex);

            }
        }

        private void txtGV_TextChanged_1(object sender, EventArgs e)
        {
            lstSearchGV.Items.Clear();
            List<GIAOVIEN> searchGV = GVController.getListGV(txtGV.Text.Trim());
            if (searchGV.Count > 0)
            {
                lstSearchGV.Visible = true;
            }
            else
            {
                lstSearchGV.Visible = false;
            }
            for (int i = 0; i < searchGV.Count; i++)
            {
                lstSearchGV.Items.Add(searchGV[i]);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Trim().Length <= 0 || txtName.Text.Trim().Length <= 0 || cbLoai.SelectedIndex < 0 || dtFrom.Value <= DateTime.Now || dtTo.Value <= dtFrom.Value || numSolan.Value == 0 )
            {
                if (txtID.Text.Trim().Length <= 0)
                    errorID.SetError(txtID, "Phải nhập mã đề tài");
                else
                    errorID.SetError(txtID, "");
                if (txtName.Text.Trim().Length <= 0)
                    errorName.SetError(txtName, "Phải nhập tên đề tài");
                else
                    errorName.SetError(txtName, "");
                if (dtFrom.Value <= DateTime.Now)
                    errorFrom.SetError(dtFrom, "Ngày bắt đầu không hợp lệ");
                else
                    errorFrom.SetError(dtFrom, "");
                if (dtTo.Value <= dtFrom.Value)
                    errorTo.SetError(dtTo, "Ngày kết thúc không hợp lệ");
                else
                    errorTo.SetError(dtTo, "");
                if (numSolan.Value == 0)
                    errorSolan.SetError(numSolan, "Số lần báo cáo không hợp lệ");
                else
                    errorSolan.SetError(numSolan, "");
                if (cbLoai.SelectedIndex < 0)
                    errorLoai.SetError(cbLoai, "Phải chọn loại đề tài");
                else
                    errorLoai.SetError(cbLoai, "");
                return;
            }
            errorID.SetError(txtID, "");
            errorName.SetError(txtName, "");
            errorTo.SetError(dtTo, "");
            errorFrom.SetError(dtFrom, "");
            errorSolan.SetError(numSolan, "");
            errorLoai.SetError(cbLoai, "");
            string maDT = dataDetai.CurrentRow.Cells[0].Value.ToString();
            DETAI dt = DetaiController.getDT(maDT);
           
            dt.TenDeTai = txtName.Text.Trim();
            dt.LoaiDeTai = cbLoai.SelectedItem.ToString();
            dt.TGBD = dtFrom.Value;
            dt.TGKT = dtTo.Value;
            dt.Solan = Convert.ToInt32(numSolan.Value);

            if (GVController.getGV(txtGV.Text.Trim()) != null)
            {
                dt.MaGV = txtGV.Text.Trim();
                dt.GIAOVIEN = GVController.getGV(txtGV.Text.Trim());
            }
            else if (txtGV.Text.Trim() == "")
                dt.MaGV = null;
            else
                return;
            var listSV = new List<SINHVIEN>();
            string displaySV = "";
            for (int j = 0; j < lstSV.Items.Count; j++)
            {
                displaySV = displaySV + lstSV.Items[j] + " ";
                listSV.Add(lstSV.Items[j] as SINHVIEN);
            }
            DetaiController.UpdateGV(dt);
            DetaiController.UpdateDT( maDT,dt,listSV);
           

            dataDetai.CurrentRow.Cells[0].Value = dt.MaDeTai;
            dataDetai.CurrentRow.Cells[1].Value = dt.TenDeTai;
            dataDetai.CurrentRow.Cells[2].Value = dt.LoaiDeTai;
            dataDetai.CurrentRow.Cells[3].Value = dt.TGBD;
            dataDetai.CurrentRow.Cells[4].Value = dt.TGKT;
            dataDetai.CurrentRow.Cells[5].Value = dt.Solan;
            dataDetai.CurrentRow.Cells[6].Value = dt.MaGV;

            dataDetai.CurrentRow.Cells[7].Value = displaySV;



            txtID.Clear();
            txtName.Clear();
            cbLoai.Text = "";
            dtFrom.ResetText();
            dtTo.ResetText();
            numSolan.Value = 0;
            txtGV.Clear();
            lstSearchGV.Visible = false;
            lstSV.Items.Clear();
            txtSearchSV.Clear();
        }

        private void dataDetai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataDetai.SelectedRows.Count < 0)
                return;
            try
            {
                errorID.SetError(txtID, "");
                errorName.SetError(txtName, "");
                errorTo.SetError(dtTo, "");
                errorFrom.SetError(dtFrom, "");
                errorSolan.SetError(numSolan, "");
                errorLoai.SetError(cbLoai, "");
                txtID.Text = dataDetai.CurrentRow.Cells[0].Value.ToString();
                txtID.Enabled = false;
                txtName.Text = dataDetai.CurrentRow.Cells[1].Value.ToString();
                cbLoai.Text= dataDetai.CurrentRow.Cells[2].Value.ToString();
                dtFrom.Value = DateTime.Parse(dataDetai.CurrentRow.Cells[3].Value.ToString());
                dtTo.Value = DateTime.Parse(dataDetai.CurrentRow.Cells[4].Value.ToString());
                numSolan.Value =Convert.ToInt32(dataDetai.CurrentRow.Cells[5].Value.ToString());
                if(dataDetai.CurrentRow.Cells[6].Value !=null)
                    txtGV.Text = dataDetai.CurrentRow.Cells[6].Value.ToString();
                try
                {
                    lstSV.Items.Clear();
                    string s = dataDetai.CurrentRow.Cells[7].Value.ToString();
                    string[] sv = s.Split(' ');


                    for (int i = 0; i < sv.Length; i++)
                    {


                        if (sv[i] != "")
                        {
                            List<SINHVIEN> searchSV = SVController.getListSV(sv[i]);
                            for (int j = 0; j < searchSV.Count; j++)
                            {
                                if (searchSV[j].MaSV == sv[i])
                                {
                                    lstSV.Items.Add(searchSV[j]);

                                }
                            }

                        }

                    }


                }
                catch { }

            }
            catch
            {
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataDetai.SelectedRows.Count <= 0)
                return;
            string maDT = dataDetai.CurrentRow.Cells[0].Value.ToString();
            
            DetaiController.DeleteDT(maDT);
            int rowIndex = dataDetai.CurrentCell.RowIndex;
            dataDetai.Rows.RemoveAt(rowIndex);


            txtID.Enabled = true;
            txtID.Clear();
            txtName.Clear();
            cbLoai.Text = "";
            dtFrom.ResetText();
            dtTo.ResetText();
            numSolan.Value = 0;
            txtGV.Clear();
            lstSearchGV.Visible = false;
            lstSV.Items.Clear();
            txtSearchSV.Clear();
            MessageBox.Show("Đã xóa", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtID.Enabled = true;
            txtID.Clear();
            txtName.Clear();
            cbLoai.Text = "";
            dtFrom.ResetText();
            dtTo.ResetText();
            numSolan.Value = 0;
            txtGV.Clear();
            lstSearchGV.Visible = false;
            lstSV.Items.Clear();
            txtSearchSV.Clear();
            errorID.SetError(txtID, "");
            errorName.SetError(txtName, "");
            errorTo.SetError(dtTo, "");
            errorFrom.SetError(dtFrom, "");
            errorSolan.SetError(numSolan, "");
            errorLoai.SetError(cbLoai, "");
        }

        private void dataDetai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0&&e.RowIndex<dataDetai.Rows.Count-1)
            {
                FormBaoCao formbc = new FormBaoCao();
                string maDT = dataDetai.CurrentRow.Cells[0].Value.ToString();
                List<BAOCAO> listbc = BCController.getListBC(maDT);
                // Control[] ctrls = formbc.Controls.Find("labelDT", false);
                formbc.labelDT.Text = maDT;
                formbc.labelSolan.Text = dataDetai.CurrentRow.Cells[5].Value.ToString();
                for (int i = 0; i < listbc.Count; i++)
                {

                    formbc.dataBaocao.Rows.Add(listbc[i]);
                    formbc.dataBaocao.Rows[i].Cells[0].Value = listbc[i].STT;
                    formbc.dataBaocao.Rows[i].Cells[1].Value = listbc[i].NhanXet;
                    formbc.dataBaocao.Rows[i].Cells[2].Value = listbc[i].TaiLieu;
                }
                formbc.Show();
            }
        }
    }
}
