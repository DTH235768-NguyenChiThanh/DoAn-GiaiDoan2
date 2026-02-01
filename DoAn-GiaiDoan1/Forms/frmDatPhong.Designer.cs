namespace DoAn_GiaiDoan1.Forms
{
    partial class frmDatPhong
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
            btnHuy = new Button();
            groupBox1 = new GroupBox();
            cbTrangThai = new ComboBox();
            label3 = new Label();
            btnSua = new Button();
            btnThoat = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            cbKhachHang = new ComboBox();
            cbPhong = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtLoaiPhong = new TextBox();
            txtGiaGio = new TextBox();
            dtpNgayDat = new DateTimePicker();
            dtpKetThuc = new DateTimePicker();
            dtpBatDau = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtSoGio = new TextBox();
            txtTienPhong = new TextBox();
            label9 = new Label();
            label10 = new Label();
            ID = new DataGridViewTextBoxColumn();
            PhongID = new DataGridViewTextBoxColumn();
            KhachHangID = new DataGridViewTextBoxColumn();
            TrangThai = new DataGridViewTextBoxColumn();
            LoaiPhong = new DataGridViewTextBoxColumn();
            GiaGio = new DataGridViewTextBoxColumn();
            TGBatDau = new DataGridViewTextBoxColumn();
            TGKetThuc = new DataGridViewTextBoxColumn();
            NgayDat = new DataGridViewTextBoxColumn();
            SoGio = new DataGridViewTextBoxColumn();
            TienPhong = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.White;
            btnHuy.Location = new Point(845, 105);
            btnHuy.Margin = new Padding(4);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(114, 34);
            btnHuy.TabIndex = 6;
            btnHuy.Text = "Huỷ bỏ";
            btnHuy.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtTienPhong);
            groupBox1.Controls.Add(txtSoGio);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(dtpBatDau);
            groupBox1.Controls.Add(dtpKetThuc);
            groupBox1.Controls.Add(dtpNgayDat);
            groupBox1.Controls.Add(txtGiaGio);
            groupBox1.Controls.Add(txtLoaiPhong);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cbPhong);
            groupBox1.Controls.Add(cbKhachHang);
            groupBox1.Controls.Add(cbTrangThai);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnHuy);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(13, 13);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(967, 237);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Đặt Phòng";
            // 
            // cbTrangThai
            // 
            cbTrangThai.FormattingEnabled = true;
            cbTrangThai.Items.AddRange(new object[] { "Đang thuê", "Đã trả", "Đặt trước" });
            cbTrangThai.Location = new Point(141, 106);
            cbTrangThai.Name = "cbTrangThai";
            cbTrangThai.Size = new Size(147, 27);
            cbTrangThai.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 114);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(105, 19);
            label3.TabIndex = 10;
            label3.Text = "Trạng Thái(*):";
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.White;
            btnSua.Location = new Point(708, 105);
            btnSua.Margin = new Padding(4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(114, 34);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.White;
            btnThoat.Location = new Point(845, 171);
            btnThoat.Margin = new Padding(4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(114, 34);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.Khaki;
            btnLuu.ForeColor = Color.Red;
            btnLuu.Location = new Point(708, 171);
            btnLuu.Margin = new Padding(4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(114, 34);
            btnLuu.TabIndex = 4;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Khaki;
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(845, 39);
            btnXoa.Margin = new Padding(4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(114, 34);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.White;
            btnThem.Location = new Point(708, 39);
            btnThem.Margin = new Padding(4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(114, 34);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, PhongID, KhachHangID, TrangThai, LoaiPhong, GiaGio, TGBatDau, TGKetThuc, NgayDat, SoGio, TienPhong });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 22);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(961, 269);
            dataGridView1.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(13, 257);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(967, 294);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhân viên";
            // 
            // cbKhachHang
            // 
            cbKhachHang.FormattingEnabled = true;
            cbKhachHang.Location = new Point(141, 15);
            cbKhachHang.Name = "cbKhachHang";
            cbKhachHang.Size = new Size(147, 27);
            cbKhachHang.TabIndex = 13;
            // 
            // cbPhong
            // 
            cbPhong.FormattingEnabled = true;
            cbPhong.Location = new Point(141, 58);
            cbPhong.Name = "cbPhong";
            cbPhong.Size = new Size(147, 27);
            cbPhong.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 66);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(73, 19);
            label1.TabIndex = 15;
            label1.Text = "Phòng(*):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 26);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(115, 19);
            label2.TabIndex = 16;
            label2.Text = "Khách Hàng(*):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(19, 160);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(107, 19);
            label4.TabIndex = 17;
            label4.Text = "Loại Phòng(*):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(19, 206);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(85, 19);
            label5.TabIndex = 18;
            label5.Text = "Giá Giờ(*):";
            // 
            // txtLoaiPhong
            // 
            txtLoaiPhong.Location = new Point(141, 153);
            txtLoaiPhong.Name = "txtLoaiPhong";
            txtLoaiPhong.Size = new Size(147, 26);
            txtLoaiPhong.TabIndex = 19;
            // 
            // txtGiaGio
            // 
            txtGiaGio.Location = new Point(141, 199);
            txtGiaGio.Name = "txtGiaGio";
            txtGiaGio.Size = new Size(147, 26);
            txtGiaGio.TabIndex = 20;
            // 
            // dtpNgayDat
            // 
            dtpNgayDat.Location = new Point(485, 107);
            dtpNgayDat.Name = "dtpNgayDat";
            dtpNgayDat.Size = new Size(200, 26);
            dtpNgayDat.TabIndex = 22;
            // 
            // dtpKetThuc
            // 
            dtpKetThuc.Format = DateTimePickerFormat.Time;
            dtpKetThuc.Location = new Point(485, 59);
            dtpKetThuc.Name = "dtpKetThuc";
            dtpKetThuc.Size = new Size(200, 26);
            dtpKetThuc.TabIndex = 23;
            // 
            // dtpBatDau
            // 
            dtpBatDau.Format = DateTimePickerFormat.Time;
            dtpBatDau.Location = new Point(485, 16);
            dtpBatDau.Name = "dtpBatDau";
            dtpBatDau.Size = new Size(200, 26);
            dtpBatDau.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(307, 113);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(101, 19);
            label6.TabIndex = 25;
            label6.Text = "Ngày Đặt (*):";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(307, 65);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(169, 19);
            label7.TabIndex = 26;
            label7.Text = "Thời Gian Kết Thúc (*):";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(307, 21);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(159, 19);
            label8.TabIndex = 27;
            label8.Text = "Thời Gian Bắt Đầu(*):";
            // 
            // txtSoGio
            // 
            txtSoGio.Location = new Point(485, 153);
            txtSoGio.Name = "txtSoGio";
            txtSoGio.Size = new Size(200, 26);
            txtSoGio.TabIndex = 28;
            // 
            // txtTienPhong
            // 
            txtTienPhong.Location = new Point(485, 199);
            txtTienPhong.Name = "txtTienPhong";
            txtTienPhong.Size = new Size(200, 26);
            txtTienPhong.TabIndex = 29;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(307, 160);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(82, 19);
            label9.TabIndex = 30;
            label9.Text = "Số Giờ (*):";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(307, 206);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(84, 19);
            label10.TabIndex = 31;
            label10.Text = "Tiền Phòng";
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // PhongID
            // 
            PhongID.DataPropertyName = "PhongID";
            PhongID.HeaderText = "Phòng";
            PhongID.Name = "PhongID";
            // 
            // KhachHangID
            // 
            KhachHangID.DataPropertyName = "KhachHangID";
            KhachHangID.HeaderText = "Khách Hàng";
            KhachHangID.Name = "KhachHangID";
            // 
            // TrangThai
            // 
            TrangThai.DataPropertyName = "TrangThai";
            TrangThai.HeaderText = "Trạng Thái";
            TrangThai.Name = "TrangThai";
            // 
            // LoaiPhong
            // 
            LoaiPhong.DataPropertyName = "LoaiPhong";
            LoaiPhong.HeaderText = "Loại Phòng";
            LoaiPhong.Name = "LoaiPhong";
            // 
            // GiaGio
            // 
            GiaGio.DataPropertyName = "GiaGio";
            GiaGio.HeaderText = "Giá Giờ";
            GiaGio.Name = "GiaGio";
            // 
            // TGBatDau
            // 
            TGBatDau.DataPropertyName = "TGBatDau";
            TGBatDau.HeaderText = "TG Bắt Đầu";
            TGBatDau.Name = "TGBatDau";
            // 
            // TGKetThuc
            // 
            TGKetThuc.DataPropertyName = "TGKetThuc";
            TGKetThuc.HeaderText = "TG Kết Thúc";
            TGKetThuc.Name = "TGKetThuc";
            // 
            // NgayDat
            // 
            NgayDat.DataPropertyName = "NgayDat";
            NgayDat.HeaderText = "Ngày Đặt";
            NgayDat.Name = "NgayDat";
            // 
            // SoGio
            // 
            SoGio.DataPropertyName = "SoGio";
            SoGio.HeaderText = "Số Giờ";
            SoGio.Name = "SoGio";
            // 
            // TienPhong
            // 
            TienPhong.DataPropertyName = "TienPhong";
            TienPhong.HeaderText = "Tiền Phòng";
            TienPhong.Name = "TienPhong";
            // 
            // frmDatPhong
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(1029, 570);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "frmDatPhong";
            Text = "frmDatPhong";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnHuy;
        private GroupBox groupBox1;
        private ComboBox cbTrangThai;
        private Label label3;
        private Button btnSua;
        private Button btnThoat;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnThem;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private Label label2;
        private Label label1;
        private ComboBox cbPhong;
        private ComboBox cbKhachHang;
        private TextBox txtGiaGio;
        private TextBox txtLoaiPhong;
        private Label label5;
        private Label label4;
        private Label label8;
        private Label label7;
        private Label label6;
        private DateTimePicker dtpBatDau;
        private DateTimePicker dtpKetThuc;
        private DateTimePicker dtpNgayDat;
        private Label label10;
        private Label label9;
        private TextBox txtTienPhong;
        private TextBox txtSoGio;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn PhongID;
        private DataGridViewTextBoxColumn KhachHangID;
        private DataGridViewTextBoxColumn TrangThai;
        private DataGridViewTextBoxColumn LoaiPhong;
        private DataGridViewTextBoxColumn GiaGio;
        private DataGridViewTextBoxColumn TGBatDau;
        private DataGridViewTextBoxColumn TGKetThuc;
        private DataGridViewTextBoxColumn NgayDat;
        private DataGridViewTextBoxColumn SoGio;
        private DataGridViewTextBoxColumn TienPhong;
    }
}