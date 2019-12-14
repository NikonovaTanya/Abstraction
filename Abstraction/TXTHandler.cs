using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    class TXTHandler : AbstractHandler
    {
        public TXTHandler()
        {
            Console.WriteLine("Сlass TXTLHandler");
        }
        public override void open()
        {
            Console.WriteLine("Open TXTHandler ");
        }
        public override void create()
        {
            Console.WriteLine("Create TXTHandler ");
        }
        public override void change()
        {
            Console.WriteLine("Change TXTHandler ");
        }

        public override void save()
        {
            Console.WriteLine("Save TXTHandler ");
        }
    }
}
