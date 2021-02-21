using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionLibrary1
{
    public static class MathExtension
    {

        public static int TimesTen(this int source)
        {
            if(source == 0) { throw new ArgumentNullException(nameof(source)); }
            
            return source * 10;
        }

    }
}
