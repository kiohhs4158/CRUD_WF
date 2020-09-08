using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSourceTest
{
    class TestList
    {
        public List<Test> Data { get; }

        public TestList()
        {
            Data = new List<Test>
            {
                new Test { Subject = "国語", Score = 90, Name = "田中", ClassName = "A"},
                new Test { Subject = "数学", Score = 80, Name = "鈴木", ClassName = "B"},
                new Test { Subject = "英語", Score = 90, Name = "高橋", ClassName = "C"}
            };
        }
    }
}
