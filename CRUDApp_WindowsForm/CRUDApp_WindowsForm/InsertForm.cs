using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDApp_WindowsForm
{
    public partial class InsertForm : Form
    {
        public InsertForm()
        {
            InitializeComponent();
        }

        private void InsertBtn2_Click(object sender, EventArgs e)
        {
            DBManager dbm = new DBManager();
            string tbl_name = "Shohin";
            string shohin_id = this.ShohinidmaskedTextBox.Text;
            string shohin_mei = this.ShohinmeimaskedTextBox.Text;
            string shohin_bunrui = this.BunruimaskedTextBox.Text;
            object hanbai_tanka = DBManager.CheckEmpty(this.HanbaiTankamaskedTextBox.Text);
            object shiire_tanka = DBManager.CheckEmpty(this.ShiireTankamaskedTextBox.Text);
            dbm.Insert(tbl_name, shohin_id, shohin_mei, shohin_bunrui, hanbai_tanka, shiire_tanka);
            this.Close();
            this.Dispose();
        }
    }
}
