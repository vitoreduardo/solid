using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Violation
{
    public class Square : Rectangle
    {
        public override double Width 
        {
            set => base.Width = base.Height = value; 
        }

        public override double Height
        {
            set => base.Width = base.Height = value;
        }
    }
}
