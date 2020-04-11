using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace QuanLyAnhVienAoCuoi
{
    public partial class SanPham : Form
    {
        DataTable tblSP;
        public SanPham()
        {
            InitializeComponent();
        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            loadDataToGridView();
        }

        private void loadDataToGridView()
        {
            string sql = "select MaSP, TenSP, SoLuong, MaMau, MaNoiSX, MaLoaiSP, DonGiaNhap, DonGiaThue from SanPham";
            Functions.connect();
            tblSP = Functions.GetDataToTable(sql);
            DataGridView_SP.DataSource = tblSP;
        }

        private void DataGridView_SP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSP.Text = DataGridView_SP.CurrentRow.Cells["MaSP"].Value.ToString();
            txtTenSP.Text = DataGridView_SP.CurrentRow.Cells["TenSP"].Value.ToString();
            txtSoLuong.Text = DataGridView_SP.CurrentRow.Cells["SoLuong"].Value.ToString();
            txtMaMau.Text = DataGridView_SP.CurrentRow.Cells["MaMau"].Value.ToString();
            txtMaNoiSX.Text = DataGridView_SP.CurrentRow.Cells["MaNoiSX"].Value.ToString();
            txtMaLoaiSP.Text = DataGridView_SP.CurrentRow.Cells["MaLoaiSP"].Value.ToString();
            txtDonGiaNhap.Text = DataGridView_SP.CurrentRow.Cells["DonGiaNhap"].Value.ToString();
            txtDonGiaThue.Text = DataGridView_SP.CurrentRow.Cells["DonGiaThue"].Value.ToString();
        }

        private void btnMo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|gif(*.gif)|*.gif|all files(*.*)|*.*";
            dlgOpen.InitialDirectory = "D:\\";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn hình ảnh";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(dlgOpen.FileName);
                txtAnh.Text = dlgOpen.FileName;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "insert into SanPham values ('" + txtMaSP.Text.Trim() + "','" + txtTenSP.Text.Trim() + "','" + txtAnh.Text +
                "','" + txtMaMau.Text.Trim() + "','" + txtMaNoiSX.Text.Trim() + "','" + txtSoLuong.Text.Trim() + "','" + txtDonGiaNhap.Text + "','" +
                txtDonGiaThue.Text + "','" + txtMaLoaiSP.Text.Trim() + "')";

            Functions.Runsql(sql);
            loadDataToGridView();
                
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "update SanPham set TenSP='" + txtTenSP.Text.Trim().ToString() +
                "',AnhMinhHoa='" + txtAnh.Text + "',MaMau='" + txtMaMau.Text + "',MaNoiSX='" + txtMaNoiSX.Text + "',SoLuong='" + txtSoLuong.Text +
                "',DonGiaNhap='" + txtDonGiaNhap.Text + "',DonGiaThue='" + txtDonGiaThue.Text + "',MaLoaiSP='" + txtMaLoaiSP.Text+ "'where MaSP='"+txtMaSP.Text + "'";
            Functions.Runsql(sql);
            loadDataToGridView();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from SanPham where MaSP='" + txtMaSP.Text + "'";
            Functions.Runsql(sql);
            loadDataToGridView();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnTimKiemSanPham_Click(object sender, EventArgs e)
        {
            TimKiemSanPham open = new TimKiemSanPham();
            open.ShowDialog();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnTimKiemSanPham.Enabled = false;
            resetvalue();
        }


        private void resetvalue()
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtSoLuong.Text = "";
            txtMaMau.Text = "";
            txtMaNoiSX.Text = "";
            txtDonGiaNhap.Text = "";
            txtDonGiaThue.Text = "";
            txtMaLoaiSP.Text = "";

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnTimKiemSanPham.Enabled = true;
        }

        private void txtDonGiaNhap_TextChanged(object sender, EventArgs e)
        {
            double dgn, dgt;
            if (txtDonGiaNhap.Text == "") dgn = 0;
            else dgn = Convert.ToDouble(txtDonGiaNhap.Text);
            dgt = dgn * 0.5;
            txtDonGiaThue.Text = dgt.ToString();
            loadDataToGridView();
        }
    }
}
