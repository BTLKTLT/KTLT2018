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
    public partial class Info : Form
    {
        String connectionString = @"Data Source=T-PC\SQLEXPRESS;Initial Catalog=QLBongda;Integrated Security=True";
        public Info()
        {
            InitializeComponent();
        }
        //thu
        //Nếu chỉ vào radio button này thì tìm thông tin cầu thủ theo MSSV 
        int check = 0;
        private void Cauthu_CheckedChanged(object sender, EventArgs e)
        {
            check = 1;

        }
        //Nếu chỉ vào radio button này thì tìm thông tin đội bóng
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            check = 2;
        }
        //Nếu chỉ vào radio button này thì tìm lịch thi đấu theo ngày, tháng, năm 
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            check = 3;
        }
        //Nếu chỉ vào radio button này thì tìm kết quả trận đấu

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            check = 4;
        }
        //Kết nối SQL và viết câu truy vấn tương ứng với từng radio button từ trong từ khóa trong ô Textbox
        //Gợi ý dùng câu lệnh IF trong mỗi phần câu lệnh đều thực hiện một câu kết nối SQL theo thông tin tương ứng
        private void button1_Click(object sender, EventArgs e)
        {
            if (check == 1)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlDataAdapter adapt = new SqlDataAdapter("select * from CAUTHU where HOTEN like '%"+textBox1.Text+"%'", con);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    dataGridView1.DataSource = dt;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    con.Close();
                }
            }
            else if (check == 2)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlDataAdapter adapt = new SqlDataAdapter("select * from CAULACBO where TENCLB like '%" + textBox1.Text + "%'", con);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    dataGridView1.DataSource = dt;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    con.Close();
                }
            }
            else if (check == 3)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlDataAdapter adapt = new SqlDataAdapter("select * from CAUTHU where HOTEN like '%" + textBox1.Text + "%'", con);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    dataGridView1.DataSource = dt;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    con.Close();
                }
            }
            else if (check == 4)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlDataAdapter adapt = new SqlDataAdapter("select * from TRANDAU where NGAYTD like '%" + textBox1.Text + "%'", con);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    dataGridView1.DataSource = dt;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    con.Close();
                }
            }
        }

      

       

        
    }
}
