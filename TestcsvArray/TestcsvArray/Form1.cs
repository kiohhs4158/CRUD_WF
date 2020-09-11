using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestcsvArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filepath = @"D:\CRUD_WindowsForm\Testcsv\Testcsv\test.csv";
            string encoding_name = "UTF-8";
            string[] array = Form1.Loadcsv(filepath, encoding_name);
            this.listBox1.BeginUpdate();
            for (int i = 0; i < array.Length; i++)
            {
                this.listBox1.Items.Add(array[i]);
            }
            this.listBox1.EndUpdate();
        }

        private static string[] Loadcsv(string filepath, string encoding_name)
        {
            List<string> csv_list = new List<string>();
            using (StreamReader sr = new StreamReader(filepath, Encoding.GetEncoding(encoding_name)))
            {
                while (sr.Peek() > -1)
                {
                    csv_list.Add(sr.ReadLine());
                }
                return csv_list.ToArray();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.textBox1.Text = openFileDialog1.FileName;
            }
        }
    }
}
