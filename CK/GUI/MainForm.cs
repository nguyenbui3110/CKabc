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

namespace CK.GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = BLL_HocPhanSV.Instance.GetInfoBySearchBox("V", "");
        }

        public void loadDGV()
        {
            double tongket;
            var query =BLL_HocPhanSV.Instance.GetInfoBySearchBox(txtSearch.Text,cbbHocPhan.SelectedItem.ToString());
            dataGridView1.DataSource = query.Select(p => new
            {
                p.ID,
                p.SV.Name,
                p.SV.LopSH,
                p.HocPhan.TenHocPhan,
                p.DiemBT,
                p.DiemGK,
                p.DiemCK,
                tongket =p.DiemBT*0.2+p.DiemGK*0.2+p.DiemCK*0.2,
                p.NgayThi

            });
        }
        public void setNameDGV()
        {

        }
    }
}
