using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Adapter
{
    class AdapterForExcel : IAdapter
    {
        private ExcelWriter _excelWriter = null;
        public AdapterForExcel()
        {
            _excelWriter = new ExcelWriter();
        }
        public void Do()
        {
            _excelWriter.WriteToExcel();
            //throw new NotImplementedException();
        }
    }
}
