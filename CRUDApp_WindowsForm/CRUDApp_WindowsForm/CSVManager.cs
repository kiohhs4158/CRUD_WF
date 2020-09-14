using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Globalization;

namespace CRUDApp_WindowsForm
{
    class CSVManager
    {
        /// <summary>
        /// csvファイルから２次元配列を取得（２行目から）
        /// </summary>
        /// <param name="filepath"></param>
        /// <param name="encoding_name"></param>
        /// <returns></returns>
        public static string[][] Loadcsv_2D(string filepath, string encoding_info)
        {
            List<string[]> csv_list = new List<string[]>();
            using (StreamReader sr = new StreamReader(filepath, Encoding.GetEncoding(encoding_info)))
            {
                int line = 0;
                while (sr.Peek() > -1)
                {
                    if (line > 0)
                    {
                        csv_list.Add(sr.ReadLine().Split(','));
                    }
                    sr.ReadLine();
                    line++;
                }
                return csv_list.ToArray();
            }
        }
        /// <summary>
        /// CsvHelperを用いて、Listを取得
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <typeparam name="TMapper"></typeparam>
        /// <param name="filepath"></param>
        /// <param name="encoding_info"></param>
        /// <returns></returns>
        public static List<TModel> GetRecords<TModel, TMapper>(string filepath, string encoding_info) where TMapper : CsvHelper.Configuration.ClassMap
        {
            using (StreamReader sr = new StreamReader(filepath, Encoding.GetEncoding(encoding_info)))
            using (CsvReader cr = new CsvReader(sr, new CultureInfo("ja-JP", false)))
            {
                cr.Configuration.RegisterClassMap<TMapper>();

                return cr.GetRecords<TModel>().ToList();
            }
        }
        /// <summary>
        /// Shohinデータ格納用クラス
        /// </summary>
        public class Shohin
        {
            public string Name { get; set; }
            public string Group { get; set; }
            public Nullable<int> Price { get; set; }
            public Nullable<int> Cost { get; set; }
            public Nullable<DateTime> Date { get; set; }

        }
        /// <summary>
        /// 
        /// </summary>
        public class ShohinMapper : CsvHelper.Configuration.ClassMap<Shohin>
        {
            /// <summary>
            /// Shohinマッピング用クラス
            /// </summary>
            private ShohinMapper()
            {
                Map(x => x.Name).Name("商品名");
                Map(x => x.Group).Name("商品分類");
                Map(x => x.Price).Name("販売単価");
                Map(x => x.Cost).Name("仕入単価");
                Map(x => x.Date).Name("登録日");
                //csv入力フォーマットによってはTypeConverterOption.Format("yyyy-MM-dd")が必要
            }
        }
    }
}
