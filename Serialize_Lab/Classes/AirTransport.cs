using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Serialize_Lab.Classes
{
    abstract class AirTransport : Transport
    {
        public string engineType;
        public int maxFlyingHeight;
        public int flyingRange;

        public void Fly()
        {
            //..
        }
    }
}
