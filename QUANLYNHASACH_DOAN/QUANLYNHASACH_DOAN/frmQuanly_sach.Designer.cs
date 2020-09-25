namespace QUANLYNHASACH_DOAN
{
    partial class frmQuanly_sach
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
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbMads = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboTheloai = new System.Windows.Forms.ComboBox();
            this.btnQuaylai = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.tbDongia = new System.Windows.Forms.TextBox();
            this.tbSoluong = new System.Windows.Forms.TextBox();
            this.tbTacgia = new System.Windows.Forms.TextBox();
            this.tbTensach = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MADS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSACH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TACGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(166, 417);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(62, 58);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa ";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dgvBook
            // 
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MADS,
            this.TENSACH,
            this.MATL,
            this.TACGIA,
            this.SOLUONG,
            this.DONGIA});
            this.dgvBook.Location = new System.Drawing.Point(408, 0);
            this.dgvBook.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.RowHeadersWidth = 51;
            this.dgvBook.Size = new System.Drawing.Size(825, 541);
            this.dgvBook.TabIndex = 7;
            this.dgvBook.SelectionChanged += new System.EventHandler(this.dgvBook_SelectionChanged);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(245, 417);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(64, 58);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa ";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(85, 417);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(63, 58);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbMads);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboTheloai);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnQuaylai);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.tbDongia);
            this.groupBox1.Controls.Add(this.tbSoluong);
            this.groupBox1.Controls.Add(this.tbTacgia);
            this.groupBox1.Controls.Add(this.tbTensach);
            this.groupBox1.Controls.Add(this.lbEmail);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-1, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(414, 541);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đầu sách";
            // 
            // tbMads
            // 
            this.tbMads.Location = new System.Drawing.Point(185, 68);
            this.tbMads.Margin = new System.Windows.Forms.Padding(4);
            this.tbMads.Name = "tbMads";
            this.tbMads.Size = new System.Drawing.Size(172, 22);
            this.tbMads.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 68);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Mã đầu sách";
            // 
            // cboTheloai
            // 
            this.cboTheloai.FormattingEnabled = true;
            this.cboTheloai.Location = new System.Drawing.Point(185, 157);
            this.cboTheloai.Margin = new System.Windows.Forms.Padding(4);
            this.cboTheloai.Name = "cboTheloai";
            this.cboTheloai.Size = new System.Drawing.Size(172, 24);
            this.cboTheloai.TabIndex = 12;
            // 
            // btnQuaylai
            // 
            this.btnQuaylai.Location = new System.Drawing.Point(332, 417);
            this.btnQuaylai.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuaylai.Name = "btnQuaylai";
            this.btnQuaylai.Size = new System.Drawing.Size(69, 58);
            this.btnQuaylai.TabIndex = 11;
            this.btnQuaylai.Text = "Quay lại";
            this.btnQuaylai.UseVisualStyleBackColor = true;
            this.btnQuaylai.Click += new System.EventHandler(this.btnQuaylai_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(4, 417);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(63, 58);
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "Hủy bỏ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // tbDongia
            // 
            this.tbDongia.Location = new System.Drawing.Point(185, 301);
            this.tbDongia.Margin = new System.Windows.Forms.Padding(4);
            this.tbDongia.Name = "tbDongia";
            this.tbDongia.Size = new System.Drawing.Size(172, 22);
            this.tbDongia.TabIndex = 9;
            // 
            // tbSoluong
            // 
            this.tbSoluong.Location = new System.Drawing.Point(185, 251);
            this.tbSoluong.Margin = new System.Windows.Forms.Padding(4);
            this.tbSoluong.Name = "tbSoluong";
            this.tbSoluong.Size = new System.Drawing.Size(172, 22);
            this.tbSoluong.TabIndex = 8;
            // 
            // tbTacgia
            // 
            this.tbTacgia.Location = new System.Drawing.Point(185, 205);
            this.tbTacgia.Margin = new System.Windows.Forms.Padding(4);
            this.tbTacgia.Name = "tbTacgia";
            this.tbTacgia.Size = new System.Drawing.Size(172, 22);
            this.tbTacgia.TabIndex = 7;
            // 
            // tbTensach
            // 
            this.tbTensach.Location = new System.Drawing.Point(185, 115);
            this.tbTensach.Margin = new System.Windows.Forms.Padding(4);
            this.tbTensach.Name = "tbTensach";
            this.tbTensach.Size = new System.Drawing.Size(172, 22);
            this.tbTensach.TabIndex = 5;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(41, 303);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(57, 17);
            this.lbEmail.TabIndex = 4;
            this.lbEmail.Text = "Đơn giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 253);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tác giả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thể loại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên sách";
            // 
            // MADS
            // 
            this.MADS.DataPropertyName = "MADS";
            this.MADS.HeaderText = "Mã đầu sách";
            this.MADS.MinimumWidth = 6;
            this.MADS.Name = "MADS";
            this.MADS.Width = 125;
            // 
            // TENSACH
            // 
            this.TENSACH.DataPropertyName = "TENSACH";
            this.TENSACH.HeaderText = "Tên sách";
            this.TENSACH.MinimumWidth = 6;
            this.TENSACH.Name = "TENSACH";
            this.TENSACH.Width = 150;
            // 
            // MATL
            // 
            this.MATL.DataPropertyName = "MATL";
            this.MATL.HeaderText = "Thể loại";
            this.MATL.MinimumWidth = 6;
            this.MATL.Name = "MATL";
            this.MATL.Width = 125;
            // 
            // TACGIA
            // 
            this.TACGIA.DataPropertyName = "TACGIA";
            this.TACGIA.HeaderText = "Tác giả";
            this.TACGIA.MinimumWidth = 6;
            this.TACGIA.Name = "TACGIA";
            this.TACGIA.Width = 125;
            // 
            // SOLUONG
            // 
            this.SOLUONG.DataPropertyName = "SOLUONG";
            this.SOLUONG.HeaderText = "Số lượng";
            this.SOLUONG.MinimumWidth = 6;
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.Width = 125;
            // 
            // DONGIA
            // 
            this.DONGIA.DataPropertyName = "DONGIA";
            this.DONGIA.HeaderText = "Đơn giá";
            this.DONGIA.MinimumWidth = 6;
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.Width = 125;
            // 
            // frmQuanly_sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 554);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvBook);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuanly_sach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQuanly_sach";
            this.Load += new System.EventHandler(this.frmQuanly_sach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboTheloai;
        private System.Windows.Forms.Button btnQuaylai;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TextBox tbDongia;
        private System.Windows.Forms.TextBox tbSoluong;
        private System.Windows.Forms.TextBox tbTacgia;
        private System.Windows.Forms.TextBox tbTensach;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMads;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn MADS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSACH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TACGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
    }
}