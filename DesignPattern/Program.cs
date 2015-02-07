using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DesignPattern.Adapter;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IAdapter _adapter = null;

        Start:
            Console.WriteLine("***********************************************");
            Console.WriteLine("This is main App..");
            Console.WriteLine("***********************************************");
            Console.WriteLine("1.   Write to Excel");
            Console.WriteLine("2.   Write to CSV");
            Console.WriteLine("Make your Choice");

            int _choice = Console.Read();

            if (_choice == '1')
            {
                _adapter = new AdapterForExcel();
            }
            else if (_choice == '2')
            {
                _adapter = new AdapterForExcel();
            }
            else
            {
                Console.WriteLine("Wrong Choice, Please enter Choice again");
                //goto Start;
            }
            _adapter.Do();
            Console.ReadLine();
        }
    }
}
