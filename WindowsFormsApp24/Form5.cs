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
using System.Deployment.Internal;

namespace WindowsFormsApp24
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            string make = textBox2.Text;
            string model = textBox3.Text;
            int year = int.Parse(textBox4.Text);
            string condition = textBox5.Text;

            
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\abc\Downloads\GROUP NO 13\GROUP NO 13\biyoni.mdf';Integrated Security=True;Connect Timeout=30");
            string query = "INSERT INTO VEHICLE (Id,MAKE,MODEL,YEAR,CONDITION) VALUES('"+id+"','"+make+"','"+model+"','"+year+"','"+condition+"')";
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Vehicle Inserted Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Console.ReadLine();
           
        }
    }
}
