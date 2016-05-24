using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Serialize_Lab.Classes
{
    abstract class WaterTransport : Transport
    {
        public int displacement;
        public int waterLine;

        public void Swim()
        {
            throw new NotImplementedException("Not realized");
        }

    }
}
