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
    class PlaneDeserealizator : Deserializatores.Deserealizator
    {
        public override Transport Deserialize(string data)
        {
            Plane transport = new Plane();

            byte[] bdata = Convert.FromBase64String(data);
            MemoryStream ms1 = new MemoryStream(bdata);
            using (BsonReader reader = new BsonReader(ms1))
            {
                JsonSerializer deserializer = new JsonSerializer();
                transport = deserializer.Deserialize<Plane>(reader);
            }

            return transport;
        }
    }
}

