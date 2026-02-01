namespace DoAn_GiaiDoan1.Forms
{
    partial class frmCaLamViec
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
            label8 = new Label();
            label7 = new Label();
            dtpBatDau = new DateTimePicker();
            dtpKetThuc = new DateTimePicker();
            txtTenCa = new TextBox();
            label4 = new Label();
            groupBox2 = new GroupBox();
            btnSua = new Button();
            btnThoat = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            btnHuy = new Button();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenCa = new DataGridViewTextBoxColumn();
            GioBatDau = new DataGridViewTextBoxColumn();
            GioKetThuc = new DataGridViewTextBoxColumn();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 97);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(117, 19);
            label8.TabIndex = 27;
            label8.Text = "Giờ Bắt Đầu(*):";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 141);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(127, 19);
            label7.TabIndex = 26;
            label7.Text = "Giờ Kết Thúc (*):";
            // 
            // dtpBatDau
            // 
            dtpBatDau.Format = DateTimePickerFormat.Time;
            dtpBatDau.Location = new Point(189, 91);
            dtpBatDau.Name = "dtpBatDau";
            dtpBatDau.Size = new Size(200, 26);
            dtpBatDau.TabIndex = 24;
            // 
            // dtpKetThuc
            // 
            dtpKetThuc.Format = DateTimePickerFormat.Time;
            dtpKetThuc.Location = new Point(189, 134);
            dtpKetThuc.Name = "dtpKetThuc";
            dtpKetThuc.Size = new Size(200, 26);
            dtpKetThuc.TabIndex = 23;
            // 
            // txtTenCa
            // 
            txtTenCa.Location = new Point(155, 39);
            txtTenCa.Name = "txtTenCa";
            txtTenCa.Size = new Size(234, 26);
            txtTenCa.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 47);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(136, 19);
            label4.TabIndex = 17;
            label4.Text = "Tên ca làm việc(*):";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(31, 243);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(734, 294);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhân viên";
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.White;
            btnSua.Location = new Point(442, 87);
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
            btnThoat.Location = new Point(579, 153);
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
            btnLuu.Location = new Point(442, 153);
            btnLuu.Margin = new Padding(4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(114, 34);
            btnLuu.TabIndex = 4;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Khaki;
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(579, 21);
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
            btnThem.Location = new Point(442, 21);
            btnThem.Margin = new Padding(4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(114, 34);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.White;
            btnHuy.Location = new Point(579, 87);
            btnHuy.Margin = new Padding(4);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(114, 34);
            btnHuy.TabIndex = 6;
            btnHuy.Text = "Huỷ bỏ";
            btnHuy.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(dtpBatDau);
            groupBox1.Controls.Add(dtpKetThuc);
            groupBox1.Controls.Add(txtTenCa);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnHuy);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(31, 16);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(734, 201);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ca Làm Việc";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, TenCa, GioBatDau, GioKetThuc });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 22);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(728, 269);
            dataGridView1.TabIndex = 1;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // TenCa
            // 
            TenCa.DataPropertyName = "TenCa";
            TenCa.HeaderText = "Tên Ca Làm Việc";
            TenCa.Name = "TenCa";
            // 
            // GioBatDau
            // 
            GioBatDau.DataPropertyName = "GioBatDau";
            GioBatDau.HeaderText = "Giờ Bắt Đầu";
            GioBatDau.Name = "GioBatDau";
            // 
            // GioKetThuc
            // 
            GioKetThuc.DataPropertyName = "GioKetThuc";
            GioKetThuc.HeaderText = "Giờ Kết Thúc";
            GioKetThuc.Name = "GioKetThuc";
            // 
            // frmCaLamViec
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(1029, 570);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "frmCaLamViec";
            Text = "frmCaLamViec";
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label8;
        private Label label7;
        private DateTimePicker dtpBatDau;
        private DateTimePicker dtpKetThuc;
        private TextBox txtTenCa;
        private Label label4;
        private GroupBox groupBox2;
        private Button btnSua;
        private Button btnThoat;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnThem;
        private Button btnHuy;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenCa;
        private DataGridViewTextBoxColumn GioBatDau;
        private DataGridViewTextBoxColumn GioKetThuc;
    }
}