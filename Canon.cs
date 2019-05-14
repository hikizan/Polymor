using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterWindows
{
    public class Canon : PrinterW
    {
        public override void Speak()
        {
            Console.WriteLine("Canon printing ...");
        }
    }
}
