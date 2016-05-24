using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Serialize_Lab
{
    class HashTable
    {
        private Dictionary<string, string> hashs = new Dictionary<string, string>();

        public HashTable()
        {
            hashs.Add("PlanePlugin", "2651821C 1CE686B 64DDA437 22273717 56B55736");
            hashs.Add("HelicopterPlugin", "D2C0DA03 B3EEB4F4 B52FD3E1 2FF84EA0 73C9D343");
        }

        public bool Check(string name, string hash)
        {
            if (hashs[name].Contains(hash))
            {
                return true;
            }

            return false;
        }
    }
}
