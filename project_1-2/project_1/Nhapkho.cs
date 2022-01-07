using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace project_1
{
    public partial class Nhapkho : Form
    {
        public Nhapkho()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        private void Nhapkho_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["project_1"].ConnectionString.ToString();
            conn = new SqlConnection(conString);
            conn.Open();
        }
        private void add_Click(object sender, EventArgs e)
        {
            string sqlinsert = "Insert into kho values (@MaHang,@TenHang,@GiaTien,@SoLuong)";
            SqlCommand cmd = new SqlCommand(sqlinsert, conn);
            cmd.Parameters.AddWithValue("MaHang",mah1.Text);
            cmd.Parameters.AddWithValue("TenHang", ten1.Text);
            cmd.Parameters.AddWithValue("GiaTien", gia1.Text);
            cmd.Parameters.AddWithValue("SoLuong", sl1.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Thêm thành công", "Thêm không thành công", MessageBoxButtons.OK);
            clear();

        }
        public void clear()
        {
            mah1.Text = "";
            mah2.Text = "";
            mah3.Text = "";
            mah4.Text = "";
            mah5.Text = "";

            ten1.Text = "";
            ten2.Text = "";
            ten3.Text = "";
            ten4.Text = "";
            ten5.Text = "";

            gia1.Text = "";
            gia2.Text = "";
            gia3.Text = "";
            gia4.Text = "";
            gia5.Text = "";

            sl1.Text = "";
            sl2.Text = "";
            sl3.Text = "";
            sl4.Text = "";
            sl5.Text = "";

        }
        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 F = new Form1();
            F.ShowDialog();
            this.Close();
        }


    }
}
