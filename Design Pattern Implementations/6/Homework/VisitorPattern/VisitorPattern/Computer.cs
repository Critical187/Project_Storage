using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
   public class Computer : IComputerPart
    {
        //datafields
        IComputerPart[] myComputerParts;
        private string myColor;
        public Computer()
        {
            myComputerParts = new IComputerPart[] { new Mouse(), new Keyboard(), new Monitor() };
        }
        public void Accept(IComputerPartVisitor computerPartVisitor)
        {
            for(int i = 0; i < myComputerParts.Length; i++)
            {
                myComputerParts[i].Accept(computerPartVisitor);
            }
            computerPartVisitor.Visit(this);
        }

        public void AcceptColor(string theColor)
        {
            myColor = theColor;
        }

        public string GetColor()
        {
            return myColor;
        }
    }
}
