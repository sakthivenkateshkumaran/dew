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

namespace ksvk
{
    
    public partial class Form2 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\sakthi\\File1\\ksvk\\ksvk\\TODAY11.mdf;Integrated Security=True");
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            conn.Open();
            MessageBox.Show("connected");
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Table VALUES('" +textBox1.Text+ "','" +textBox2.Text+ "','" +textBox3.Text +"')";
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("record insert sucessful");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
