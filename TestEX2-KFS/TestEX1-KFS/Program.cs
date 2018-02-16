using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEX2_KFS
{
    class Program
    {
        static void Main(string[] args)
        {
            TriangleIdentifier TI = new TriangleIdentifier();
            while (TI.IsRunning)
            {
                TI.Triangle();
            }
        }
    }
}
