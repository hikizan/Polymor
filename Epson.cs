using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterWindows
{
   public class Epson : PrinterW
    {
        public override void Speak()
        {
            Console.WriteLine("Epson printing");
        }
    }
}
