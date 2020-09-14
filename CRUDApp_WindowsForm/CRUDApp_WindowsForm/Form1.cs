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
        /// <summary>
        /// 表示ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewBtn_Click(object sender, EventArgs e)
        {
            DBManager dbm = new DBManager();
            DataTable dt_shohin = dbm.View(0);
            dt_shohin.Columns["shohin_id"].ReadOnly = true;
            dt_shohin.Columns["torokubi"].ReadOnly  = true;
            dt_shohin.Columns["shohin_id"].ColumnName       = "商品ID";
            dt_shohin.Columns["shohin_mei"].ColumnName      = "商品名";
            dt_shohin.Columns["shohin_bunrui"].ColumnName   = "商品分類";
            dt_shohin.Columns["hanbai_tanka"].ColumnName    = "販売単価";
            dt_shohin.Columns["shiire_tanka"].ColumnName    = "仕入単価";
            dt_shohin.Columns["torokubi"].ColumnName        = "登録日";
            this.dataGridView_Shohin.DataSource = dt_shohin;
            this.dataGridView_Shohin.AutoResizeColumns();
        }
        /// <summary>
        /// 追加ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InsertBtn_Click(object sender, EventArgs e)
        {
            InsertForm iform = new InsertForm();
            iform.ShowDialog();
            this.ViewBtn_Click(sender, e);
        }
        /// <summary>
        /// 編集ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection src = dataGridView_Shohin.SelectedRows;
            if (src.Count > 0)
            {
                DBManager dbm = new DBManager();
                string tbl_name = "Shohin";
                for (int i = src.Count - 1; i >= 0; i--)
                {
                    DataGridViewCellCollection elements = src[i].Cells;
                    string selected_id      = elements[0].Value.ToString();
                    string shohin_mei       = elements[1].Value.ToString();
                    string shohin_bunrui    = elements[2].Value.ToString();
                    object hanbai_tanka     = DBManager.CheckDBNull(elements[3].Value);
                    object shiire_tanka     = DBManager.CheckDBNull(elements[4].Value);
                    dbm.Update(tbl_name, selected_id, shohin_mei, shohin_bunrui, hanbai_tanka, shiire_tanka);
                }
                this.ViewBtn_Click(sender, e);
            }
        }
        /// <summary>
        /// 削除ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection src = dataGridView_Shohin.SelectedRows;
            if (src.Count > 0)
            {
                DBManager dbm = new DBManager();
                string tbl_name = "Shohin";
                for (int i = src.Count - 1; i >= 0; i--)
                {
                    DataGridViewCellCollection elements = src[i].Cells;
                    string selected_id = elements[0].Value.ToString();
                    dbm.Delete(tbl_name, selected_id);
                    dataGridView_Shohin.Rows.Remove(src[i]);
                }
                this.ViewBtn_Click(sender, e);
            }
        }
        /// <summary>
        /// csv(1)ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void csvBtn1_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.opencsvFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                DBManager dbm = new DBManager();
                string tbl_name = "Shohin";
                string filepath = this.opencsvFileDialog.FileName;
                string encoding_name = "UTF-8";
                string[][] csv_2d_array = CSVManager.Loadcsv_2D(filepath, encoding_name);
                dbm.Insert_csv(tbl_name, csv_2d_array);
                this.ViewBtn_Click(sender, e);
            }
        }
        /// <summary>
        /// csv(2)ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void csvBtn2_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.opencsvFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                DBManager dbm = new DBManager();
                string tbl_name = "Shohin";
                string filepath = this.opencsvFileDialog.FileName;
                int first_row = 2;
                dbm.BulkInsert(tbl_name, filepath, first_row);
                this.ViewBtn_Click(sender, e);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
