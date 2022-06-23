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
        bool add = true;
        HocPhan_SV temp;
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
                cbbHocPhan.Items.Add(item.TenHocPhan);
            }
            if (!add)
            {
                txtMSSV.Enabled = false;
                txtHoTen.Enabled = false;
                txtDiemCK.Text = temp.DiemCK.ToString(); 
                txtDiemGK.Text= temp.DiemGK.ToString();
                txtDiemBT.Text=temp.DiemBT.ToString();
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

        }
    }
}
