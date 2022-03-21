using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_03._21._2022
{
    class MainPrintFile<T> : IPrintable
    {
        public MainPrintFile(T print)
        {
            Console.WriteLine($"{print} cap edildi");
        }
        public void Print()
        {

        }
    }
}
