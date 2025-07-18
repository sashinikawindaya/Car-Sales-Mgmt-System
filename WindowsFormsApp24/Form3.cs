using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp24
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 obj = new Form5();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 obj = new Form6();   
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 obj = new Form8();
            obj.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 obj = new Form7();
            obj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 obj = new Form4();
            obj.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
