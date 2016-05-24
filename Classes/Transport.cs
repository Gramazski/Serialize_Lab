using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Serialize_Lab.Classes
{
    [Serializable]
    public class Transport
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

        protected virtual List<string> GetAttributes()
        {
            List<string> someList = new List<string>();
            return someList;
        }

        protected virtual void SetAttributes(List<string> attributes)
        {

        }
    }
}
