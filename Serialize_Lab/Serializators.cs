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
using InterfacePluginLibrary;
using HelicopterPlugin;

namespace Serialize_Lab
{
    public class Serializators
    {
        Dictionary<Type, IDeserializator> deserealizators = new Dictionary<Type, IDeserializator>();

        public Serializators()
        {
            //deserealizators.Add(typeof(Plane), new Deserializatores.PlaneDeserealizator());
            deserealizators.Add(typeof(AutoTransport), new Deserializatores.CarDeserealizator());
            deserealizators.Add(typeof(RailTransport), new Deserializatores.RailDeserializator());
            deserealizators.Add(typeof(SailingTransport), new Deserializatores.SailDesereliazator());
            deserealizators.Add(typeof(SteamboatTransport), new Deserializatores.SteamBoatDeserializator());
        }

        public void AddDeserializator(Type key, IDeserializator deserializator)
        {
            deserealizators.Add(key, deserializator);
        }

        public ITransport Serialize(Type type, string data)
        {
            return deserealizators[type].Deserialize(data);
        }
    }
}
