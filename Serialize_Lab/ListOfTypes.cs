using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Serialize_Lab.Classes;
using System.Reflection;

namespace Serialize_Lab
{
    class ListOfTypes
    {
        Assembly asm = Assembly.LoadFrom("plugins\\HelicopterPlugin.dll");
            
        private List<Type> transports = new List<Type>();

        public List<Type> Content
        {
            get { return transports; }
            set { transports = value; }
        }
    }
}
