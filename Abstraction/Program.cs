using System;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите формат файла: ");
            string f = Console.ReadLine();
            
            int ch = -1;
            do
            {
                var f1 = System.IO.Path.GetExtension(f);
                if (f1 == ".txt")
                {
                    ch = 1;
                }
                if (f1==".doc")
                {
                    ch = 2;
                }
                if (f1 == ".xml")
                {
                    ch = 3;
                }
                /*if (f1 == "0")
                {
                    ch = 0;
                }*/
                switch (ch)
                {
                    case 1:
                        {
                            AbstractHandler file = new TXTHandler();
                            file.create();
                            file.open();
                            file.change();
                            file.save();
                            break;

                        }
                    case 2:
                        {
                            AbstractHandler file = new DOCHandler();
                            file.create();
                            file.open();
                            file.change();
                            file.save();
                            break;
                        }
                    case 3:
                        {
                            AbstractHandler file = new XMLHandler();
                            file.create();
                            file.open();
                            file.change();
                            file.save();

                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Неверный ввод!");
                            break;

                        }
                }
                Console.ReadKey();
              //  Console.Clear();
                Console.WriteLine("0-выход из программы!");
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("   Введите формат файла: ");
                f = Console.ReadLine();
                if (f == "0")
                    ch = 0;
            } while (ch != 0);
        }
    }
    
}
