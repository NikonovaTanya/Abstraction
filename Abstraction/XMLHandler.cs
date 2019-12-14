using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    class XMLHandler : AbstractHandler
    {
        public XMLHandler()
        {
            Console.WriteLine("Сlass XMLHandler");
        }
       public override void open()
        {
            Console.WriteLine("Open XMLHandler ");
        }
        public override void create()
        {
            Console.WriteLine("Create XMLHandler ");
        }
        public override void change()
        {
            Console.WriteLine("Change XMLHandler ");
        }

        public override void save()
        {
            Console.WriteLine("Save XMLHandler ");
        }
    }


}
