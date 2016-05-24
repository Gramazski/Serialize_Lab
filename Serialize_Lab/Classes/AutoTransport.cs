using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Serialize_Lab.Classes
{
    class AutoTransport : OverlandTransport
    {
        public string carType;
        public string wheelType;
        public string gearboxType;

        protected override List<string> GetAttributes()
        {
            List<string> attributes = new List<string>();
            attributes.Add("Скорость" + "/" + Convert.ToString(movespeed));
            attributes.Add("Пассажировместимость" + "/" + Convert.ToString(passengerCapacity));
            attributes.Add("Грузоподъемность" + "/" + Convert.ToString(cargoCapacity));
            attributes.Add("Тип кузова" + "/" + carType);
            attributes.Add("Тип двигателя" + "/" + engineType);
            attributes.Add("Тип колес" + "/" + wheelType);
            attributes.Add("Тип коробки передач" + "/" + gearboxType);
            attributes.Add("Автомобиль");
            return attributes;
        }

        protected override void SetAttributes(List<string> attributes)
        {
            movespeed = Convert.ToInt32(attributes[0]);
            passengerCapacity = Convert.ToInt32(attributes[1]);
            cargoCapacity = Convert.ToInt32(attributes[2]);
            carType = attributes[3];
            engineType = attributes[4];
            wheelType = attributes[5];
            gearboxType = attributes[6];
            name = attributes[7];
        }
    }
}
