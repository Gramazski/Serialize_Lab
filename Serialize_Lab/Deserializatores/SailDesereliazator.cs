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
    class SailDesereliazator : Deserializatores.Deserealizator
    {
        public override ITransport Deserialize(string data)
        {
            SailingTransport transport = new SailingTransport();

            byte[] bdata = Convert.FromBase64String(data);
            MemoryStream ms1 = new MemoryStream(bdata);
            using (BsonReader reader = new BsonReader(ms1))
            {
                JsonSerializer deserializer = new JsonSerializer();
                transport = deserializer.Deserialize<SailingTransport>(reader);
            }

            return transport;
        }
    }
}
