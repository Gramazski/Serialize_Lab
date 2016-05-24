using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using Serialize_Lab.Classes;
using Serialize_Lab.Deserializatores;

namespace Serialize_Lab
{
    class Serializators
    {
        Dictionary<Type, Deserealizator> deserealizators = new Dictionary<Type, Deserealizator>();

        public Serializators()
        {
            deserealizators.Add(typeof(Plane), new Deserializatores.PlaneDeserealizator());
            deserealizators.Add(typeof(Helicopter), new Deserializatores.HelecopterDeserealizetor());
            deserealizators.Add(typeof(AutoTransport), new Deserializatores.CarDeserealizator());
            deserealizators.Add(typeof(RailTransport), new Deserializatores.RailDeserializator());
            deserealizators.Add(typeof(SailingTransport), new Deserializatores.SailDesereliazator());
            deserealizators.Add(typeof(SteamboatTransport), new Deserializatores.SteamBoatDeserializator());
        }

        public Transport Serialize(Type type, string data)
        {
            return deserealizators[type].Deserialize(data);
        }
    }
}
