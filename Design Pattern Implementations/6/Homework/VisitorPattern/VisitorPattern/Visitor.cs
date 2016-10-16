using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    class Visitor : IComputerPartVisitor
    {
        private string myColor = "White";
        public void Visit(Mouse mouse)
        {
            Console.WriteLine("Visit mouse");
            mouse.AcceptColor(myColor);
        }

        public void Visit(Keyboard keyboard)
        {
            Console.WriteLine("Visit keyboard");
            keyboard.AcceptColor(myColor);
        }

        public void Visit(Monitor monitor)
        {
            Console.WriteLine("Visit monitor");
            monitor.AcceptColor(myColor);
        }

        public void Visit(Computer computer)
        {
            Console.WriteLine("Visit computer");
            computer.AcceptColor(myColor);
        }
    }
}
