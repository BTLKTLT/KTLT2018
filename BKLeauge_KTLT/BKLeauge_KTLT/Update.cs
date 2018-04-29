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
    public partial class Update : Form
    {
        String connectionString = @"Data Source=T-PC\SQLEXPRESS;Initial Catalog=QLBongda;Integrated Security=True";
        public Update()
        {
            InitializeComponent();
        }
        //thu
        //Kết nối SQL và viết câu truy vấn thêm thông tin trong các textbox
        private void button6_Click(object sender, EventArgs e)
        {
                    
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                String sql = "insert into CAUTHU values('" + MACT.Text + "','" + HOTEN.Text + "','" + CMND.Text + "','" + MSSV.Text + "','" + CHIEUCAO.Text + "','" + CANNANG.Text + "','" + VITRI.Text + "','" + NGAYSINH.Text + "','" + DIACHI.Text + "','" + MACLB.Text + "','" + QUOCTICH.Text + "','" + SO.Text + "')";
                SqlDataAdapter adapt = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                con.Close();
            }
        

        }
    
               
        
        

        
        //Kết nối SQL và viết câu truy vấn xóa thông tin theo MSSV thông tin trong các textbox
        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                String sql = "delete from cauthu where MACT like '%"+MACT.Text+"%'or '%"+HOTEN.Text+"%'";
                SqlDataAdapter adapt = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                con.Close();
            }
        }

       

    }
}
