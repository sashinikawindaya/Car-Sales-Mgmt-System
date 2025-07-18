using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp24
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\abc\Downloads\GROUP NO 13\GROUP NO 13\biyoni.mdf';Integrated Security=True;Connect Timeout=30";
            string qry = "SELECT * FROM VEHICLE WHERE CONDITION = 'RECONDITION'";
            
            SqlDataAdapter da = new SqlDataAdapter(qry, conString);
            DataSet ds = new DataSet();

            da.Fill(ds, "VEHICLE");
            dataGridView1.DataSource = ds.Tables["VEHICLE"];
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\abc\Downloads\GROUP NO 13\GROUP NO 13\biyoni.mdf';Integrated Security=True;Connect Timeout=30";
            string qry = "SELECT * FROM VEHICLE WHERE CONDITION = 'BRAND NEW'";

            SqlDataAdapter da = new SqlDataAdapter(qry, conString);
            DataSet ds = new DataSet();

            da.Fill(ds, "VEHICLE");
            dataGridView1.DataSource = ds.Tables["VEHICLE"];
        

    }

        private void button3_Click(object sender, EventArgs e)
        {

            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\abc\Downloads\GROUP NO 13\GROUP NO 13\biyoni.mdf';Integrated Security=True;Connect Timeout=30";
            string qry = "SELECT * FROM VEHICLE";

            SqlDataAdapter da = new SqlDataAdapter(qry, conString);
            DataSet ds = new DataSet();

            da.Fill(ds, "VEHICLE");
            dataGridView1.DataSource = ds.Tables["VEHICLE"];
        
    }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
