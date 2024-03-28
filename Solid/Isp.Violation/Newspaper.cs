using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isp.Violation
{
    public class Newspaper : IDocumentProcessor
    {
        public void Print()
        {
            Console.WriteLine("Printing document...");
        }

        public void Scan()
        {
            throw new NotImplementedException();
        }
    }
}
