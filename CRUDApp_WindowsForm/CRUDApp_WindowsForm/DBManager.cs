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
        /// データの表示
        /// </summary>
        /// <param name="sql">クエリー</param>
        public DataSet View(string sql)
        {
            using (SqlConnection connection = new SqlConnection(cntstr))
            {
                DataSet dataset = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(sql, connection);
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
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
        }

        public void Delete(string tbl_name, string shohin_id)
        {
            string sql = $"DELETE FROM {tbl_name} WHERE shohin_id = '{shohin_id}'";
            Execute(sql);
        }

        public void Update(string tbl_name, string shohin_mei, string shohin_bunrui, int hanbai_tanka, int shiire_tanka, string shohin_id)
        {
            DateTime dt = DateTime.Now;
            string torokubi = dt.ToString("yyyy-MM-dd");
            string sql = $"UPDATE {tbl_name} " +
                         $"SET shohin_mei = '{shohin_mei}', shohin_bunrui = '{shohin_bunrui}', hanbai_tanka = {hanbai_tanka}, shiire_tanka = {shiire_tanka}, torokubi = '{torokubi}'" +
                         $"WHERE shohin_id = '{shohin_id}'";
            Execute(sql);
        }
    }
}
