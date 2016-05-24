using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Serialize_Lab.Classes
{
    class RailTransport : OverlandTransport
    {
        public string railcarType;
        public int railcarCount;

        protected override List<string> GetAttributes()
        {
            List<string> attributes = new List<string>();
            attributes.Add("Скорость" + "/" + Convert.ToString(movespeed));
            attributes.Add("Пассажировместимость" + "/" + Convert.ToString(passengerCapacity));
            attributes.Add("Грузоподъемность" + "/" + Convert.ToString(cargoCapacity));
            attributes.Add("Тип поезда" + "/" + railcarType);
            attributes.Add("Тип двигателя" + "/" + engineType);
            attributes.Add("Количество вагонов" + "/" + Convert.ToString(railcarCount));
            attributes.Add("Поезд");
            return attributes;
        }

        protected override void SetAttributes(List<string> attributes)
        {
            movespeed = Convert.ToInt32(attributes[0]);
            passengerCapacity = Convert.ToInt32(attributes[1]);
            cargoCapacity = Convert.ToInt32(attributes[2]);
            railcarType = attributes[3];
            engineType = attributes[4];
            railcarCount = Convert.ToInt32(attributes[5]);
            name = attributes[6];
        }

    }
}
