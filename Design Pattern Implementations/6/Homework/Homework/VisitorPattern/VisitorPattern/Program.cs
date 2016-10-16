using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Visiting the computer...");

            IComputerPart myComputer = new Computer();
            myComputer.Accept(new Visitor());
            Console.WriteLine(myComputer.GetColor());

            Console.WriteLine();

            //Visiting part by part.
            Console.WriteLine("Visiting part by part...");

            IComputerPart myMouse = new Mouse();
            myMouse.Accept(new Visitor());

            Console.WriteLine();

            IComputerPart myKeyboard = new Keyboard();
            myKeyboard.Accept(new Visitor());

            Console.WriteLine();

            IComputerPart myMonitor = new Monitor();
            myMonitor.Accept(new Visitor());

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
