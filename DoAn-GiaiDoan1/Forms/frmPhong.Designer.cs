namespace DoAn_GiaiDoan1.Forms
{
    partial class frmPhong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            txtGiaGio = new TextBox();
            label2 = new Label();
            btnSua = new Button();
            btnHuy = new Button();
            btnThoat = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            txtTenPhong = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            rdbBaoTri = new RadioButton();
            rdbĐangDung = new RadioButton();
            rdbTrong = new RadioButton();
            cbLoaiPhong = new ComboBox();
            btnThem = new Button();
            IDPhong = new DataGridViewTextBoxColumn();
            TenPhong = new DataGridViewTextBoxColumn();
            GiaGio = new DataGridViewTextBoxColumn();
            LoaiPhong = new DataGridViewTextBoxColumn();
            TrangThai = new DataGridViewTextBoxColumn();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(18, 260);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(967, 294);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách phòng";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IDPhong, TenPhong, GiaGio, LoaiPhong, TrangThai });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 22);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(961, 269);
            dataGridView1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 126);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(88, 19);
            label3.TabIndex = 10;
            label3.Text = "Loại Phòng ";
            // 
            // txtGiaGio
            // 
            txtGiaGio.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGiaGio.Location = new Point(181, 72);
            txtGiaGio.Margin = new Padding(4);
            txtGiaGio.Name = "txtGiaGio";
            txtGiaGio.Size = new Size(391, 26);
            txtGiaGio.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 77);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(85, 19);
            label2.TabIndex = 8;
            label2.Text = "Giá Giờ(*):";
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.White;
            btnSua.Location = new Point(621, 82);
            btnSua.Margin = new Padding(4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(134, 48);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.White;
            btnHuy.Location = new Point(788, 82);
            btnHuy.Margin = new Padding(4);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(134, 48);
            btnHuy.TabIndex = 6;
            btnHuy.Text = "Huỷ bỏ";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.White;
            btnThoat.Location = new Point(788, 151);
            btnThoat.Margin = new Padding(4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(134, 48);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.Khaki;
            btnLuu.ForeColor = Color.Red;
            btnLuu.Location = new Point(621, 151);
            btnLuu.Margin = new Padding(4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(134, 48);
            btnLuu.TabIndex = 4;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Khaki;
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(788, 19);
            btnXoa.Margin = new Padding(4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(134, 48);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // txtTenPhong
            // 
            txtTenPhong.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenPhong.Location = new Point(181, 27);
            txtTenPhong.Margin = new Padding(4);
            txtTenPhong.Name = "txtTenPhong";
            txtTenPhong.Size = new Size(391, 26);
            txtTenPhong.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 19);
            label1.TabIndex = 0;
            label1.Text = "Tên Phòng(*):";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(cbLoaiPhong);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtGiaGio);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnHuy);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtTenPhong);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(18, 16);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(967, 237);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm Kiếm Phòng";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rdbBaoTri);
            groupBox3.Controls.Add(rdbĐangDung);
            groupBox3.Controls.Add(rdbTrong);
            groupBox3.Location = new Point(18, 156);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(554, 61);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Trạng Thái";
            // 
            // rdbBaoTri
            // 
            rdbBaoTri.AutoSize = true;
            rdbBaoTri.Location = new Point(388, 25);
            rdbBaoTri.Name = "rdbBaoTri";
            rdbBaoTri.Size = new Size(78, 23);
            rdbBaoTri.TabIndex = 17;
            rdbBaoTri.TabStop = true;
            rdbBaoTri.Text = "Bảo Trì";
            rdbBaoTri.UseVisualStyleBackColor = true;
            // 
            // rdbĐangDung
            // 
            rdbĐangDung.AutoSize = true;
            rdbĐangDung.Location = new Point(204, 25);
            rdbĐangDung.Name = "rdbĐangDung";
            rdbĐangDung.Size = new Size(106, 23);
            rdbĐangDung.TabIndex = 16;
            rdbĐangDung.TabStop = true;
            rdbĐangDung.Text = "Đang Dùng";
            rdbĐangDung.UseVisualStyleBackColor = true;
            // 
            // rdbTrong
            // 
            rdbTrong.AutoSize = true;
            rdbTrong.Location = new Point(65, 25);
            rdbTrong.Name = "rdbTrong";
            rdbTrong.Size = new Size(67, 23);
            rdbTrong.TabIndex = 15;
            rdbTrong.TabStop = true;
            rdbTrong.Text = "Trống";
            rdbTrong.UseVisualStyleBackColor = true;
            // 
            // cbLoaiPhong
            // 
            cbLoaiPhong.FormattingEnabled = true;
            cbLoaiPhong.Location = new Point(181, 123);
            cbLoaiPhong.Name = "cbLoaiPhong";
            cbLoaiPhong.Size = new Size(391, 27);
            cbLoaiPhong.TabIndex = 12;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.White;
            btnThem.Location = new Point(621, 19);
            btnThem.Margin = new Padding(4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(134, 48);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // IDPhong
            // 
            IDPhong.DataPropertyName = "ID";
            IDPhong.HeaderText = "ID";
            IDPhong.Name = "IDPhong";
            // 
            // TenPhong
            // 
            TenPhong.DataPropertyName = "TenPhong";
            TenPhong.HeaderText = "Tên Phòng";
            TenPhong.Name = "TenPhong";
            // 
            // GiaGio
            // 
            GiaGio.DataPropertyName = "GiaGio";
            GiaGio.HeaderText = "Giá Giờ";
            GiaGio.Name = "GiaGio";
            // 
            // LoaiPhong
            // 
            LoaiPhong.DataPropertyName = "LoaiPhong";
            LoaiPhong.HeaderText = "Loại Phòng";
            LoaiPhong.Name = "LoaiPhong";
            // 
            // TrangThai
            // 
            TrangThai.DataPropertyName = "TrangThai";
            TrangThai.HeaderText = "Trạng Thái";
            TrangThai.Name = "TrangThai";
            // 
            // frmPhong
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(1002, 570);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmPhong";
            Text = "frmPhong";
            Load += frmPhong_Load_1;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Label label3;
        private TextBox txtGiaGio;
        private Label label2;
        private Button btnSua;
        private Button btnHuy;
        private Button btnThoat;
        private Button btnLuu;
        private Button btnXoa;
        private TextBox txtTenPhong;
        private Label label1;
        private GroupBox groupBox1;
        private Button btnThem;
        private ComboBox cbLoaiPhong;
        private GroupBox groupBox3;
        private RadioButton rdbBaoTri;
        private RadioButton rdbĐangDung;
        private RadioButton rdbTrong;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn IDPhong;
        private DataGridViewTextBoxColumn TenPhong;
        private DataGridViewTextBoxColumn GiaGio;
        private DataGridViewTextBoxColumn LoaiPhong;
        private DataGridViewTextBoxColumn TrangThai;
    }
}