namespace QUANLYNHASACH_DOAN
{
    partial class frmNhapSach
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
            this.grbox1 = new System.Windows.Forms.GroupBox();
            this.tbNhanVien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTongTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNhapSach = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbNhaCungCap = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXoaSach = new System.Windows.Forms.Button();
            this.btnThemSach = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSLSachNhap = new System.Windows.Forms.TextBox();
            this.cbSach = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTacGia = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvChiTietPhieuNhap = new System.Windows.Forms.DataGridView();
            this.grbox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // grbox1
            // 
            this.grbox1.Controls.Add(this.tbNhanVien);
            this.grbox1.Controls.Add(this.label8);
            this.grbox1.Controls.Add(this.tbTongTien);
            this.grbox1.Controls.Add(this.label1);
            this.grbox1.Controls.Add(this.dtpNhapSach);
            this.grbox1.Controls.Add(this.label3);
            this.grbox1.Controls.Add(this.cbNhaCungCap);
            this.grbox1.Controls.Add(this.label4);
            this.grbox1.Location = new System.Drawing.Point(31, 50);
            this.grbox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbox1.Name = "grbox1";
            this.grbox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbox1.Size = new System.Drawing.Size(405, 219);
            this.grbox1.TabIndex = 10;
            this.grbox1.TabStop = false;
            this.grbox1.Text = "THÔNG TIN PHIẾU NHẬP";
            // 
            // tbNhanVien
            // 
            this.tbNhanVien.Location = new System.Drawing.Point(139, 117);
            this.tbNhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNhanVien.Name = "tbNhanVien";
            this.tbNhanVien.Size = new System.Drawing.Size(234, 22);
            this.tbNhanVien.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 128);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Nhân viên";
            // 
            // tbTongTien
            // 
            this.tbTongTien.Enabled = false;
            this.tbTongTien.Location = new System.Drawing.Point(139, 166);
            this.tbTongTien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTongTien.Name = "tbTongTien";
            this.tbTongTien.Size = new System.Drawing.Size(234, 22);
            this.tbTongTien.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ngày lập phiếu";
            // 
            // dtpNhapSach
            // 
            this.dtpNhapSach.Location = new System.Drawing.Point(139, 25);
            this.dtpNhapSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpNhapSach.Name = "dtpNhapSach";
            this.dtpNhapSach.Size = new System.Drawing.Size(234, 22);
            this.dtpNhapSach.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tên nhà cung cấp";
            // 
            // cbNhaCungCap
            // 
            this.cbNhaCungCap.FormattingEnabled = true;
            this.cbNhaCungCap.Location = new System.Drawing.Point(139, 70);
            this.cbNhaCungCap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbNhaCungCap.Name = "cbNhaCungCap";
            this.cbNhaCungCap.Size = new System.Drawing.Size(234, 24);
            this.cbNhaCungCap.TabIndex = 11;
            this.cbNhaCungCap.SelectedIndexChanged += new System.EventHandler(this.cbNhaCungCap_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tổng tiền";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnXoaSach);
            this.groupBox2.Controls.Add(this.btnThemSach);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbSLSachNhap);
            this.groupBox2.Controls.Add(this.cbSach);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbTacGia);
            this.groupBox2.Location = new System.Drawing.Point(444, 50);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(483, 219);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "THÔNG TIN SÁCH";
            // 
            // btnXoaSach
            // 
            this.btnXoaSach.Location = new System.Drawing.Point(256, 166);
            this.btnXoaSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoaSach.Name = "btnXoaSach";
            this.btnXoaSach.Size = new System.Drawing.Size(113, 33);
            this.btnXoaSach.TabIndex = 13;
            this.btnXoaSach.Text = "Xóa sách";
            this.btnXoaSach.UseVisualStyleBackColor = true;
            this.btnXoaSach.Click += new System.EventHandler(this.btnXoaSach_Click);
            // 
            // btnThemSach
            // 
            this.btnThemSach.Location = new System.Drawing.Point(108, 166);
            this.btnThemSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Size = new System.Drawing.Size(113, 33);
            this.btnThemSach.TabIndex = 3;
            this.btnThemSach.Text = "Thêm sách";
            this.btnThemSach.UseVisualStyleBackColor = true;
            this.btnThemSach.Click += new System.EventHandler(this.btnThemSach_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 117);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Số lượng nhập";
            // 
            // tbSLSachNhap
            // 
            this.tbSLSachNhap.Location = new System.Drawing.Point(152, 113);
            this.tbSLSachNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSLSachNhap.Name = "tbSLSachNhap";
            this.tbSLSachNhap.Size = new System.Drawing.Size(216, 22);
            this.tbSLSachNhap.TabIndex = 9;
            this.tbSLSachNhap.TextChanged += new System.EventHandler(this.tbSLSachMua_TextChanged);
            // 
            // cbSach
            // 
            this.cbSach.FormattingEnabled = true;
            this.cbSach.Location = new System.Drawing.Point(152, 32);
            this.cbSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSach.Name = "cbSach";
            this.cbSach.Size = new System.Drawing.Size(216, 24);
            this.cbSach.TabIndex = 8;
            this.cbSach.SelectedIndexChanged += new System.EventHandler(this.cbSach_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tác giả";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 34);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tên Sách";
            // 
            // tbTacGia
            // 
            this.tbTacGia.Location = new System.Drawing.Point(152, 71);
            this.tbTacGia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTacGia.Name = "tbTacGia";
            this.tbTacGia.Size = new System.Drawing.Size(216, 22);
            this.tbTacGia.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(740, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 53);
            this.button2.TabIndex = 14;
            this.button2.Text = "Thanh Toán ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvChiTietPhieuNhap
            // 
            this.dgvChiTietPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietPhieuNhap.Location = new System.Drawing.Point(31, 277);
            this.dgvChiTietPhieuNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvChiTietPhieuNhap.Name = "dgvChiTietPhieuNhap";
            this.dgvChiTietPhieuNhap.RowHeadersWidth = 51;
            this.dgvChiTietPhieuNhap.Size = new System.Drawing.Size(896, 262);
            this.dgvChiTietPhieuNhap.TabIndex = 11;
            this.dgvChiTietPhieuNhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietPhieuNhap_CellContentClick);
            // 
            // frmNhapSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 554);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvChiTietPhieuNhap);
            this.Controls.Add(this.grbox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmNhapSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập sách ";
            this.grbox1.ResumeLayout(false);
            this.grbox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuNhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbNhaCungCap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNhapSach;
        private System.Windows.Forms.TextBox tbTongTien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXoaSach;
        private System.Windows.Forms.Button btnThemSach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSLSachNhap;
        private System.Windows.Forms.ComboBox cbSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTacGia;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvChiTietPhieuNhap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbNhanVien;
    }
}