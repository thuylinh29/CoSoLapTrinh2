namespace QuanLyKhachSan
{
    partial class FrmQuanLyKS
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
            this.lblMaphong = new System.Windows.Forms.Label();
            this.lblTenphong = new System.Windows.Forms.Label();
            this.lblDongia = new System.Windows.Forms.Label();
            this.txtMaphong = new System.Windows.Forms.TextBox();
            this.txtTenphong = new System.Windows.Forms.TextBox();
            this.txtDongia = new System.Windows.Forms.TextBox();
            this.bntThem = new System.Windows.Forms.Button();
            this.bntSua = new System.Windows.Forms.Button();
            this.bntXoa = new System.Windows.Forms.Button();
            this.bntLuu = new System.Windows.Forms.Button();
            this.bntHuy = new System.Windows.Forms.Button();
            this.bntThoat = new System.Windows.Forms.Button();
            this.DataGridView_QlyPhong = new System.Windows.Forms.DataGridView();
            this.Maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_QlyPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaphong
            // 
            this.lblMaphong.AutoSize = true;
            this.lblMaphong.Location = new System.Drawing.Point(32, 19);
            this.lblMaphong.Name = "lblMaphong";
            this.lblMaphong.Size = new System.Drawing.Size(55, 13);
            this.lblMaphong.TabIndex = 0;
            this.lblMaphong.Text = "Mã phòng";
            // 
            // lblTenphong
            // 
            this.lblTenphong.AutoSize = true;
            this.lblTenphong.Location = new System.Drawing.Point(378, 19);
            this.lblTenphong.Name = "lblTenphong";
            this.lblTenphong.Size = new System.Drawing.Size(59, 13);
            this.lblTenphong.TabIndex = 1;
            this.lblTenphong.Text = "Tên phòng";
            // 
            // lblDongia
            // 
            this.lblDongia.AutoSize = true;
            this.lblDongia.Location = new System.Drawing.Point(32, 70);
            this.lblDongia.Name = "lblDongia";
            this.lblDongia.Size = new System.Drawing.Size(44, 13);
            this.lblDongia.TabIndex = 2;
            this.lblDongia.Text = "Đơn giá";
            // 
            // txtMaphong
            // 
            this.txtMaphong.Location = new System.Drawing.Point(93, 12);
            this.txtMaphong.Name = "txtMaphong";
            this.txtMaphong.Size = new System.Drawing.Size(262, 20);
            this.txtMaphong.TabIndex = 3;
            // 
            // txtTenphong
            // 
            this.txtTenphong.Location = new System.Drawing.Point(443, 12);
            this.txtTenphong.Name = "txtTenphong";
            this.txtTenphong.Size = new System.Drawing.Size(262, 20);
            this.txtTenphong.TabIndex = 4;
            // 
            // txtDongia
            // 
            this.txtDongia.Location = new System.Drawing.Point(93, 63);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(262, 20);
            this.txtDongia.TabIndex = 5;
            // 
            // bntThem
            // 
            this.bntThem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bntThem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntThem.Location = new System.Drawing.Point(12, 323);
            this.bntThem.Name = "bntThem";
            this.bntThem.Size = new System.Drawing.Size(75, 23);
            this.bntThem.TabIndex = 6;
            this.bntThem.Text = "Thêm";
            this.bntThem.UseVisualStyleBackColor = false;
            this.bntThem.Click += new System.EventHandler(this.bntThem_Click);
            // 
            // bntSua
            // 
            this.bntSua.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bntSua.Location = new System.Drawing.Point(149, 323);
            this.bntSua.Name = "bntSua";
            this.bntSua.Size = new System.Drawing.Size(75, 23);
            this.bntSua.TabIndex = 7;
            this.bntSua.Text = "Sửa";
            this.bntSua.UseVisualStyleBackColor = false;
            this.bntSua.Click += new System.EventHandler(this.bntSua_Click);
            // 
            // bntXoa
            // 
            this.bntXoa.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bntXoa.Location = new System.Drawing.Point(298, 323);
            this.bntXoa.Name = "bntXoa";
            this.bntXoa.Size = new System.Drawing.Size(75, 23);
            this.bntXoa.TabIndex = 8;
            this.bntXoa.Text = "Xóa";
            this.bntXoa.UseVisualStyleBackColor = false;
            this.bntXoa.Click += new System.EventHandler(this.bntXoa_Click);
            // 
            // bntLuu
            // 
            this.bntLuu.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bntLuu.Location = new System.Drawing.Point(443, 323);
            this.bntLuu.Name = "bntLuu";
            this.bntLuu.Size = new System.Drawing.Size(75, 23);
            this.bntLuu.TabIndex = 9;
            this.bntLuu.Text = "Lưu";
            this.bntLuu.UseVisualStyleBackColor = false;
            this.bntLuu.Click += new System.EventHandler(this.bntLuu_Click);
            // 
            // bntHuy
            // 
            this.bntHuy.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bntHuy.Location = new System.Drawing.Point(583, 323);
            this.bntHuy.Name = "bntHuy";
            this.bntHuy.Size = new System.Drawing.Size(75, 23);
            this.bntHuy.TabIndex = 10;
            this.bntHuy.Text = "Hủy";
            this.bntHuy.UseVisualStyleBackColor = false;
            this.bntHuy.Click += new System.EventHandler(this.bntHuy_Click);
            // 
            // bntThoat
            // 
            this.bntThoat.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bntThoat.Location = new System.Drawing.Point(713, 323);
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(75, 23);
            this.bntThoat.TabIndex = 11;
            this.bntThoat.Text = "Thoát";
            this.bntThoat.UseVisualStyleBackColor = false;
            this.bntThoat.Click += new System.EventHandler(this.bntThoat_Click);
            // 
            // DataGridView_QlyPhong
            // 
            this.DataGridView_QlyPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_QlyPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_QlyPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Maphong,
            this.Tenphong,
            this.Dongia});
            this.DataGridView_QlyPhong.Location = new System.Drawing.Point(1, 115);
            this.DataGridView_QlyPhong.Name = "DataGridView_QlyPhong";
            this.DataGridView_QlyPhong.Size = new System.Drawing.Size(799, 172);
            this.DataGridView_QlyPhong.TabIndex = 12;
            this.DataGridView_QlyPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_QlyPhong_CellContentClick);
            // 
            // Maphong
            // 
            this.Maphong.DataPropertyName = "Maphong";
            this.Maphong.HeaderText = "Mã Phòng";
            this.Maphong.Name = "Maphong";
            // 
            // Tenphong
            // 
            this.Tenphong.DataPropertyName = "Tenphong";
            this.Tenphong.HeaderText = "Tên Phòng";
            this.Tenphong.Name = "Tenphong";
            // 
            // Dongia
            // 
            this.Dongia.DataPropertyName = "Dongia";
            this.Dongia.HeaderText = "Đơn Giá";
            this.Dongia.Name = "Dongia";
            // 
            // FrmQuanLyKS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataGridView_QlyPhong);
            this.Controls.Add(this.bntThoat);
            this.Controls.Add(this.bntHuy);
            this.Controls.Add(this.bntLuu);
            this.Controls.Add(this.bntXoa);
            this.Controls.Add(this.bntSua);
            this.Controls.Add(this.bntThem);
            this.Controls.Add(this.txtDongia);
            this.Controls.Add(this.txtTenphong);
            this.Controls.Add(this.txtMaphong);
            this.Controls.Add(this.lblDongia);
            this.Controls.Add(this.lblTenphong);
            this.Controls.Add(this.lblMaphong);
            this.Name = "FrmQuanLyKS";
            this.Text = "Quản lý khách sạn nhà nghỉ";
            this.Load += new System.EventHandler(this.FrmQuanLyKS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_QlyPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaphong;
        private System.Windows.Forms.Label lblTenphong;
        private System.Windows.Forms.Label lblDongia;
        private System.Windows.Forms.TextBox txtMaphong;
        private System.Windows.Forms.TextBox txtTenphong;
        private System.Windows.Forms.TextBox txtDongia;
        private System.Windows.Forms.Button bntThem;
        private System.Windows.Forms.Button bntSua;
        private System.Windows.Forms.Button bntXoa;
        private System.Windows.Forms.Button bntLuu;
        private System.Windows.Forms.Button bntHuy;
        private System.Windows.Forms.Button bntThoat;
        private System.Windows.Forms.DataGridView DataGridView_QlyPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dongia;
    }
}

