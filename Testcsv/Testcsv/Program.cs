using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testcsv
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] vs = new object[4];
            vs[0] = 0;
            vs[1] = 20;
            vs[2] = 1235;
            vs[3] = 15;
            var k = vs;
            Console.WriteLine(k.GetType());
            string filepath = @"D:\CRUD_WindowsForm\Testcsv\Testcsv\test.csv";
            try
            {
                using (StreamReader sr = new StreamReader(filepath, Encoding.GetEncoding("UTF-8")))
                {
                    while (sr.Peek() > -1)
                    {
                        String[] cols = sr.ReadLine().Split(',');
                        for (int i = 0; i < cols.Length; i++)
                        {
                            Console.Write("{0}", cols[i]);
                        }
                        Console.WriteLine();
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("ダメです");
                throw;
            }
        }
    }
}
