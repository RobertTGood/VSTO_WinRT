using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinRTComponent;

namespace ClassLibrary1
{
    public class Class1
    {
        public string foo()
        {
            WinRTComponent.Class abc = new WinRTComponent.Class();
            return abc.MyFunction();
        }

    }
}
