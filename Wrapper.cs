using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Serialize_Lab.Classes;

namespace Serialize_Lab
{
    class Wrapper
    {
        private List<Type> transports = new List<Type>();

        public List<Type> Content
        {
            get { return transports; }
            set { transports = value; }
        }
    }
}
