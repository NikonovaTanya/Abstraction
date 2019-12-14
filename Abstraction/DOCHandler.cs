using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    class DOCHandler : AbstractHandler
    {
        public DOCHandler()
        {
            Console.WriteLine("Сlass DOCHandler");
        }
        public override void open()
        {
            Console.WriteLine("Open DOCHandler ");
        }
        public override void create()
        {
            Console.WriteLine("Create DOCHandler ");
        }
        public override void change()
        {
            Console.WriteLine("Change DOCHandler ");
        }

        public override void save()
        {
            Console.WriteLine("Save DOCHandler ");
        }
    }
}
