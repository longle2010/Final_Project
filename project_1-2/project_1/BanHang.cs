using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_1
{
    public partial class BanHang : Form
    {
        public BanHang()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        private void BanHang_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["project_1"].ConnectionString.ToString();
            conn = new SqlConnection(conString);
            conn.Open();
        }
        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
     
    }
}
