namespace QUANLYNHASACH_DOAN
{
    partial class frmQuanly_theloai
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
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.MATL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bntXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnQuaylai = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.tbTenTL = new System.Windows.Forms.TextBox();
            this.tbMaTL = new System.Windows.Forms.TextBox();
            this.lbTENTL = new System.Windows.Forms.Label();
            this.lbMATL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCategory
            // 
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MATL,
            this.TENTL});
            this.dgvCategory.Location = new System.Drawing.Point(398, 1);
            this.dgvCategory.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.RowHeadersWidth = 51;
            this.dgvCategory.Size = new System.Drawing.Size(381, 312);
            this.dgvCategory.TabIndex = 0;
            this.dgvCategory.SelectionChanged += new System.EventHandler(this.dgvCategory_SelectionChanged);
            // 
            // MATL
            // 
            this.MATL.DataPropertyName = "MATL";
            this.MATL.HeaderText = "Mã thể loại";
            this.MATL.MinimumWidth = 6;
            this.MATL.Name = "MATL";
            this.MATL.Width = 125;
            // 
            // TENTL
            // 
            this.TENTL.DataPropertyName = "TENTL";
            this.TENTL.HeaderText = "Tên thể loại";
            this.TENTL.MinimumWidth = 6;
            this.TENTL.Name = "TENTL";
            this.TENTL.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bntXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnQuaylai);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.tbTenTL);
            this.groupBox1.Controls.Add(this.tbMaTL);
            this.groupBox1.Controls.Add(this.lbTENTL);
            this.groupBox1.Controls.Add(this.lbMATL);
            this.groupBox1.Location = new System.Drawing.Point(0, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(399, 312);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thể loại";
            // 
            // bntXoa
            // 
            this.bntXoa.Location = new System.Drawing.Point(168, 214);
            this.bntXoa.Margin = new System.Windows.Forms.Padding(4);
            this.bntXoa.Name = "bntXoa";
            this.bntXoa.Size = new System.Drawing.Size(55, 63);
            this.bntXoa.TabIndex = 19;
            this.bntXoa.Text = "Xóa";
            this.bntXoa.UseVisualStyleBackColor = true;
            this.bntXoa.Click += new System.EventHandler(this.bntXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(90, 214);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(57, 63);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(13, 214);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(55, 63);
            this.btnHuy.TabIndex = 17;
            this.btnHuy.Text = "Hủy bỏ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnQuaylai
            // 
            this.btnQuaylai.Location = new System.Drawing.Point(321, 214);
            this.btnQuaylai.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuaylai.Name = "btnQuaylai";
            this.btnQuaylai.Size = new System.Drawing.Size(59, 63);
            this.btnQuaylai.TabIndex = 15;
            this.btnQuaylai.Text = "Quay lại";
            this.btnQuaylai.UseVisualStyleBackColor = true;
            this.btnQuaylai.Click += new System.EventHandler(this.btnQuaylai_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(244, 214);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(55, 63);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // tbTenTL
            // 
            this.tbTenTL.Location = new System.Drawing.Point(159, 109);
            this.tbTenTL.Margin = new System.Windows.Forms.Padding(4);
            this.tbTenTL.Name = "tbTenTL";
            this.tbTenTL.Size = new System.Drawing.Size(187, 22);
            this.tbTenTL.TabIndex = 7;
            // 
            // tbMaTL
            // 
            this.tbMaTL.Location = new System.Drawing.Point(159, 61);
            this.tbMaTL.Margin = new System.Windows.Forms.Padding(4);
            this.tbMaTL.Name = "tbMaTL";
            this.tbMaTL.Size = new System.Drawing.Size(187, 22);
            this.tbMaTL.TabIndex = 6;
            // 
            // lbTENTL
            // 
            this.lbTENTL.AutoSize = true;
            this.lbTENTL.Location = new System.Drawing.Point(36, 109);
            this.lbTENTL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTENTL.Name = "lbTENTL";
            this.lbTENTL.Size = new System.Drawing.Size(87, 17);
            this.lbTENTL.TabIndex = 5;
            this.lbTENTL.Text = "Tên thể loại:";
            // 
            // lbMATL
            // 
            this.lbMATL.AutoSize = true;
            this.lbMATL.Location = new System.Drawing.Point(36, 61);
            this.lbMATL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMATL.Name = "lbMATL";
            this.lbMATL.Size = new System.Drawing.Size(81, 17);
            this.lbMATL.TabIndex = 1;
            this.lbMATL.Text = "Mã thể loại:";
            // 
            // frmQuanly_theloai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 312);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvCategory);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuanly_theloai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thể loại";
            this.Load += new System.EventHandler(this.frmQuanly_theloai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCategory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbTenTL;
        private System.Windows.Forms.TextBox tbMaTL;
        private System.Windows.Forms.Label lbTENTL;
        private System.Windows.Forms.Label lbMATL;
        private System.Windows.Forms.Button bntXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnQuaylai;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENTL;
    }
}