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
    public partial class FormBaoCao : Form
    {
       
        public FormBaoCao()
        {
            InitializeComponent();
            timer1.Enabled = true;
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtLan.Text.Trim().Length <= 0 || txtLink.Text.Trim().Length <= 0 || rtxtNhanxet.Text.Trim().Length <= 0|| BCController.getBC(Convert.ToInt32(txtLan.Text.Trim()), labelDT.Text) != null|| Convert.ToInt32(txtLan.Text.Trim())> Convert.ToInt32(labelSolan.Text)|| Convert.ToInt32(txtLan.Text.Trim())!=BCController.getIDfromDB(labelDT.Text)+1)
            {
                if (txtLan.Text.Trim().Length <= 0)
                    errorLan.SetError(txtLan, "Phải nhập lần báo cáo");
                else if (BCController.getBC(Convert.ToInt32(txtLan.Text.Trim()),labelDT.Text) != null)
                {
                    errorLan.SetError(txtLan, "Lần báo cáo đã tồn tại");

                }
                else if(Convert.ToInt32(txtLan.Text.Trim()) > Convert.ToInt32(labelSolan.Text))
                {
                    errorLan.SetError(txtLan, "Lần báo cáo đã vượt quá số lần báo cáo");
                }
                else if(Convert.ToInt32(txtLan.Text.Trim()) != BCController.getIDfromDB(labelDT.Text) + 1)
                {
                    errorLan.SetError(txtLan, "Lần báo cáo không hợp lệ");
                }
                else
                    errorLan.SetError(txtLan, "");
                if (txtLink.Text.Trim().Length <= 0)
                    errorTailieu.SetError(txtLink, "Phải nhập link tài liệu");
                else
                    errorTailieu.SetError(txtLink, "");
                if (rtxtNhanxet.Text.Trim().Length <= 0)
                    errorNhanxet.SetError(rtxtNhanxet, "Phải nhập nhận xét");
                else
                    errorNhanxet.SetError(rtxtNhanxet, "");              
                return;
            }
            errorLan.SetError(txtLan, "");
            errorTailieu.SetError(txtLink, "");
            errorNhanxet.SetError(rtxtNhanxet, "");
            BAOCAO BC = new BAOCAO();
            BC.STT = Convert.ToInt32(txtLan.Text.Trim());
            BC.NhanXet = rtxtNhanxet.Text.Trim();
            BC.TaiLieu = txtLink.Text.Trim();
            BC.MaDeTai = labelDT.Text;
            BCController.AddBC(BC);
            int i = dataBaocao.Rows.Count - 1;
            dataBaocao.Rows.Add(BC);

            dataBaocao.Rows[i].Cells[0].Value = BC.STT;
            dataBaocao.Rows[i].Cells[1].Value = BC.NhanXet;
            dataBaocao.Rows[i].Cells[2].Value = BC.TaiLieu;
            txtLan.Clear();
            txtLink.Clear();
            rtxtNhanxet.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                int n = BCController.getIDfromDB(labelDT.Text);
                float percent = (float)(((double)(n) / (double)(Convert.ToInt32(labelSolan.Text)))) * 100;

                if (progressHT.Value >= percent)
                    return;
                else
                {
                    progressHT.Increment(1);
                    labelPercents.Text = String.Format("{0} %", progressHT.Value);
                }
            }
            catch { } 
           
        }

        private void dataBaocao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataBaocao.SelectedRows.Count < 0)
                return;
            try
            {
                txtLan.Text = dataBaocao.CurrentRow.Cells[0].Value.ToString();
                txtLan.Enabled = false;
                rtxtNhanxet.Text = dataBaocao.CurrentRow.Cells[1].Value.ToString();
                txtLink.Text = dataBaocao.CurrentRow.Cells[2].Value.ToString();

                errorLan.SetError(txtLan, "");
                errorTailieu.SetError(txtLink, "");
                errorNhanxet.SetError(rtxtNhanxet, "");
            }
            catch
            {
                return;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if ( txtLink.Text.Trim().Length <= 0 || rtxtNhanxet.Text.Trim().Length <= 0 )
            {
                
                if (txtLink.Text.Trim().Length <= 0)
                    errorTailieu.SetError(txtLink, "Phải nhập link tài liệu");
                else
                    errorTailieu.SetError(txtLink, "");
                if (rtxtNhanxet.Text.Trim().Length <= 0)
                    errorNhanxet.SetError(rtxtNhanxet, "Phải nhập nhận xét");
                else
                    errorNhanxet.SetError(rtxtNhanxet, "");
                return;
            }
            
            errorTailieu.SetError(txtLink, "");
            errorNhanxet.SetError(rtxtNhanxet, "");
            string maDT = labelDT.Text;
            BAOCAO bc = BCController.getBC(Convert.ToInt32(txtLan.Text.Trim()),maDT);

            bc.NhanXet = rtxtNhanxet.Text.Trim();
            bc.TaiLieu = txtLink.Text.Trim();
            
            BCController.UpdateBC(maDT, Convert.ToInt32(txtLan.Text.Trim()), bc);


            dataBaocao.CurrentRow.Cells[0].Value = bc.STT;
            dataBaocao.CurrentRow.Cells[1].Value = bc.NhanXet;
            dataBaocao.CurrentRow.Cells[2].Value = bc.TaiLieu;
            
            txtLan.Enabled = true;
            txtLan.Clear();
            txtLink.Clear();
            rtxtNhanxet.Text = "";
        }
    }
}
