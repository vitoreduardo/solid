using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Violation
{
    public class Rectangle : Shape
    {
        public virtual double Width { get; set; }
        
        public virtual double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }

        public override double Perimeter()
        {
            return 2 * (Width + Height);
        }
    }
}
