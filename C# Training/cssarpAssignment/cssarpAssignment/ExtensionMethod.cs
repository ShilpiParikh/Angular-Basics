using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cssarpAssignment
{
    public static class ExtensionMethod
    {
        public static bool getValueOrDeafult(this bool? var1, bool var2)
        {
            return (bool)(var1 == null ? var2 : var1);
        }
    }
}