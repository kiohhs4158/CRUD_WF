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
            List<object> shohin_ids = InsertForm.GetColumnList("shohin_id");
            string s = AutoShohinID(shohin_ids);
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

        private static List<object> GetColumnList(string col_name)
        {
            DBManager dbm = new DBManager();
            string sql = $"SELECT {col_name} FROM Shohin ORDER BY {col_name}";
            DataSet ds = dbm.View(sql);
            DataTable dt = ds.Tables[0];
            DataRowCollection drc = dt.Rows;
            List<object> col_element_list = new List<object>();
            foreach (DataRow dr in drc)
            {
                col_element_list.Add(dr.ItemArray[0]);
            }
            return col_element_list;
        }

        private static string AutoShohinID(List<object> col_element_list)
        {
            int last_id = int.Parse(col_element_list.Last().ToString());
            int insert_id = last_id + 1;
            return String.Format("{0:D4}", insert_id);
        }
    }
}
