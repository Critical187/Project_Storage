using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public interface IComputerPart
    {
        void Accept(IComputerPartVisitor computerPartVisitor);
        void AcceptColor(string theColor);

        string GetColor();
    }

}
