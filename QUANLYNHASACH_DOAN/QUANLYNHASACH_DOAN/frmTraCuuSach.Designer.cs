namespace QUANLYNHASACH_DOAN
{
    partial class frmTraCuuSach
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
            this.grbox = new System.Windows.Forms.GroupBox();
            this.tbTacgia = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnTracuu = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.tbTensach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.TENSACH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TACGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbx_TheLoai = new System.Windows.Forms.ComboBox();
            this.grbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.SuspendLayout();
            // 
            // grbox
            // 
            this.grbox.Controls.Add(this.cbx_TheLoai);
            this.grbox.Controls.Add(this.tbTacgia);
            this.grbox.Controls.Add(this.pictureBox3);
            this.grbox.Controls.Add(this.btnTracuu);
            this.grbox.Controls.Add(this.pictureBox2);
            this.grbox.Controls.Add(this.pictureBox1);
            this.grbox.Controls.Add(this.btnExit);
            this.grbox.Controls.Add(this.btnHuy);
            this.grbox.Controls.Add(this.tbTensach);
            this.grbox.Controls.Add(this.label2);
            this.grbox.Controls.Add(this.label3);
            this.grbox.Controls.Add(this.label4);
            this.grbox.Location = new System.Drawing.Point(23, 14);
            this.grbox.Margin = new System.Windows.Forms.Padding(4);
            this.grbox.Name = "grbox";
            this.grbox.Padding = new System.Windows.Forms.Padding(4);
            this.grbox.Size = new System.Drawing.Size(821, 164);
            this.grbox.TabIndex = 8;
            this.grbox.TabStop = false;
            this.grbox.Text = "Thông tin tra cứu";
            // 
            // tbTacgia
            // 
            this.tbTacgia.Location = new System.Drawing.Point(159, 80);
            this.tbTacgia.Margin = new System.Windows.Forms.Padding(4);
            this.tbTacgia.Name = "tbTacgia";
            this.tbTacgia.Size = new System.Drawing.Size(259, 22);
            this.tbTacgia.TabIndex = 23;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::QUANLYNHASACH_DOAN.Properties.Resources.search;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(465, 128);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 28);
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // btnTracuu
            // 
            this.btnTracuu.Location = new System.Drawing.Point(499, 128);
            this.btnTracuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnTracuu.Name = "btnTracuu";
            this.btnTracuu.Size = new System.Drawing.Size(76, 28);
            this.btnTracuu.TabIndex = 21;
            this.btnTracuu.Text = "Tra cứu";
            this.btnTracuu.UseVisualStyleBackColor = true;
            this.btnTracuu.Click += new System.EventHandler(this.btnTracuu_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::QUANLYNHASACH_DOAN.Properties.Resources.exit1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(705, 128);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 28);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QUANLYNHASACH_DOAN.Properties.Resources.delete1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(588, 128);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 28);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(739, 128);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(71, 28);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(621, 128);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(76, 28);
            this.btnHuy.TabIndex = 17;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // tbTensach
            // 
            this.tbTensach.Location = new System.Drawing.Point(159, 36);
            this.tbTensach.Margin = new System.Windows.Forms.Padding(4);
            this.tbTensach.Name = "tbTensach";
            this.tbTensach.Size = new System.Drawing.Size(259, 22);
            this.tbTensach.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tên đầu sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(499, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Thể loại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tên tác giả";
            // 
            // dgvSach
            // 
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TENSACH,
            this.TENTL,
            this.TACGIA,
            this.DONGIA,
            this.SOLUONG});
            this.dgvSach.Location = new System.Drawing.Point(23, 220);
            this.dgvSach.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.RowHeadersWidth = 51;
            this.dgvSach.Size = new System.Drawing.Size(821, 286);
            this.dgvSach.TabIndex = 9;
            // 
            // TENSACH
            // 
            this.TENSACH.DataPropertyName = "TENSACH";
            this.TENSACH.HeaderText = "Tên đầu sách";
            this.TENSACH.MinimumWidth = 6;
            this.TENSACH.Name = "TENSACH";
            this.TENSACH.Width = 150;
            // 
            // TENTL
            // 
            this.TENTL.DataPropertyName = "TENTL";
            this.TENTL.HeaderText = "Thể loại";
            this.TENTL.MinimumWidth = 6;
            this.TENTL.Name = "TENTL";
            this.TENTL.Width = 125;
            // 
            // TACGIA
            // 
            this.TACGIA.DataPropertyName = "TACGIA";
            this.TACGIA.HeaderText = "Tác giả";
            this.TACGIA.MinimumWidth = 6;
            this.TACGIA.Name = "TACGIA";
            this.TACGIA.Width = 120;
            // 
            // DONGIA
            // 
            this.DONGIA.DataPropertyName = "DONGIA";
            this.DONGIA.HeaderText = "Đơn giá";
            this.DONGIA.MinimumWidth = 6;
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.Width = 125;
            // 
            // SOLUONG
            // 
            this.SOLUONG.DataPropertyName = "SOLUONG";
            this.SOLUONG.HeaderText = "Số lượng";
            this.SOLUONG.MinimumWidth = 6;
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.Width = 125;
            // 
            // cbx_TheLoai
            // 
            this.cbx_TheLoai.Location = new System.Drawing.Point(565, 39);
            this.cbx_TheLoai.Name = "cbx_TheLoai";
            this.cbx_TheLoai.Size = new System.Drawing.Size(173, 24);
            this.cbx_TheLoai.TabIndex = 24;
            // 
            // frmTraCuuSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 519);
            this.Controls.Add(this.dgvSach);
            this.Controls.Add(this.grbox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTraCuuSach";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra cứu sách";
            this.Load += new System.EventHandler(this.frmTraCuuSach_Load);
            this.grbox.ResumeLayout(false);
            this.grbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbox;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TextBox tbTensach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnTracuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSACH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENTL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TACGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.TextBox tbTacgia;
        private System.Windows.Forms.ComboBox cbx_TheLoai;
    }
}