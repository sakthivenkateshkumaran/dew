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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string constring = "";
        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\sakthi\\File1\\ksvk\\ksvk\\TODAY11.mdf;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from Table where NAME='" + textBox1.Text + "' and  AGE='" + textBox2.Text + "';",conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    Form3 f3 = new Form3();
                    f3.Show();
                }
                else
                {
                    Form2 f2 = new Form2();
                    f2.Show();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
