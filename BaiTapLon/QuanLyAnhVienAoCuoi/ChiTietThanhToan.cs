using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QuanLyAnhVienAoCuoi
{
    public partial class frmChiTietThanhToan : Form
    {
        DataTable tblCTTT;
        
        public frmChiTietThanhToan()
        {
            InitializeComponent();
        }

        private void frmChiTietThanhToan_Load(object sender, EventArgs e)
        {
            
            loadDataToGridView();
            
           
        }

        private void loadDataToGridView()
        {

            string sql = "select ChiTietThanhToan.MaThanhToan, ChiTietThanhToan.MaSP,ChiTietThanhToan.NgayTra,ChiTietThanhToan.ThanhTien, ChiTietHDong.NgayThue from ChiTietThanhToan " +
                "inner join ChiTietHDong on ChiTietThanhToan.MaSP=ChiTietHDong.MaSP";
            Functions.connect();
             tblCTTT=Functions.GetDataToTable(sql);
            DataGridView_ChiTietTT.DataSource = tblCTTT;
           
        }

        private void DataGridView_ChiTietTT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtMaSP.Text = DataGridView_ChiTietTT.CurrentRow.Cells["MaSP"].Value.ToString();
            txtMaThanhToan.Text = DataGridView_ChiTietTT.CurrentRow.Cells["MaThanhToan"].Value.ToString();
            txtNgayThue.Text = DataGridView_ChiTietTT.CurrentRow.Cells["NgayThue"].Value.ToString();
            txtNgayTra.Text = DataGridView_ChiTietTT.CurrentRow.Cells["NgayTra"].Value.ToString();
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntThanhTien_Click(object sender, EventArgs e)
        { 
            DateTime ngaytra = Convert.ToDateTime(txtNgayTra.Text);
            DateTime ngaythue = Convert.ToDateTime(txtNgayThue.Text);
            TimeSpan time = ngaytra - ngaythue;
            int Tongsongay = time.Days ;
            double tt, dgt;
            dgt = Convert.ToDouble(Functions.GetFieldValues("select DonGiaThue from SanPham where MaSP='"+txtMaSP.Text+"'"));
            tt = dgt * Tongsongay;
            txtThanhTien.Text = tt.ToString();
            
        }

        

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from ChiTietThanhToan where MaThanhToan='" + txtMaThanhToan.Text + "'and MaSP='"+txtMaSP.Text+"'";
            Functions.Runsql(sql);
            loadDataToGridView();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "update ChiTietThanhToan set ThanhTien='" + txtThanhTien.Text + "' where MaSP='" + txtMaSP.Text + "' " +
                "and MaThanhToan='" + txtMaThanhToan.Text + "'";
            Functions.Runsql(sql);
            loadDataToGridView();
        }
    }
}

