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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void SetData()
        {
            DataTable table = new DataTable("Table");

            table.Columns.Add("教科");
            table.Columns.Add("点数", Type.GetType("System.Int32"));
            table.Columns.Add("氏名");
            table.Columns.Add("クラス名");

            table.Rows.Add("国語", 90, "田中", "A");
            table.Rows.Add("数学", 60, "田中", "A");
            table.Rows.Add("英語", 80, "田中", "A");
            table.Rows.Add("国語", 90, "田中", "A");
            table.Rows.Add("数学", 60, "鈴木", "B");
            table.Rows.Add("英語", 80, "高橋", "C");
            table.Rows.Add("国語", 90, "田中", "A");
            table.Rows.Add("数学", 60, "鈴木", "B");
            table.Rows.Add("英語", 80, "高橋", "C");
            table.Rows.Add("国語", 90, "田中", "A");
            table.Rows.Add("数学", 60, "鈴木", "B");
            table.Rows.Add("英語", 80, "高橋", "C");

            dataGridView1.DataSource = table;
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            SetData();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection src = dataGridView1.SelectedRows;
            for (int i = src.Count - 1; i >= 0; i--)
            {
                dataGridView1.Rows.RemoveAt(src[i].Index);
            }
        }

        private void ShowForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            Form1 form1 = new Form1();
            form1.Form1_Load(sender, e);
            form2.Show();
            string a = this.dataGridView1.Columns[0].Name;
            form2.textBox1.Text = form1.dataGridView1.Columns[0].Name;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
