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
    class CarDeserealizator : Deserializatores.Deserealizator
    {
        public override Transport Deserialize(string data)
        {
            AutoTransport transport = new AutoTransport();

            byte[] bdata = Convert.FromBase64String(data);
            MemoryStream ms1 = new MemoryStream(bdata);
            using (BsonReader reader = new BsonReader(ms1))
            {
                JsonSerializer deserializer = new JsonSerializer();
                transport = deserializer.Deserialize<AutoTransport>(reader);
            }

            return transport;
        }
    }
}
