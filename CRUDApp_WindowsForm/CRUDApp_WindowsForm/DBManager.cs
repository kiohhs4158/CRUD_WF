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
        public DataSet View(string sql)
        {
            using (SqlConnection connection = new SqlConnection(cntstr))
            {
                DataSet dataset         = new DataSet();
                SqlDataAdapter adapter  = new SqlDataAdapter();
                adapter.SelectCommand   = new SqlCommand(sql, connection);
                adapter.Fill(dataset);
                return dataset;
            }
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
        public void Insert(string tbl_name, string shohin_id, string shohin_mei, string shohin_bunrui, object hanbai_tanka, object shiire_tanka)
        {
            DateTime dt = DateTime.Now;
            string torokubi = dt.ToString("yyyy-MM-dd");
            string sql = $"INSERT INTO {tbl_name} (shohin_id, shohin_mei, shohin_bunrui, hanbai_tanka, shiire_tanka, torokubi)"
                         + $"VALUES ('{shohin_id}', '{shohin_mei}', '{shohin_bunrui}', {hanbai_tanka}, {shiire_tanka}, '{torokubi}')";
            Execute(sql);
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
            Execute(sql);
        }
        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="tbl_name"></param>
        /// <param name="shohin_id"></param>
        public void Delete(string tbl_name, string shohin_id)
        {
            string sql = $"DELETE FROM {tbl_name} WHERE shohin_id = '{shohin_id}'";
            Execute(sql);
        }
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
