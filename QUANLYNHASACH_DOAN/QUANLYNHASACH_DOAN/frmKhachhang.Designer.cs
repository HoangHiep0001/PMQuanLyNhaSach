namespace QUANLYNHASACH_DOAN
{
    partial class frmKhachhang
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
            this.btbXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.bntQuaylai = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.tbGender = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbSdt = new System.Windows.Forms.TextBox();
            this.tbDiachi = new System.Windows.Forms.TextBox();
            this.tbHoten = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMakh = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.MA_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HO_TEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_CHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIOITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // btbXoa
            // 
            this.btbXoa.Location = new System.Drawing.Point(163, 354);
            this.btbXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btbXoa.Name = "btbXoa";
            this.btbXoa.Size = new System.Drawing.Size(73, 40);
            this.btbXoa.TabIndex = 6;
            this.btbXoa.Text = "Xóa";
            this.btbXoa.UseVisualStyleBackColor = true;
            this.btbXoa.Click += new System.EventHandler(this.btbXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(77, 354);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(78, 40);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // bntQuaylai
            // 
            this.bntQuaylai.Location = new System.Drawing.Point(324, 354);
            this.bntQuaylai.Margin = new System.Windows.Forms.Padding(4);
            this.bntQuaylai.Name = "bntQuaylai";
            this.bntQuaylai.Size = new System.Drawing.Size(73, 40);
            this.bntQuaylai.TabIndex = 8;
            this.bntQuaylai.Text = "Quay lại";
            this.bntQuaylai.UseVisualStyleBackColor = true;
            this.bntQuaylai.Click += new System.EventHandler(this.bntQuaylai_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.bntQuaylai);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btbXoa);
            this.groupBox1.Controls.Add(this.tbGender);
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.tbSdt);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.tbDiachi);
            this.groupBox1.Controls.Add(this.tbHoten);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbMakh);
            this.groupBox1.Controls.Add(this.lbEmail);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(421, 509);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(243, 354);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(73, 40);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(0, 354);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(69, 40);
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "Hủy bỏ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click_1);
            // 
            // tbGender
            // 
            this.tbGender.Location = new System.Drawing.Point(193, 290);
            this.tbGender.Margin = new System.Windows.Forms.Padding(4);
            this.tbGender.Name = "tbGender";
            this.tbGender.Size = new System.Drawing.Size(162, 22);
            this.tbGender.TabIndex = 9;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(193, 244);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(162, 22);
            this.tbEmail.TabIndex = 9;
            // 
            // tbSdt
            // 
            this.tbSdt.Location = new System.Drawing.Point(193, 190);
            this.tbSdt.Margin = new System.Windows.Forms.Padding(4);
            this.tbSdt.Name = "tbSdt";
            this.tbSdt.Size = new System.Drawing.Size(162, 22);
            this.tbSdt.TabIndex = 8;
            // 
            // tbDiachi
            // 
            this.tbDiachi.Location = new System.Drawing.Point(193, 144);
            this.tbDiachi.Margin = new System.Windows.Forms.Padding(4);
            this.tbDiachi.Name = "tbDiachi";
            this.tbDiachi.Size = new System.Drawing.Size(162, 22);
            this.tbDiachi.TabIndex = 7;
            // 
            // tbHoten
            // 
            this.tbHoten.Location = new System.Drawing.Point(193, 95);
            this.tbHoten.Margin = new System.Windows.Forms.Padding(4);
            this.tbHoten.Name = "tbHoten";
            this.tbHoten.Size = new System.Drawing.Size(162, 22);
            this.tbHoten.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 290);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giới tính";
            // 
            // tbMakh
            // 
            this.tbMakh.Location = new System.Drawing.Point(193, 52);
            this.tbMakh.Margin = new System.Windows.Forms.Padding(4);
            this.tbMakh.Name = "tbMakh";
            this.tbMakh.Size = new System.Drawing.Size(162, 22);
            this.tbMakh.TabIndex = 5;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(51, 244);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(42, 17);
            this.lbEmail.TabIndex = 4;
            this.lbEmail.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 190);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khách hàng";
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MA_KH,
            this.HO_TEN,
            this.DIA_CHI,
            this.SDT,
            this._EMAIL,
            this.GIOITINH});
            this.dgvCustomer.Location = new System.Drawing.Point(432, 12);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.RowHeadersWidth = 51;
            this.dgvCustomer.RowTemplate.Height = 24;
            this.dgvCustomer.Size = new System.Drawing.Size(785, 501);
            this.dgvCustomer.TabIndex = 10;
            this.dgvCustomer.SelectionChanged += new System.EventHandler(this.dgvCustomer_SelectionChanged);
            // 
            // MA_KH
            // 
            this.MA_KH.DataPropertyName = "MAKH";
            this.MA_KH.HeaderText = "MAKH";
            this.MA_KH.MinimumWidth = 6;
            this.MA_KH.Name = "MA_KH";
            this.MA_KH.Width = 125;
            // 
            // HO_TEN
            // 
            this.HO_TEN.DataPropertyName = "HOTEN";
            this.HO_TEN.HeaderText = "HOTEN";
            this.HO_TEN.MinimumWidth = 6;
            this.HO_TEN.Name = "HO_TEN";
            this.HO_TEN.Width = 140;
            // 
            // DIA_CHI
            // 
            this.DIA_CHI.DataPropertyName = "DIACHI";
            this.DIA_CHI.HeaderText = "DIACHI";
            this.DIA_CHI.MinimumWidth = 6;
            this.DIA_CHI.Name = "DIA_CHI";
            this.DIA_CHI.Width = 125;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SDT";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.Width = 125;
            // 
            // _EMAIL
            // 
            this._EMAIL.DataPropertyName = "EMAIL";
            this._EMAIL.HeaderText = "EMAIL";
            this._EMAIL.MinimumWidth = 6;
            this._EMAIL.Name = "_EMAIL";
            this._EMAIL.Width = 125;
            // 
            // GIOITINH
            // 
            this.GIOITINH.DataPropertyName = "GIOITINH";
            this.GIOITINH.HeaderText = "GENDER";
            this.GIOITINH.MinimumWidth = 6;
            this.GIOITINH.Name = "GIOITINH";
            this.GIOITINH.Width = 65;
            // 
            // frmKhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 517);
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmKhachhang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin khách hàng";
            this.Load += new System.EventHandler(this.frmKhachhang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btbXoa;

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button bntQuaylai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbSdt;
        private System.Windows.Forms.TextBox tbDiachi;
        private System.Windows.Forms.TextBox tbHoten;
        private System.Windows.Forms.TextBox tbMakh;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.TextBox tbGender;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn HO_TEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_CHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn _EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIOITINH;
    }
}