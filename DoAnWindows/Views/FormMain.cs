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
    public partial class FormMain : Form
    {
        FormGV formGV;
        FormSV formSV;
        FormDeTai formDetai;
        //FormBaoCao formBC;
        public FormMain()
        {
            InitializeComponent();
        }

        

        private void FormMain_Load(object sender, EventArgs e)
        {
            foreach(Control ctl in this.Controls)
            {
                try
                {
                   MdiClient ctlMDI = (MdiClient)ctl;
                    ctlMDI.BackColor = System.Drawing.Color.LightSkyBlue;
                    ctlMDI.BackgroundImageLayout = ImageLayout.Stretch;
                    ctlMDI.BackgroundImage = Properties.Resources.kisspng_foam_download_button_pretty_bubbles_5a993e045f8f29_6164396715199923243914;


                }
                catch(InvalidCastException ex)
                {

                }
            }
        }

        private void mGV_Click(object sender, EventArgs e)
        {

            if (formGV is null || formGV.IsDisposed)
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                listSearch.Visible = false;
                formGV = new FormGV();
                formGV.MdiParent = this;
                formGV.Show();
                if (GVController.getGV(btnSignIn.Text) == null)
                {



                    formGV.btnAdd.Enabled = false;
                    formGV.btnAvt.Enabled = false;
                    formGV.btnDelete.Enabled = false;
                    formGV.btnUpdate.Enabled = false;
                    formGV.btnNew.Enabled = false;

                    //formBC.btnAdd.Enabled = false;
                    //formBC.btnUpdate.Enabled = false;
                }
                else
                {



                    formGV.btnAdd.Enabled = true;
                    formGV.btnAvt.Enabled = true;
                    formGV.btnDelete.Enabled = true;
                    formGV.btnUpdate.Enabled = true;
                    formGV.btnNew.Enabled = true;

                    //formBC.btnAdd.Enabled = true;
                    //formBC.btnUpdate.Enabled = true;
                }
            }
            else
            {
                formGV.Select();
            }
        }

        private void FormMain_MdiChildActivate(object sender, EventArgs e)
        {
            if (ActiveMdiChild == null)
            {
                return;
            }
            ActiveMdiChild.WindowState = FormWindowState.Maximized;
            if (ActiveMdiChild.Tag == null)
            {
                TabPage tp = new TabPage(ActiveMdiChild.Text);
                tp.Tag = ActiveMdiChild;
                tp.Parent = tabMain;
                tabMain.SelectedTab = tp;
                ActiveMdiChild.Tag = tp;
                ActiveMdiChild.FormClosed += ActiveMdiChild_FormClosed;
            }
        }

        private void ActiveMdiChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((sender as Form).Tag as TabPage).Dispose();
            if(tabMain.TabCount==0)
            {
                panel1.Visible = true;
                panel2.Visible = true;
                panel3.Visible = true;
                listSearch.Visible = false;
            }
                
        }

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabMain.SelectedTab != null && tabMain.SelectedTab.Tag != null)
            {
                (tabMain.SelectedTab.Tag as Form).Select();
            }
        }

        private void mSV_Click(object sender, EventArgs e)
        {
            if (formSV is null || formSV.IsDisposed)
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                listSearch.Visible = false;
                
                formSV = new FormSV();
                formSV.MdiParent = this;
                formSV.Show();
                if (GVController.getGV(btnSignIn.Text) == null)
                {
                   
                    
                  
                    formSV.btnAdd.Enabled = false;
                    formSV.btnAvt.Enabled = false;
                    formSV.btnDelete.Enabled = false;
                    formSV.btnUpdate.Enabled = false;
                    formSV.btnNew.Enabled = false;
                   
                    //formBC.btnAdd.Enabled = false;
                    //formBC.btnUpdate.Enabled = false;
                }
                else
                {
                    
                  
                   
                    formSV.btnAdd.Enabled = true;
                    formSV.btnAvt.Enabled = true;
                    formSV.btnDelete.Enabled = true;
                    formSV.btnUpdate.Enabled = true;
                    formSV.btnNew.Enabled = true;
                    
                    //formBC.btnAdd.Enabled = true;
                    //formBC.btnUpdate.Enabled = true;
                }
            }
            else
            {
                formSV.Select();
            }
        }

        private void btnGV_Click(object sender, EventArgs e)
        {
            if (formGV is null || formGV.IsDisposed)
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                listSearch.Visible = false;
                formGV = new FormGV();
                formGV.MdiParent = this;
                formGV.Show();
                if (GVController.getGV(btnSignIn.Text) == null)
                {
                    
                 
                    formGV.btnAdd.Enabled = false;
                    formGV.btnAvt.Enabled = false;
                    formGV.btnDelete.Enabled = false;
                    formGV.btnNew.Enabled = false;
                    formGV.btnUpdate.Enabled = false;
                   
                    //formBC.btnAdd.Enabled = false;
                    //formBC.btnUpdate.Enabled = false;
                }
                else
                {
                   
                    formGV.btnAdd.Enabled = true;
                    formGV.btnAvt.Enabled = true;
                    formGV.btnDelete.Enabled = true;
                    formGV.btnNew.Enabled = true;
                    formGV.btnUpdate.Enabled = true;
                  
                    //formBC.btnAdd.Enabled = true;
                    //formBC.btnUpdate.Enabled = true;
                }
            }
            else
            {
                formGV.Select();
            }
        }

        private void mDetai_Click(object sender, EventArgs e)
        {
            if (formDetai is null || formDetai.IsDisposed)
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                listSearch.Visible = false;
                formDetai = new FormDeTai();
                formDetai.MdiParent = this;
                formDetai.Show();
                if (GVController.getGV(btnSignIn.Text) == null)
                {
                 
                    
                    formDetai.btnAdd.Enabled = false;
                    formDetai.btnDelete.Enabled = false;
                    formDetai.btnNew.Enabled = false;
                    formDetai.btnUpdate.Enabled = false;
                    //formBC.btnAdd.Enabled = false;
                    //formBC.btnUpdate.Enabled = false;
                }
                else
                {
                    
                    formDetai.btnAdd.Enabled = true;
                    formDetai.btnDelete.Enabled = true;
                    formDetai.btnNew.Enabled = true;
                    formDetai.btnUpdate.Enabled = true;
                    //formBC.btnAdd.Enabled = true;
                    //formBC.btnUpdate.Enabled = true;
                }
            }
            else
            {
                formDetai.Select();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            lstSearchDT.Items.Clear();
            List<GIAOVIEN> searchGV = GVController.getListGV(txtSearch.Text.Trim());
            List<SINHVIEN> searchSV = SVController.getListSV(txtSearch.Text.Trim());
            List<DETAI> searchDT = DetaiController.getListDT(txtSearch.Text.Trim());
            if (searchGV.Count > 0)
            {
                lstSearchDT.Visible = true;
                for (int i = 0; i < searchGV.Count; i++)
                {
                    lstSearchDT.Items.Add(searchGV[i]);
                }
               
            }
            else if(searchSV.Count > 0)
            {
                lstSearchDT.Visible = true;
                for (int i = 0; i < searchSV.Count; i++)
                {
                    lstSearchDT.Items.Add(searchSV[i]);
                }
               
            }
            else if(searchDT.Count > 0)
            {
                lstSearchDT.Visible = true;
                for (int i = 0; i < searchDT.Count; i++)
                {
                    lstSearchDT.Items.Add(searchDT[i]);
                }
                
            }
            else
            {
                lstSearchDT.Visible = true;
                lstSearchDT.Items.Add("Không tìm thấy kết quả phù hợp");
                
            }
            
        }

        private void lstSearchDT_DoubleClick(object sender, EventArgs e)
        {
            if (lstSearchDT.SelectedIndex >= 0)
            {
                txtSearch.Text = lstSearchDT.SelectedItem.ToString();
            }
            lstSearchDT.Visible = false;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            lstSearchDT.Visible = false;
            listSearch.Items.Clear();
            GIAOVIEN gv = GVController.getgv(txtSearch.Text.Trim());
            SINHVIEN sv = SVController.getsv(txtSearch.Text.Trim());
            DETAI dt = DetaiController.getdt(txtSearch.Text.Trim());
            
            
            if (gv!=null)
            {
                listSearch.Visible = true;
                GIAOVIEN GV = new GIAOVIEN();
                GV.MaGV = gv.MaGV;
                //gv.DETAIs = new List<DETAI>();
                
                foreach (DETAI DT in gv.DETAIs)
                {

                    int solan = Convert.ToInt32(DetaiController.getdt(DT.MaDeTai).Solan);
                    float n = float.Parse(BCController.getIDfromDB(DT.MaDeTai).ToString());
                    float m = float.Parse(solan.ToString());
                    float percents = (n / m) * 100;
                    int percent = Convert.ToInt32(percents);
                    string tt = String.Format("{0} %", percent);
                    string displaySV = "";
                    foreach (SINHVIEN s in DT.SINHVIENs)
                    {
                        displaySV = displaySV + s.MaSV + " ";
                    }
                    ListViewItem eVent = new ListViewItem();
                    eVent.Text = DT.MaDeTai;                 
                    eVent.SubItems.Add(new ListViewItem.ListViewSubItem(eVent, GV.MaGV));                    
                    eVent.SubItems.Add(new ListViewItem.ListViewSubItem(eVent, displaySV.Trim()));
                    eVent.SubItems.Add(new ListViewItem.ListViewSubItem(eVent,tt));
                    this.listSearch.Items.Add(eVent);
                }

                return;
            }
            if (sv != null)
            {
                listSearch.Visible = true;
                SINHVIEN SV = new SINHVIEN();
                SV.MaSV = sv.MaSV;
                string displayDT = "";
                string displayGV = "";
                foreach (DETAI DT in sv.DETAIs)
                {
                    int solan = Convert.ToInt32(DetaiController.getdt(DT.MaDeTai).Solan);
                    float n = float.Parse(BCController.getIDfromDB(DT.MaDeTai).ToString());
                    float m = float.Parse(solan.ToString());
                    float percents = (n / m) * 100;
                    int percent = Convert.ToInt32(percents);
                    string tt = String.Format("{0} %", percent);
                    displayGV = DT.MaGV;
                    displayDT = DT.MaDeTai;
                    ListViewItem eVent = new ListViewItem();
                    eVent.Text = displayDT;
                    eVent.SubItems.Add(new ListViewItem.ListViewSubItem(eVent, displayGV));
                    eVent.SubItems.Add(new ListViewItem.ListViewSubItem(eVent, SV.MaSV));
                    eVent.SubItems.Add(new ListViewItem.ListViewSubItem(eVent, tt));
                    this.listSearch.Items.Add(eVent);
                }

                return;
            }
            if (dt != null)
            {
                listSearch.Visible = true;
                DETAI DT = new DETAI();
                DT.MaDeTai = dt.MaDeTai;
                DT.MaGV = dt.MaGV;
                int solan = Convert.ToInt32(DetaiController.getdt(DT.MaDeTai).Solan);
                float n = float.Parse(BCController.getIDfromDB(DT.MaDeTai).ToString());
                float m = float.Parse(solan.ToString());
                float percents = (n / m) * 100;
                int percent = Convert.ToInt32(percents);
                string tt = String.Format("{0} %", percent);
                string displaySV = "";
                foreach (SINHVIEN s in dt.SINHVIENs)
                {
                        displaySV = displaySV + s.MaSV + " ";

                    
                }
                ListViewItem eVent = new ListViewItem();
                eVent.Text = DT.MaDeTai;
                eVent.SubItems.Add(new ListViewItem.ListViewSubItem(eVent, DT.MaGV));
                eVent.SubItems.Add(new ListViewItem.ListViewSubItem(eVent, displaySV.Trim()));
                eVent.SubItems.Add(new ListViewItem.ListViewSubItem(eVent, tt));
                this.listSearch.Items.Add(eVent);
                return;
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            
            if (login.ShowDialog() == DialogResult.OK)
            {
                if(UserController.getuser(login.txtID.Text.Trim(),login.txtPassword.Text.Trim()) != null)
                {
                    if (login.radioBtnStudent.Checked == true)
                    {
                        if (SVController.getSV(login.txtID.Text.Trim()) != null)
                        {
                            this.btnSignIn.Text = login.txtID.Text.Trim();
                            this.fileToolStripMenuItem.Enabled = true;
                            this.btnGV.Enabled = true;
                            this.btnSV.Enabled = true;
                            this.btnDetai.Enabled = true;
                        }
                       
                    }
                    if (login.radioBtnTeacher.Checked == true)
                    {
                        if (GVController.getGV(login.txtID.Text.Trim()) != null)
                        {
                            this.btnSignIn.Text = login.txtID.Text.Trim();
                            this.fileToolStripMenuItem.Enabled = true;
                            this.btnGV.Enabled = true;
                            this.btnSV.Enabled = true;
                            this.btnDetai.Enabled = true;
                        }
                        
                    }
                    
                }
               
                
            }
            

        }

        private void mHome_Click(object sender, EventArgs e)
        {
            if(formDetai!=null)
            {
                formDetai.Close();
            }
            if (formGV != null)
            {
                formGV.Close();
            }
            if (formSV != null)
            {
                formSV.Close();
            }   
            
        }

        private void btnSV_Click(object sender, EventArgs e)
        {
            if (formSV is null || formSV.IsDisposed)
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                listSearch.Visible = false;
                formSV = new FormSV();
                formSV.MdiParent = this;
                formSV.Show();
                if (GVController.getGV(btnSignIn.Text) == null)
                {



                    formSV.btnAdd.Enabled = false;
                    formSV.btnAvt.Enabled = false;
                    formSV.btnDelete.Enabled = false;
                    formSV.btnUpdate.Enabled = false;
                    formSV.btnNew.Enabled = false;

                    //formBC.btnAdd.Enabled = false;
                    //formBC.btnUpdate.Enabled = false;
                }
                else
                {



                    formSV.btnAdd.Enabled = true;
                    formSV.btnAvt.Enabled = true;
                    formSV.btnDelete.Enabled = true;
                    formSV.btnUpdate.Enabled = true;
                    formSV.btnNew.Enabled = true;

                    //formBC.btnAdd.Enabled = true;
                    //formBC.btnUpdate.Enabled = true;
                }
            }
            else
            {
                formSV.Select();
            }
        }

        private void btnDetai_Click(object sender, EventArgs e)
        {
            if (formDetai is null || formDetai.IsDisposed)
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                listSearch.Visible = false;
                formDetai = new FormDeTai();
                formDetai.MdiParent = this;
                formDetai.Show();
                if (GVController.getGV(btnSignIn.Text) == null)
                {


                    formDetai.btnAdd.Enabled = false;
                    formDetai.btnDelete.Enabled = false;
                    formDetai.btnNew.Enabled = false;
                    formDetai.btnUpdate.Enabled = false;
                    //formBC.btnAdd.Enabled = false;
                    //formBC.btnUpdate.Enabled = false;
                }
                else
                {

                    formDetai.btnAdd.Enabled = true;
                    formDetai.btnDelete.Enabled = true;
                    formDetai.btnNew.Enabled = true;
                    formDetai.btnUpdate.Enabled = true;
                    //formBC.btnAdd.Enabled = true;
                    //formBC.btnUpdate.Enabled = true;
                }
            }
            else
            {
                formDetai.Select();
            }
        }
    }
}
