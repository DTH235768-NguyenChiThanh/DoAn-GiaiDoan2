using DoAn_GiaiDoan1.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_GiaiDoan1.Forms
{
    public partial class frmLoaiPhong : Form
    {
        public frmLoaiPhong()
        {
            InitializeComponent();
        }
        QLQKOKDbContext context = new QLQKOKDbContext();
        bool xulyThem = false;
        int id;
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuy.Enabled = giaTri;
            txtTenLoaiPhong.Enabled = giaTri;
            txtDonGiaGio.Enabled = giaTri;
            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }
       /* private void frmLoaiPhong_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            List<LoaiPhong> lp = new List<LoaiPhong>();
            lp = context.LoaiPhong.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = lp;

            txtTenLoaiPhong.DataBindings.Clear();
            txtTenLoaiPhong.DataBindings.Add("Text", bindingSource, "TenLoaiPhong", false, DataSourceUpdateMode.Never);
            txtDonGiaGio.DataBindings.Clear();
            txtDonGiaGio.DataBindings.Add("Text", bindingSource, "DonGiaGio", false, DataSourceUpdateMode.Never);
            dataGridView1.DataSource = bindingSource;
        }*/

        private void btnThem_Click(object sender, EventArgs e)
        {
            xulyThem = true;
            BatTatChucNang(true);
            txtTenLoaiPhong.Clear();
            txtDonGiaGio.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xulyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenLoaiPhong.Text) || string.IsNullOrWhiteSpace(txtDonGiaGio.Text))
                MessageBox.Show("Vui lòng nhập tên loại phòng và đơn giá giờ ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (!decimal.TryParse(txtDonGiaGio.Text, out decimal donGiaGio))
                {
                    MessageBox.Show("Vui lòng nhập đơn giá giờ hợp lệ", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (xulyThem)
                {
                    LoaiPhong lp = new LoaiPhong();
                    lp.TenLoaiPhong = txtTenLoaiPhong.Text;
                    lp.DonGiaGio = donGiaGio;
                    context.LoaiPhong.Add(lp);
                    context.SaveChanges();
                }
                else
                {
                    LoaiPhong lp = context.LoaiPhong.Find(id);
                    if (lp != null)
                    {
                        lp.TenLoaiPhong = txtTenLoaiPhong.Text;
                        lp.DonGiaGio = donGiaGio;
                        context.LoaiPhong.Update(lp);
                        context.SaveChanges();
                    }
                }
                frmLoaiPhong_Load_1(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa loại phòng?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
                LoaiPhong lp = context.LoaiPhong.Find(id);
                if (lp != null)
                {
                    context.LoaiPhong.Remove(lp);
                }
                context.SaveChanges();
                frmLoaiPhong_Load_1(sender, e);
            }
        }


        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmLoaiPhong_Load_1(sender, e);
        }

        private void frmLoaiPhong_Load_1(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            List<LoaiPhong> lp = new List<LoaiPhong>();
            lp = context.LoaiPhong.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = lp;

            txtTenLoaiPhong.DataBindings.Clear();
            txtTenLoaiPhong.DataBindings.Add("Text", bindingSource, "TenLoaiPhong", false, DataSourceUpdateMode.Never);
            txtDonGiaGio.DataBindings.Clear();
            txtDonGiaGio.DataBindings.Add("Text", bindingSource, "DonGiaGio", false, DataSourceUpdateMode.Never);
            dataGridView1.DataSource = bindingSource;
        }
    }
}
