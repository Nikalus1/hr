using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 сецондForm = new Form2();
            сецондForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 fourthform = new Form4();
            fourthform.Show();
        }
    }
}
