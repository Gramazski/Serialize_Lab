using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Serialize_Lab.Classes;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using InterfacePluginLibrary;

namespace Serialize_Lab.Deserializatores
{
    abstract class Deserealizator : IDeserializator
    {
        public abstract ITransport Deserialize(string data);

        //public abstract string Serialize(string data);
    }
}
