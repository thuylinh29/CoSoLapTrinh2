using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyKhachSan
{
    public partial class FrmQuanLyKS : Form
    {
        SqlConnection con = new SqlConnection();
        public FrmQuanLyKS()
        {
            InitializeComponent();
        }

        private void FrmQuanLyKS_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-NALUFR0D;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
            con.ConnectionString = connectionString;
            con.Open();

            loadDataToGridView();    
        }

        private void loadDataToGridView()
        {
            string sql = "select * from tblPhong";
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable tabletblPhong = new DataTable();
            adp.Fill(tabletblPhong);

            DataGridView_QlyPhong.DataSource = tabletblPhong;
        }

        private void DataGridView_QlyPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaphong.Text = DataGridView_QlyPhong.CurrentRow.Cells["Maphong"].Value.ToString();
            txtTenphong.Text = DataGridView_QlyPhong.CurrentRow.Cells["Tenphong"].Value.ToString();
            txtDongia.Text = DataGridView_QlyPhong.CurrentRow.Cells["Dongia"].Value.ToString();
            txtMaphong.Enabled = false;
        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            txtMaphong.Text = "";
            txtTenphong.Text = "";
            txtDongia.Text = "";
            txtMaphong.Enabled = true;
        }

        private void bntSua_Click(object sender, EventArgs e)
        {
            string sql = "Update tblPhong set Tenphong='" + txtTenphong.Text.Trim().ToString() + "', Dongia='"
                + txtDongia.Text.Trim().ToString() + "'where Maphong='" + txtMaphong.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            loadDataToGridView();
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from tblPhong where Maphong='" + txtMaphong.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            loadDataToGridView();
        }

        private void bntLuu_Click(object sender, EventArgs e)
        {
            if (txtMaphong.Text == "")
            {
                MessageBox.Show("Bạn cần nhập mã phòng!");
                txtMaphong.Focus();
                return;
            }
            if (txtTenphong.Text == "")
            {
                MessageBox.Show("Bạn cần nhập tên phòng!");
                txtTenphong.Focus();
            }
            else
            {
                string sql = "insert into tblPhong values ('" + txtMaphong.Text + "','" + txtTenphong.Text + "'";
                if (txtDongia.Text != "") sql = sql + "," + txtDongia.Text.Trim();
                sql = sql + ")";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();

                loadDataToGridView();
            }
        }

        private void bntHuy_Click(object sender, EventArgs e)
        {
            txtTenphong.Text = "";
            txtDongia.Text = "";
            bntHuy.Enabled = false;
            bntThem.Enabled = true;
            bntSua.Enabled = true;
            bntLuu.Enabled = false ;
            bntXoa.Enabled = true;
            txtMaphong.Enabled = false;
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            con.Close();
            this.Close();

        }
    }
}
