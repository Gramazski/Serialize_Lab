using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InterfacePluginLibrary;

namespace Serialize_Lab.Classes
{
    [Serializable]
    public abstract class Transport : ITransport
    {
        public int movespeed;
        public int passengerCapacity;
        public int cargoCapacity;
        public string name;

        public List<string> Attridutes
        {
            get { return GetAttributes();  }
            set { SetAttributes(value); }
        }

        public string GetName()
        {
            return name;
        }

        protected abstract List<string> GetAttributes();

        protected abstract void SetAttributes(List<string> attributes);
    }
}
