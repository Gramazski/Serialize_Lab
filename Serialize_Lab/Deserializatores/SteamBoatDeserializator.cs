﻿using System;
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
    class SteamBoatDeserializator : Deserializatores.Deserealizator
    {
        public override ITransport Deserialize(string data)
        {
            SteamboatTransport transport = new SteamboatTransport();

            byte[] bdata = Convert.FromBase64String(data);
            MemoryStream ms1 = new MemoryStream(bdata);
            using (BsonReader reader = new BsonReader(ms1))
            {
                JsonSerializer deserializer = new JsonSerializer();
                transport = deserializer.Deserialize<SteamboatTransport>(reader);
            }

            return transport;
        }
    }
}
