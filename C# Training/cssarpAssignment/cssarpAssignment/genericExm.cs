using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cssarpAssignment
{
    internal class genericExm
    {
        public void Addfunc<T>(T x, T y)
        {
            dynamic var1 = x;
            dynamic var2 = y;
            Console.WriteLine(var1 + var2);
        }

    }
}