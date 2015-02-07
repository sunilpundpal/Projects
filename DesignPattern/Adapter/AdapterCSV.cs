using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Adapter
{
    class AdapterForCSV : IAdapter
    {
        private CSVWriter _csvWriter = null;
        public AdapterForCSV()
        {
            _csvWriter = new CSVWriter();
        }
        public void Do()
        {
            _csvWriter.WriteToCSV();
        }
    }
}
