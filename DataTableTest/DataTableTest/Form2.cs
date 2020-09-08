using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataTableTest
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Form1_Load(sender, e);
            var a = form1.dataGridView1;
            this.textBox1.Text = form1.dataGridView1.Columns[0].Name;
            this.Close();
            this.Dispose();
        }
    }
}
