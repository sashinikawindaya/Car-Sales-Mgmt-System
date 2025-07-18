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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp24
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            


            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\abc\Downloads\GROUP NO 13\GROUP NO 13\biyoni.mdf';Integrated Security=True;Connect Timeout=30");
            string query = "DELETE FROM VEHICLE WHERE Id='"+id+"'";
            SqlCommand cmd = new SqlCommand(query, con);

          
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Vehicle Deleted Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Console.ReadLine();

        
    }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
