using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
   public class Mouse : IComputerPart
    {
        private string myColor;
        public void Accept(IComputerPartVisitor computerPartVisitor)
        {
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
