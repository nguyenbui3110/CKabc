using CK.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CK.DTO;

namespace CK.GUI
{
    public partial class DetailForm : Form
    {
        public delegate void Mydel();
        public Mydel d { get; set; }
        public bool add = true;
        public HocPhan_SV temp;
        public DetailForm(int ID=0)
        {
            InitializeComponent();
            if (ID != 0)
            {
                add = false;
                temp= BLL_HocPhanSV.Instance.find(ID);
            }
            else
            {
                temp= new HocPhan_SV();
            }
            loadData();
        }
        public void loadData()
        {
            foreach (HocPhan item in BLL_HocPhan.Instance.GetAll())
            {
                if (!cbbHocPhan.Items.Contains(item.TenHocPhan))
                    cbbHocPhan.Items.Add(item.TenHocPhan);
            }
            foreach (SV item in BLL_SV.Instance.getAll())
            {
                if(!cbbLopSH.Items.Contains(item.LopSH))
                    cbbLopSH.Items.Add(item.LopSH);
            }
            if (!add)
            {
                txtMSSV.Enabled = false;
                txtHoTen.Enabled = false;
                rbNam.Enabled = false;
                rbNu.Enabled = false;
                txtDiemCK.Text = temp.DiemCK.ToString(); 
                txtDiemGK.Text= temp.DiemGK.ToString();
                txtDiemBT.Text=temp.DiemBT.ToString();
                cbbHocPhan.Text=temp.HocPhan.TenHocPhan.ToString();
                cbbLopSH.Text= temp.SV.LopSH.ToString();
                dateTimePicker1.Value = temp.NgayThi;
                txtHoTen.Text = temp.SV.Name;
                txtMSSV.Text = temp.MSSV;

                cbbLopSH.Text =temp.SV.LopSH.ToString();
                double tongket=Convert.ToDouble(txtDiemBT.Text)*0.2+ Convert.ToDouble(txtDiemGK.Text)*0.2+ Convert.ToDouble(txtDiemCK.Text)*0.3;
                txtTongKet.Text =tongket.ToString();


            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            d();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (add)
            {
                SV tempSV = new SV();
                tempSV.Name = txtHoTen.Text;
                tempSV.MSSV = txtMSSV.Text;
                tempSV.Gender = rbNam.Checked;
                BLL_SV.Instance.add(tempSV);
                temp.DiemBT = Convert.ToDouble(txtDiemBT.Text);
                temp.DiemGK = Convert.ToDouble(txtDiemGK.Text);
                temp.DiemCK = Convert.ToDouble(txtDiemCK.Text);
                temp.NgayThi = dateTimePicker1.Value;
                tempSV.LopSH = cbbLopSH.Text;
                temp.SV = tempSV;
                temp.HocPhan = BLL_HocPhan.Instance.FindWithName(cbbHocPhan.Text);
                BLL_HocPhanSV.Instance.add(temp);
            }
            else
            {
                temp.DiemBT = Convert.ToDouble(txtDiemBT.Text);
                temp.DiemGK = Convert.ToDouble(txtDiemGK.Text);
                temp.DiemCK = Convert.ToDouble(txtDiemCK.Text);
                temp.NgayThi = dateTimePicker1.Value;
                BLL_HocPhanSV.Instance.Update();
            }

            d();
            this.Close();
        }

        private void txtDiemBT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double tongket = Convert.ToDouble(txtDiemBT.Text) * 0.2 + Convert.ToDouble(txtDiemGK.Text) * 0.2 + Convert.ToDouble(txtDiemCK.Text) * 0.3;
                txtTongKet.Text = tongket.ToString();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
