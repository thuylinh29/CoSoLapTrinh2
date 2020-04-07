namespace QuanLyAnhVienAoCuoi
{
    partial class frmChiTietThanhToan
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
            this.components = new System.ComponentModel.Container();
            this.lblMaThanhToan = new System.Windows.Forms.Label();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.lblNgayThue = new System.Windows.Forms.Label();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.DataGridView_ChiTietTT = new System.Windows.Forms.DataGridView();
            this.MaThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bntThanhTien = new System.Windows.Forms.Button();
            this.bntThoat = new System.Windows.Forms.Button();
            this.txtNgayThue = new System.Windows.Forms.TextBox();
            this.lblNgayTra = new System.Windows.Forms.Label();
            this.txtNgayTra = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.quanLyAnhVienAoCuoiDataSet = new QuanLyAnhVienAoCuoi.QuanLyAnhVienAoCuoiDataSet();
            this.thanhToanHDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thanhToanHDTableAdapter = new QuanLyAnhVienAoCuoi.QuanLyAnhVienAoCuoiDataSetTableAdapters.ThanhToanHDTableAdapter();
            this.txtMaThanhToan = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ChiTietTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyAnhVienAoCuoiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thanhToanHDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaThanhToan
            // 
            this.lblMaThanhToan.AutoSize = true;
            this.lblMaThanhToan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMaThanhToan.Location = new System.Drawing.Point(26, 9);
            this.lblMaThanhToan.Name = "lblMaThanhToan";
            this.lblMaThanhToan.Size = new System.Drawing.Size(78, 15);
            this.lblMaThanhToan.TabIndex = 0;
            this.lblMaThanhToan.Text = "Mã thanh toán";
            // 
            // lblMaSP
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMaSP.Location = new System.Drawing.Point(26, 49);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(73, 15);
            this.lblMaSP.TabIndex = 1;
            this.lblMaSP.Text = "Mã sản phẩm";
            // 
            // lblNgayThue
            // 
            this.lblNgayThue.AutoSize = true;
            this.lblNgayThue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNgayThue.Location = new System.Drawing.Point(398, 9);
            this.lblNgayThue.Name = "lblNgayThue";
            this.lblNgayThue.Size = new System.Drawing.Size(58, 15);
            this.lblNgayThue.TabIndex = 2;
            this.lblNgayThue.Text = "Ngày thuê";
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblThanhTien.Location = new System.Drawing.Point(398, 85);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(60, 15);
            this.lblThanhTien.TabIndex = 3;
            this.lblThanhTien.Text = "Thành tiền";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(462, 82);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(253, 20);
            this.txtThanhTien.TabIndex = 7;
            // 
            // DataGridView_ChiTietTT
            // 
            this.DataGridView_ChiTietTT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_ChiTietTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_ChiTietTT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThanhToan,
            this.MaSP,
            this.NgayThue,
            this.NgayTra,
            this.ThanhTien});
            this.DataGridView_ChiTietTT.Location = new System.Drawing.Point(26, 122);
            this.DataGridView_ChiTietTT.Name = "DataGridView_ChiTietTT";
            this.DataGridView_ChiTietTT.Size = new System.Drawing.Size(686, 150);
            this.DataGridView_ChiTietTT.TabIndex = 8;
            this.DataGridView_ChiTietTT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_ChiTietTT_CellContentClick);
            // 
            // MaThanhToan
            // 
            this.MaThanhToan.DataPropertyName = "MaThanhToan";
            this.MaThanhToan.HeaderText = "Mã thanh toán";
            this.MaThanhToan.Name = "MaThanhToan";
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã sản phẩm";
            this.MaSP.Name = "MaSP";
            // 
            // NgayThue
            // 
            this.NgayThue.DataPropertyName = "NgayThue";
            this.NgayThue.HeaderText = "Ngày thuê";
            this.NgayThue.Name = "NgayThue";
            // 
            // NgayTra
            // 
            this.NgayTra.DataPropertyName = "NgayTra";
            this.NgayTra.HeaderText = "Ngày trả";
            this.NgayTra.Name = "NgayTra";
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.Name = "ThanhTien";
            // 
            // bntThanhTien
            // 
            this.bntThanhTien.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bntThanhTien.Location = new System.Drawing.Point(26, 300);
            this.bntThanhTien.Name = "bntThanhTien";
            this.bntThanhTien.Size = new System.Drawing.Size(75, 23);
            this.bntThanhTien.TabIndex = 9;
            this.bntThanhTien.Text = "Thành tiền";
            this.bntThanhTien.UseVisualStyleBackColor = false;
            this.bntThanhTien.Click += new System.EventHandler(this.bntThanhTien_Click);
            // 
            // bntThoat
            // 
            this.bntThoat.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.bntThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bntThoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bntThoat.Location = new System.Drawing.Point(713, 314);
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(75, 23);
            this.bntThoat.TabIndex = 10;
            this.bntThoat.Text = "Thoát";
            this.bntThoat.UseVisualStyleBackColor = false;
            this.bntThoat.Click += new System.EventHandler(this.bntThoat_Click);
            // 
            // txtNgayThue
            // 
            this.txtNgayThue.Location = new System.Drawing.Point(462, 3);
            this.txtNgayThue.Name = "txtNgayThue";
            this.txtNgayThue.Size = new System.Drawing.Size(253, 20);
            this.txtNgayThue.TabIndex = 13;
            // 
            // lblNgayTra
            // 
            this.lblNgayTra.AutoSize = true;
            this.lblNgayTra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNgayTra.Location = new System.Drawing.Point(398, 47);
            this.lblNgayTra.Name = "lblNgayTra";
            this.lblNgayTra.Size = new System.Drawing.Size(49, 15);
            this.lblNgayTra.TabIndex = 14;
            this.lblNgayTra.Text = "Ngày trả";
            // 
            // txtNgayTra
            // 
            this.txtNgayTra.Location = new System.Drawing.Point(462, 44);
            this.txtNgayTra.Name = "txtNgayTra";
            this.txtNgayTra.Size = new System.Drawing.Size(253, 20);
            this.txtNgayTra.TabIndex = 15;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(108, 42);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(253, 20);
            this.txtMaSP.TabIndex = 5;
            // 
            // quanLyAnhVienAoCuoiDataSet
            // 
            this.quanLyAnhVienAoCuoiDataSet.DataSetName = "QuanLyAnhVienAoCuoiDataSet";
            this.quanLyAnhVienAoCuoiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thanhToanHDBindingSource
            // 
            this.thanhToanHDBindingSource.DataMember = "ThanhToanHD";
            this.thanhToanHDBindingSource.DataSource = this.quanLyAnhVienAoCuoiDataSet;
            // 
            // thanhToanHDTableAdapter
            // 
            this.thanhToanHDTableAdapter.ClearBeforeFill = true;
            // 
            // txtMaThanhToan
            // 
            this.txtMaThanhToan.Location = new System.Drawing.Point(108, 6);
            this.txtMaThanhToan.Name = "txtMaThanhToan";
            this.txtMaThanhToan.Size = new System.Drawing.Size(253, 20);
            this.txtMaThanhToan.TabIndex = 18;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXoa.Location = new System.Drawing.Point(313, 300);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLuu.Location = new System.Drawing.Point(120, 300);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 20;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSua.Location = new System.Drawing.Point(221, 300);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 22;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // frmChiTietThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtMaThanhToan);
            this.Controls.Add(this.txtNgayTra);
            this.Controls.Add(this.lblNgayTra);
            this.Controls.Add(this.txtNgayThue);
            this.Controls.Add(this.bntThoat);
            this.Controls.Add(this.bntThanhTien);
            this.Controls.Add(this.DataGridView_ChiTietTT);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.lblThanhTien);
            this.Controls.Add(this.lblNgayThue);
            this.Controls.Add(this.lblMaSP);
            this.Controls.Add(this.lblMaThanhToan);
            this.Name = "frmChiTietThanhToan";
            this.Text = "Chi Tiết Thanh Toán";
            this.Load += new System.EventHandler(this.frmChiTietThanhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ChiTietTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyAnhVienAoCuoiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thanhToanHDBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaThanhToan;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.Label lblNgayThue;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.DataGridView DataGridView_ChiTietTT;
        private System.Windows.Forms.Button bntThanhTien;
        private System.Windows.Forms.Button bntThoat;
        private QuanLyAnhVienAoCuoiDataSet quanLyAnhVienAoCuoiDataSet;
        private System.Windows.Forms.BindingSource thanhToanHDBindingSource;
        private QuanLyAnhVienAoCuoiDataSetTableAdapters.ThanhToanHDTableAdapter thanhToanHDTableAdapter;
        private System.Windows.Forms.TextBox txtNgayThue;
        private System.Windows.Forms.Label lblNgayTra;
        private System.Windows.Forms.TextBox txtNgayTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtMaThanhToan;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
    }
}