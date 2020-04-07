namespace QuanLyAnhVienAoCuoi
{
    partial class TimKiemSanPham
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
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblLoaiSP = new System.Windows.Forms.Label();
            this.lblNoiSX = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtTenLoaiSP = new System.Windows.Forms.TextBox();
            this.txtTenNoiSX = new System.Windows.Forms.TextBox();
            this.bntTimKiem = new System.Windows.Forms.Button();
            this.DataGridView_TKSP = new System.Windows.Forms.DataGridView();
            this.bntThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_TKSP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTenSP.Location = new System.Drawing.Point(30, 21);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(77, 15);
            this.lblTenSP.TabIndex = 0;
            this.lblTenSP.Text = "Tên sản phẩm";
            // 
            // lblLoaiSP
            // 
            this.lblLoaiSP.AutoSize = true;
            this.lblLoaiSP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLoaiSP.Location = new System.Drawing.Point(30, 72);
            this.lblLoaiSP.Name = "lblLoaiSP";
            this.lblLoaiSP.Size = new System.Drawing.Size(78, 15);
            this.lblLoaiSP.TabIndex = 1;
            this.lblLoaiSP.Text = "Loại sản phẩm";
            // 
            // lblNoiSX
            // 
            this.lblNoiSX.AutoSize = true;
            this.lblNoiSX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNoiSX.Location = new System.Drawing.Point(449, 21);
            this.lblNoiSX.Name = "lblNoiSX";
            this.lblNoiSX.Size = new System.Drawing.Size(68, 15);
            this.lblNoiSX.TabIndex = 2;
            this.lblNoiSX.Text = "Nơi sản xuất";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(130, 16);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(239, 20);
            this.txtTenSP.TabIndex = 3;
            // 
            // txtTenLoaiSP
            // 
            this.txtTenLoaiSP.Location = new System.Drawing.Point(130, 67);
            this.txtTenLoaiSP.Name = "txtTenLoaiSP";
            this.txtTenLoaiSP.Size = new System.Drawing.Size(239, 20);
            this.txtTenLoaiSP.TabIndex = 4;
            // 
            // txtTenNoiSX
            // 
            this.txtTenNoiSX.Location = new System.Drawing.Point(523, 16);
            this.txtTenNoiSX.Name = "txtTenNoiSX";
            this.txtTenNoiSX.Size = new System.Drawing.Size(239, 20);
            this.txtTenNoiSX.TabIndex = 5;
            // 
            // bntTimKiem
            // 
            this.bntTimKiem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bntTimKiem.Location = new System.Drawing.Point(687, 64);
            this.bntTimKiem.Name = "bntTimKiem";
            this.bntTimKiem.Size = new System.Drawing.Size(75, 23);
            this.bntTimKiem.TabIndex = 6;
            this.bntTimKiem.Text = "Tìm kiếm";
            this.bntTimKiem.UseVisualStyleBackColor = false;
            this.bntTimKiem.Click += new System.EventHandler(this.bntTimKiem_Click);
            // 
            // DataGridView_TKSP
            // 
            this.DataGridView_TKSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_TKSP.Location = new System.Drawing.Point(30, 137);
            this.DataGridView_TKSP.Name = "DataGridView_TKSP";
            this.DataGridView_TKSP.Size = new System.Drawing.Size(732, 150);
            this.DataGridView_TKSP.TabIndex = 7;
            // 
            // bntThoat
            // 
            this.bntThoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bntThoat.Location = new System.Drawing.Point(687, 342);
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(75, 23);
            this.bntThoat.TabIndex = 8;
            this.bntThoat.Text = "Thoát";
            this.bntThoat.UseVisualStyleBackColor = false;
            this.bntThoat.Click += new System.EventHandler(this.bntThoat_Click);
            // 
            // TimKiemSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntThoat);
            this.Controls.Add(this.DataGridView_TKSP);
            this.Controls.Add(this.bntTimKiem);
            this.Controls.Add(this.txtTenNoiSX);
            this.Controls.Add(this.txtTenLoaiSP);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.lblNoiSX);
            this.Controls.Add(this.lblLoaiSP);
            this.Controls.Add(this.lblTenSP);
            this.Name = "TimKiemSanPham";
            this.Text = "Tìm kiếm sản phẩm";
            this.Load += new System.EventHandler(this.TimKiemSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_TKSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblLoaiSP;
        private System.Windows.Forms.Label lblNoiSX;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtTenLoaiSP;
        private System.Windows.Forms.TextBox txtTenNoiSX;
        private System.Windows.Forms.Button bntTimKiem;
        private System.Windows.Forms.DataGridView DataGridView_TKSP;
        private System.Windows.Forms.Button bntThoat;
    }
}