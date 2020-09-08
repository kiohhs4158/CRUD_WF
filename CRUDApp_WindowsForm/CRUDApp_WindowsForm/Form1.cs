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
    public partial class CRUDForm : Form
    {
        public CRUDForm()
        {
            InitializeComponent();
        }

        private void CRUDForm_Load(object sender, EventArgs e)
        {
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            DBManager dbm = new DBManager();
            string sql = "SELECT * FROM Shohin";
            DataSet ds = dbm.View(sql);
            this.dataGridView_Shohin.DataSource = ds.Tables[0];
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection src = dataGridView_Shohin.SelectedRows;

            DBManager dbm = new DBManager();
            string tbl_name = "Shohin";
            string selected_id = src[0].Cells[0].Value.ToString();
            dbm.Delete(tbl_name, selected_id);

            dataGridView_Shohin.Rows.Remove(src[0]);
            this.ViewBtn_Click(sender, e);
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection src = dataGridView_Shohin.SelectedRows;
            DataGridViewCellCollection elements = src[0].Cells;
            DBManager dbm = new DBManager();
            string tbl_name = "Shohin";
            string shohin_mei       = elements[1].Value.ToString();
            string shohin_bunrui    = elements[2].Value.ToString();
            int hanbai_tanka        = int.Parse(elements[3].Value.ToString());
            int shiire_tanka        = int.Parse(elements[4].Value.ToString());
            string selected_id = elements[0].Value.ToString();
            dbm.Update(tbl_name, shohin_mei, shohin_bunrui, hanbai_tanka, shiire_tanka, selected_id);
            this.ViewBtn_Click(sender, e);
        }
    }
}
