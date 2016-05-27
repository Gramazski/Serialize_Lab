using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HelicopterPlugin;
using System.Runtime.Serialization;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using Serialize_Lab.Classes;
using Serialize_Lab.Deserializatores;
using InterfacePluginLibrary;


namespace Serialize_Lab
{
    public class Serializators
    {
        Dictionary<Type, IDeserializator> deserealizators = new Dictionary<Type, IDeserializator>();
        Dictionary<Type, ISerializer> serealizators = new Dictionary<Type, ISerializer>();

        public Serializators()
        {
            deserealizators.Add(typeof(AutoTransport), new Deserializatores.CarDeserealizator());
            deserealizators.Add(typeof(RailTransport), new Deserializatores.RailDeserializator());
            deserealizators.Add(typeof(SailingTransport), new Deserializatores.SailDesereliazator());
            deserealizators.Add(typeof(SteamboatTransport), new Deserializatores.SteamBoatDeserializator());
            /*--------------------------------------------------------------------------------------------*/
            serealizators.Add(typeof(AutoTransport), new StandartSerializer());
            serealizators.Add(typeof(RailTransport), new StandartSerializer());
            serealizators.Add(typeof(SailingTransport), new StandartSerializer());
            serealizators.Add(typeof(SteamboatTransport), new StandartSerializer());
        }

        public void AddDeserializator(Type key, IDeserializator deserializator)
        {
            deserealizators.Add(key, deserializator);
        }

        public void AddSerializator(Type key, ISerializer serializator)
        {
            serealizators.Add(key, serializator);
        }

        public ITransport Deserialize(Type type, string data)
        {
            return deserealizators[type].Deserialize(data);
        }

        public string Serialize(Type type, ITransport someObject)
        {
            return serealizators[type].Serialize(someObject);
        }
    }
}
