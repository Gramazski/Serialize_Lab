using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Serialize_Lab.Classes
{
    abstract class OverlandTransport : Transport
    {
        public string engineType;

        public virtual void Drive()
        {
            throw new NotImplementedException("Not realized");
        }

        public virtual void Brake()
        {
            throw new NotImplementedException("Not realized");
        }
    }
}
