using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterWindows
{
    public class PrinterW
    {
        public string Name { get; set; }

        public virtual void Print()
        {
            Console.Write.Line("printing .... ");
        }

        public virtual void Show()
        {
            Console.Write.Line(" .... ");
        }

    }
}
