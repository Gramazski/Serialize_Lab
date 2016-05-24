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
    class HelecopterDeserealizetor : Deserializatores.Deserealizator
    {
        public override Transport Deserialize(string data)
        {
            Helicopter transport = new Helicopter();

            byte[] bdata = Convert.FromBase64String(data);
            MemoryStream ms1 = new MemoryStream(bdata);
            using (BsonReader reader = new BsonReader(ms1))
            {
                JsonSerializer deserializer = new JsonSerializer();
                transport = deserializer.Deserialize<Helicopter>(reader);
            }

            return transport;
        }

        public override string Serialize(string data)
        {
            Helicopter transport = new Helicopter();

            byte[] bdata = Convert.FromBase64String(data);
            MemoryStream ms1 = new MemoryStream(bdata);
            using (BsonReader reader = new BsonReader(ms1))
            {
                JsonSerializer deserializer = new JsonSerializer();
                transport = deserializer.Deserialize<Helicopter>(reader);
            }

            return "";
        }
    }
}
