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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            loadData();
        }
        public void loadData()
        {
            cbbHocPhan.Items.Add("all");
            foreach (HocPhan hocPhan in BLL_HocPhan.Instance.GetAll())
            {
                cbbHocPhan.Items.Add(hocPhan.TenHocPhan);
            }
            cbbHocPhan.SelectedIndex = 0;
            loadDGV();
        }
        public void loadDGV()
        {
            
            var query =BLL_HocPhanSV.Instance.GetInfoBySearchBox(txtSearch.Text,cbbHocPhan.SelectedItem.ToString());
            //dataGridView1.DataSource = query;
            var list = query.Select(p => new
            {
                p.ID,
                p.SV.Name,
                p.SV.LopSH,
                p.MaHocPhan,
                p.DiemBT,
                p.DiemGK,
                p.DiemCK,
                tongket = p.DiemBT * 0.2 + p.DiemGK * 0.2 + p.DiemCK * 0.2,
                p.NgayThi

            }) ;
            dataGridView1.DataSource = list.ToList();
            setNameDGV();
        }
        public void setNameDGV()
        {
            dataGridView1.Columns[0].HeaderText = "STT";
            dataGridView1.Columns[1].HeaderText = "Tên Sinh viên";
            dataGridView1.Columns[2].HeaderText = "lớp SH";
            dataGridView1.Columns[3].HeaderText = "lớp HP";
            dataGridView1.Columns[4].HeaderText = "Điểm BT";
            dataGridView1.Columns[5].HeaderText = "Điểm GK";
            dataGridView1.Columns[6].HeaderText = "Điểm CK";
            dataGridView1.Columns[7].HeaderText = "Tổng Kết";
            dataGridView1.Columns[8].HeaderText = "Ngày thi";
        }

        private void cbbHocPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDGV();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            loadDGV();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow i in dataGridView1.SelectedRows)
                {
                    BLL_HocPhanSV.Instance.del(i.Cells[0].Value.ToString());
                }
                loadDGV();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cbbHocPhan.SelectedIndex = 0;
            txtSearch.Clear();
            DetailForm frm = new DetailForm();
            frm.d = new DetailForm.Mydel(loadDGV);
            frm.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cbbHocPhan.SelectedIndex = 0;
            txtSearch.Clear();
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DetailForm detail = new DetailForm(Convert.ToInt16(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
                detail.d = new DetailForm.Mydel(loadDGV);
                detail.Show();
            }
        }
    }
}
