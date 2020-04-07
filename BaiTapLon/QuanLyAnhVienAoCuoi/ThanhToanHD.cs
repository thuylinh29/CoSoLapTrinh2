using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyAnhVienAoCuoi
{
    public partial class ThanhToanHD : Form
    {
        DataTable tblTTHD;
        public ThanhToanHD()
        {
            InitializeComponent();
        }

        private void ThanhToanHD_Load(object sender, EventArgs e)
        {
            loadDataToGridView();
        }

        private void loadDataToGridView()
        {
            string sql = "select * from ThanhToanHD";
            Functions.connect();
            tblTTHD = Functions.GetDataToTable(sql);
            DataGridView_ThanhToanHD.DataSource = tblTTHD;
        }

        private void DataGridView_ThanhToanHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaThanhToan.Text = DataGridView_ThanhToanHD.CurrentRow.Cells["MaThanhToan"].Value.ToString();
            txtMaHD.Text = DataGridView_ThanhToanHD.CurrentRow.Cells["MaHD"].Value.ToString();
            txtMaNV.Text = DataGridView_ThanhToanHD.CurrentRow.Cells["MaNV"].Value.ToString();
            txtNgayThanhToan.Text = DataGridView_ThanhToanHD.CurrentRow.Cells["NgayThanhToan"].Value.ToString();
            txtTongTien.Text = DataGridView_ThanhToanHD.CurrentRow.Cells["TongTien"].Value.ToString();
        }

        private void resetvalue()
        {
            txtMaThanhToan.Text = "";
            txtMaHD.Text = "";
            txtMaNV.Text = "";
            txtNgayThanhToan.Text = "";
            txtTongTien.Text = "";
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double tt, tu,tien;
            tt = Convert.ToDouble(Functions.GetFieldValues("select TongTien from ThanhToanHD where MaThanhToan='" + txtMaThanhToan.Text+"'"));
            tu= Convert.ToDouble(Functions.GetFieldValues("select TamUng from HopDong where MaHD='" + txtMaHD.Text+"'"));
            tien = tt - tu;
            txtSoTienThanhToan.Text = tien.ToString();
            string sql = "update ThanhToanHD set SoTienThanhToan='" + txtSoTienThanhToan.Text + "'where MaThanhToan='" + txtMaThanhToan.Text + "'";
            Functions.Runsql(sql);
            loadDataToGridView();
            resetvalue();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from ThanhToanHD where MaThanhToan='" + txtMaThanhToan.Text + "'";
            Functions.Runsql(sql);
            loadDataToGridView();
        }

        private void btnChiTietThanhToan_Click(object sender, EventArgs e)
        {
            frmChiTietThanhToan open = new frmChiTietThanhToan();
            open.ShowDialog();
            open.ShowDialog();
            open.ShowDialog();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaThanhToan.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaThanhToan.Focus();
            }
            string sql = "insert into ThanhToanHD(MaThanhToan, MaHD, MaNV, NgayThanhToan, TongTien) values" +
                "('" + txtMaThanhToan.Text.Trim() + "','" + txtMaHD.Text.Trim() + "','" + txtMaNV.Text.Trim() + "','" + txtNgayThanhToan.Text.Trim() +
                "','" + txtTongTien.Text.Trim() + "')";
            Functions.Runsql(sql);
            loadDataToGridView();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnChiTietThanhToan.Enabled = false;
            btnSua.Enabled = false;
            resetvalue();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "update ThanhToanHD set MaHD='" + txtMaHD.Text.Trim().ToString() + "',MaNV='" + txtMaNV.Text.Trim().ToString() +
                "',NgayThanhToan='" + txtNgayThanhToan.Text + "',TongTien='" + txtTongTien.Text.Trim().ToString() + "'where MaThanhToan='" +
                txtMaThanhToan.Text + "'";
            Functions.Runsql(sql);
            loadDataToGridView();
            resetvalue();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            resetvalue();
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnChiTietThanhToan.Enabled = true;
            btnSua.Enabled = true;

        }
    }
}
