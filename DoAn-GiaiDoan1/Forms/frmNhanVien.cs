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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
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
            txtTenNV.Enabled = giaTri;
            txtChucVu.Enabled = giaTri;
            txtSDT.Enabled = giaTri;
            rdbNam.Enabled = giaTri;
            rdbNu.Enabled = giaTri;
            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);

            List<NhanVien> nv = new List<NhanVien>();
            nv = context.NhanVien.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = nv;

            txtTenNV.DataBindings.Clear();
            txtTenNV.DataBindings.Add("Text", bindingSource, "TenNV", false, DataSourceUpdateMode.Never);

            txtChucVu.DataBindings.Clear();
            txtChucVu.DataBindings.Add("Text", bindingSource, "ChucVu", false, DataSourceUpdateMode.Never);

            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", bindingSource, "SDT", false, DataSourceUpdateMode.Never);


            dataGridView1.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xulyThem = true;
            BatTatChucNang(true);
            txtTenNV.Clear();
            txtChucVu.Clear();
            txtSDT.Clear();
            rdbNu.Checked = false;
            rdbNam.Checked = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xulyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtTenNV.Text) ||
                string.IsNullOrWhiteSpace(txtChucVu.Text) ||
                string.IsNullOrWhiteSpace(txtSDT.Text) ||
                !(rdbNam.Checked || rdbNu.Checked))
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string gioiTinh = rdbNam.Checked ? "Nam" : "Nữ";
                if (xulyThem)
                {
                    NhanVien nv = new NhanVien();
                    nv.TenNV = txtTenNV.Text;
                    nv.ChucVu = txtChucVu.Text;
                    nv.SDT = txtSDT.Text;
                    nv.GioiTinh = gioiTinh;
                    context.NhanVien.Add(nv);
                    context.SaveChanges();
                }
                else
                {
                    NhanVien nv = context.NhanVien.Find(id);
                    if (nv != null)
                    {
                        nv.TenNV = txtTenNV.Text;
                        nv.ChucVu = txtChucVu.Text;
                        nv.SDT = txtSDT.Text;
                        nv.GioiTinh = gioiTinh;
                        context.NhanVien.Update(nv);
                        context.SaveChanges();
                    }
                }
                frmNhanVien_Load(sender, e);

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa nhân viên?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
                NhanVien nv = context.NhanVien.Find(id);
                if (nv != null)
                {
                    context.NhanVien.Remove(nv);
                }
                context.SaveChanges();
                frmNhanVien_Load(sender, e);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmNhanVien_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
