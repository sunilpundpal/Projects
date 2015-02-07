using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Adapter
{
    class CSVWriter
    {
        public void WriteToCSV()
        {
            Console.WriteLine("This is written by ExcelWriter");
        }
    }
}
