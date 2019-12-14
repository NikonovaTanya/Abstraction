using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    abstract class  AbstractHandler
    {
        public abstract void open();
        public abstract void create();
        public abstract void change();
        public abstract void save();
    }
   }
