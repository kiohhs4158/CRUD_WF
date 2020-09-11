using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDApp_WindowsForm
{
    class DBManager
    {   
        private string cntstr;
        /// <summary>
        /// configファイルから接続文字列を取得
        /// </summary>
        public DBManager()
        {
            cntstr = ConfigurationManager.ConnectionStrings["sqlsrv"].ConnectionString;
        }
        /// <summary>
        /// データセットの作成
        /// </summary>
        /// <param name="sql">クエリー</param>
        private DataSet GetDataSet(string sql)
        {
            using (SqlConnection connection = new SqlConnection(this.cntstr))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataSet dataset = new DataSet();
                        adapter.Fill(dataset);
                        return dataset;
                    }
                }
            }
        }
        /// <summary>
        /// テーブルの取得
        /// </summary>
        /// <param name="table_num">DataSet.Tables[]の添え字</param>
        /// <returns></returns>
        public DataTable View(int table_num)
        {
            string sql = "SELECT * FROM Shohin";
            DataTable view_table = this.GetDataSet(sql).Tables[table_num];
            return view_table;
        }
        /// <summary>
        /// 指定したカラムのリストを取得
        /// </summary>
        /// <param name="table_num"></param>
        /// <param name="col_name"></param>
        /// <returns></returns>
        public List<object> GetColumnList(int table_num, string col_name)
        {
            string sql = $"SELECT {col_name} FROM Shohin ORDER BY {col_name}";
            DataTable dt = this.GetDataSet(sql).Tables[table_num];
            DataRowCollection drc = dt.Rows;
            List<object> col_element_list = new List<object>();
            foreach (DataRow dr in drc)
            {
                col_element_list.Add(dr.ItemArray[0]);
            }
            return col_element_list;
        }
        /// <summary>
        /// 接続とクエリ実行
        /// </summary>
        /// <param name="sql"></param>
        private void Execute(string sql)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(cntstr))
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            using (SqlCommand command = new SqlCommand(sql, connection, transaction))
                            {
                                command.ExecuteNonQuery();
                                transaction.Commit();
                            }
                        }
                        catch (SqlException)
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }
        /// <summary>
        /// Insert
        /// </summary>
        /// <param name="tbl_name"></param>
        /// <param name="shohin_id"></param>
        /// <param name="shohin_mei"></param>
        /// <param name="shohin_bunrui"></param>
        /// <param name="hanbai_tanka"></param>
        /// <param name="shiire_tanka"></param>
        public void Insert(string tbl_name, string shohin_mei, string shohin_bunrui, object hanbai_tanka, object shiire_tanka)
        {
            List<object> shohin_ids = this.GetColumnList(0, "shohin_id");
            string shohin_id = this.AutoIncrementStringID(shohin_ids);
            DateTime dt = DateTime.Now;
            string torokubi = dt.ToString("yyyy-MM-dd");
            string sql = $"INSERT INTO {tbl_name} (shohin_id, shohin_mei, shohin_bunrui, hanbai_tanka, shiire_tanka, torokubi)"
                         + $"VALUES ('{shohin_id}', '{shohin_mei}', '{shohin_bunrui}', {hanbai_tanka}, {shiire_tanka}, '{torokubi}')";
            this.Execute(sql);
        }
        public void Insert_2d_csv(string tbl_name, object[][] csv_2d)
        {
            List<object> shohin_ids = this.GetColumnList(0, "shohin_id");
            int insert_id = this.AutoIncrementIntID(shohin_ids);
            DateTime dt = DateTime.Now;
            string torokubi = dt.ToString("yyyy-MM-dd");
            string sql = "";
            for (int i = 0; i < csv_2d.Length; i++)
            {
                int shohin_int_id = insert_id + i;
                string shohin_id = String.Format("{0:D4}", shohin_int_id);
                sql += $"INSERT INTO {tbl_name} (shohin_id, shohin_mei, shohin_bunrui, hanbai_tanka, shiire_tanka, torokubi)"
                        + $"VALUES ('{shohin_id}', '{csv_2d[i][0]}', '{csv_2d[i][1]}', {int.Parse(csv_2d[i][2].ToString())}, {int.Parse(csv_2d[i][3].ToString())}, '{torokubi}')";
            }
            this.Execute(sql);
        }
        /// <summary>
        /// 商品ID自動採番(String.Format)
        /// </summary>
        /// <param name="col_element_list"></param>
        /// <returns></returns>
        private string AutoIncrementStringID(List<object> col_element_list)
        {
            int last_id = int.Parse(col_element_list.Last().ToString());
            int insert_id = last_id + 1;
            return String.Format("{0:D4}", insert_id);
        }
        /// <summary>
        /// 商品ID自動採番(Int)
        /// </summary>
        /// <param name="col_element_list"></param>
        /// <returns></returns>
        private int AutoIncrementIntID(List<object> col_element_list)
        {
            int last_id = int.Parse(col_element_list.Last().ToString());
            return last_id + 1;
        }
        /// <summary>
        /// Update
        /// </summary>
        /// <param name="tbl_name"></param>
        /// <param name="shohin_mei"></param>
        /// <param name="shohin_bunrui"></param>
        /// <param name="hanbai_tanka"></param>
        /// <param name="shiire_tanka"></param>
        /// <param name="shohin_id"></param>
        public void Update(string tbl_name, string shohin_id, string shohin_mei, string shohin_bunrui, object hanbai_tanka, object shiire_tanka)
        {
            DateTime dt     = DateTime.Now;
            string torokubi = dt.ToString("yyyy-MM-dd");
            string sql = $"UPDATE {tbl_name} "
                         + $"SET shohin_mei = '{shohin_mei}', shohin_bunrui = '{shohin_bunrui}', hanbai_tanka = {hanbai_tanka}, shiire_tanka = {shiire_tanka}, torokubi = '{torokubi}'"
                         + $"WHERE shohin_id = '{shohin_id}'";
            this.Execute(sql);
        }
        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="tbl_name"></param>
        /// <param name="shohin_id"></param>
        public void Delete(string tbl_name, string shohin_id)
        {
            string sql = $"DELETE FROM {tbl_name} WHERE shohin_id = '{shohin_id}'";
            this.Execute(sql);
        }
        /// <summary>
        /// 空文字判定（販売単価、仕入単価）
        /// </summary>
        /// <param name="textbox"></param>
        /// <returns></returns>
        public static object CheckEmpty(string textbox)
        {
            if (string.IsNullOrEmpty(textbox))
            {
                return "NULL";
            }
            else
            {
                return int.Parse(textbox);
            }
        }
        /// <summary>
        /// Nullをチェック（販売単価、仕入単価）
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public static object CheckDBNull(object element)
        {
            if (element.GetType().Name == "DBNull")
            {
                return "NULL";
            }
            else
            {
                return int.Parse(element.ToString());
            }

        }
    }
}
