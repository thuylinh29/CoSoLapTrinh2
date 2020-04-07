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
    public partial class TimKiemSanPham : Form
    {
        DataTable tblTKSP;
        public TimKiemSanPham()
        {
            InitializeComponent();
        }

        private void TimKiemSanPham_Load(object sender, EventArgs e)
        {
            DataGridView_TKSP.DataSource = null;
        }

        private void bntTimKiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtTenSP.Text=="") && (txtTenLoaiSP.Text=="") && (txtTenNoiSX.Text==""))
            {
                MessageBox.Show("Hãy nhập thông tin tìm kiếm!","Yeu cau...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "select a.MaSP, a.TenSP, a.MaMau, a.MaNoiSX, a.SoLuong, a.DonGiaNhap, a.DonGiaThue, a.MaLoaiSP  from SanPham as a, LoaiSP as b, NoiSanXuat as c " +
                "where a.MaLoaiSP=b.MaLoaiSP AND a.MaNoiSX=c.MaNoiSX ";

            if (txtTenSP.Text != "")
            {
                sql = sql + "AND TenSP Like N'%" + txtTenSP.Text + "%'";
            }
                    
            if (txtTenLoaiSP.Text != "")
            {
                sql = sql + "AND TenLoaiSP Like N'%" + txtTenLoaiSP.Text + "%'";
            }
                    
            if (txtTenNoiSX.Text != "")
            {
                sql = sql + "AND TenNoiSX Like N'%" + txtTenNoiSX.Text + "%'";
            }
                    
            tblTKSP = Functions.GetDataToTable(sql);

            if (tblTKSP.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Có" + tblTKSP.Rows.Count + "bản ghi thỏa mãn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                
            DataGridView_TKSP.DataSource = tblTKSP;
            loadDataToGridView();

        }

        private void loadDataToGridView()
        {
            DataGridView_TKSP.Columns[0].HeaderText = "Mã sản phẩm";
            DataGridView_TKSP.Columns[1].HeaderText = "Tên sản phẩm";
            DataGridView_TKSP.Columns[2].HeaderText = "Mã màu";
            DataGridView_TKSP.Columns[3].HeaderText = "Mã nơi sản xuất";
            DataGridView_TKSP.Columns[4].HeaderText = "Số lượng";
            DataGridView_TKSP.Columns[5].HeaderText="Đơn giá nhập";
            DataGridView_TKSP.Columns[6].HeaderText = "Đơn giá thuê";
            DataGridView_TKSP.Columns[7].HeaderText = "Mã loại sản phẩm";
            DataGridView_TKSP.Columns[0].Width = 80;
            DataGridView_TKSP.Columns[1].Width = 100;
            DataGridView_TKSP.Columns[2].Width = 80;
            DataGridView_TKSP.Columns[3].Width = 80;
            DataGridView_TKSP.Columns[4].Width = 80;
            DataGridView_TKSP.Columns[5].Width = 100;
            DataGridView_TKSP.Columns[6].Width = 100;
            DataGridView_TKSP.Columns[7].Width = 80;
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
