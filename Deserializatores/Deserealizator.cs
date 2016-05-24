using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Serialize_Lab.Classes;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;

namespace Serialize_Lab.Deserializatores
{
    class Deserealizator
    {
        public virtual Transport Deserialize(string data)
        {
            Transport someTransport = new Transport();
            return someTransport;
        }

        public virtual string Serialize(string data)
        {
            return "";
        }
    }
}
