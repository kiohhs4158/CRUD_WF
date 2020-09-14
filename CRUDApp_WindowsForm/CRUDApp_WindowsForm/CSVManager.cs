using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;

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
        public static string[][] Loadcsv_2D(string filepath, string encoding_name)
        {
            List<string[]> csv_list = new List<string[]>();
            using (StreamReader sr = new StreamReader(filepath, Encoding.GetEncoding(encoding_name)))
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
    }
}
