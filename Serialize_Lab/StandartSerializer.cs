using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InterfacePluginLibrary;
using System.Runtime.Serialization;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using System.Security.Cryptography;

namespace Serialize_Lab
{
    class StandartSerializer : ISerializer
    {
        public string Serialize(ITransport someObject)
        {
            JsonSerializer serializer = new JsonSerializer();
            MemoryStream ms = new MemoryStream();

            BsonWriter writer = new BsonWriter(ms);
            serializer.Serialize(writer, someObject);

            return Convert.ToBase64String(ms.ToArray());
        }
    }
}
