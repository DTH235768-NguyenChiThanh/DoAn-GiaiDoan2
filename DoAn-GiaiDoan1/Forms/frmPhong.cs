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
    public partial class frmPhong : Form
    {
        public frmPhong()
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
            txtTenPhong.Enabled = giaTri;
            rdbTrong.Enabled = giaTri;
            txtGiaGio.Enabled = giaTri;
            rdbĐangDung.Enabled = giaTri;
            rdbBaoTri.Enabled = giaTri;
            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        /* private void frmPhong_Load(object sender, EventArgs e)
         {
             BatTatChucNang(false);
             List<Phong> p = new List<Phong>();
             p = context.Phong.ToList();

             BindingSource bindingSource = new BindingSource();
             bindingSource.DataSource = p;

             txtTenPhong.DataBindings.Clear();
             txtTenPhong.DataBindings.Add("Text", bindingSource, "TenPhong", false, DataSourceUpdateMode.Never);
             txtGiaGio.DataBindings.Clear();
             txtGiaGio.DataBindings.Add("Text", bindingSource, "GiaGio", false, DataSourceUpdateMode.Never);
             cbLoaiPhong.DataSource = context.LoaiPhong.ToList();
             cbLoaiPhong.DisplayMember = "TenLoaiPhong";
             cbLoaiPhong.ValueMember = "ID";
             cbLoaiPhong.SelectedIndex = -1;


             dataGridView1.DataSource = bindingSource;
         }*/

        private void btnThem_Click(object sender, EventArgs e)
        {
            xulyThem = true;
            BatTatChucNang(true);
            txtTenPhong.Clear();
            txtGiaGio.Clear();
            cbLoaiPhong.SelectedIndex = -1;
            rdbTrong.Checked = false;
            rdbĐangDung.Checked = false;
            rdbBaoTri.Checked = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xulyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtTenPhong.Text) || string.IsNullOrWhiteSpace(txtGiaGio.Text) ||
                cbLoaiPhong.SelectedIndex == -1 ||
                !(rdbTrong.Checked || rdbĐangDung.Checked || rdbBaoTri.Checked))

                MessageBox.Show("Vui lòng nhập đầy đủ thông tin phòng ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string trangThai =
                    rdbTrong.Checked ? "Trống" :
                    rdbĐangDung.Checked ? "Đang dùng" : "Bảo trì";
                if (!decimal.TryParse(txtGiaGio.Text, out decimal giaGio))
                {
                    MessageBox.Show("Vui lòng nhập giá giờ hợp lệ", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (xulyThem)
                {
                    Phong p = new Phong();
                    p.TenPhong = txtTenPhong.Text;
                    p.GiaGio = giaGio;
                    p.TrangThai = trangThai;
                    p.LoaiPhongID = (int)cbLoaiPhong.SelectedValue;

                    context.Phong.Add(p);
                    context.SaveChanges();
                }
                else
                {
                    Phong p = context.Phong.Find(id);
                    if (p != null)
                    {
                        p.TenPhong = txtTenPhong.Text;
                        p.GiaGio = giaGio;
                        p.TrangThai = trangThai;
                        p.LoaiPhongID = (int)cbLoaiPhong.SelectedValue;
                        context.Phong.Update(p);
                        context.SaveChanges();
                    }
                }
                frmPhong_Load_1(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa phòng?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IDPhong"].Value.ToString());
                Phong p = context.Phong.Find(id);
                if (p != null)
                {
                    context.Phong.Remove(p);
                }
                context.SaveChanges();
                frmPhong_Load_1(sender, e);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmPhong_Load_1(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPhong_Load_1(object sender, EventArgs e)
        {
            BatTatChucNang(false);



            List<Phong> p = new List<Phong>();
            p = context.Phong.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = p;
            var dsPhong = from ph in context.Phong
                          join lp in context.LoaiPhong
                          on ph.LoaiPhongID equals lp.ID
                          select new
                          {
                              ph.ID,
                              ph.TenPhong,
                              ph.GiaGio,
                              LoaiPhong = lp.TenLoaiPhong, 
                              ph.LoaiPhongID,
                              TrangThai = ph.TrangThai
                          };

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dsPhong.ToList();


            txtTenPhong.DataBindings.Clear();
            txtTenPhong.DataBindings.Add("Text", bindingSource, "TenPhong", false, DataSourceUpdateMode.Never);
            txtGiaGio.DataBindings.Clear();
            txtGiaGio.DataBindings.Add("Text", bindingSource, "GiaGio", false, DataSourceUpdateMode.Never);
            cbLoaiPhong.DataSource = context.LoaiPhong.ToList();
            cbLoaiPhong.DisplayMember = "TenLoaiPhong";
            cbLoaiPhong.ValueMember = "ID";
            cbLoaiPhong.SelectedIndex = -1;
            

            dataGridView1.AutoGenerateColumns = false;
          

           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtTenPhong.Text =
                    dataGridView1.CurrentRow.Cells["TenPhong"].Value.ToString();

                txtGiaGio.Text =
                    dataGridView1.CurrentRow.Cells["GiaGio"].Value.ToString();

                cbLoaiPhong.Text =
                    dataGridView1.CurrentRow.Cells["LoaiPhong"].Value.ToString();

                string trangThai =
                    dataGridView1.CurrentRow.Cells["TrangThai"].Value.ToString();

                rdbTrong.Checked = trangThai == "Trống";
                rdbĐangDung.Checked = trangThai == "Đang dùng";
                rdbBaoTri.Checked = trangThai == "Bảo trì";
            }
        }
    }
}
