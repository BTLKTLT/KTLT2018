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

namespace BKLeauge_KTLT
{
    public partial class Results : Form
    {
        String connectionString = @"Data Source=T-PC\SQLEXPRESS;Initial Catalog=QLBongda;Integrated Security=True";
        public Results()
        {
            InitializeComponent();
        }
        //lan
        //Kết nối SQL hiển thị bảng result
        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter("select * from BANGXH", con);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                con.Close();
            }
        

        }

       
    }
}
