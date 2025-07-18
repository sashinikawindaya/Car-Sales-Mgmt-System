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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text); // Assuming you want to update the vehicle with ID 1
            string newMake = textBox2.Text;
            string newModel = textBox3.Text;
            int newYear;
            string newCondition = textBox5.Text;

            if (int.TryParse(textBox4.Text, out newYear))
            {
                // Perform the database update
                using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\abc\Downloads\GROUP NO 13\GROUP NO 13\biyoni.mdf';Integrated Security=True;Connect Timeout=30"))
                {
                    connection.Open();

                    string updateQuery = "UPDATE VEHICLE SET MAKE = @Make, MODEL = @Model, YEAR = @Year, CONDITION = @Condition WHERE Id = '"+id+"'";
                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Make", newMake);
                        command.Parameters.AddWithValue("@Model", newModel);
                        command.Parameters.AddWithValue("@Year", newYear);
                        command.Parameters.AddWithValue("@Condition", newCondition);
                        command.Parameters.AddWithValue("@ID", id);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Vehicle information updated successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Update failed.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid year value.");
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
    }

