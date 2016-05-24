using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Serialize_Lab.Classes
{
    class SailingTransport : WaterTransport
    {
        public int numberOfSails;
        public string shipHullType;
        //..

        protected override List<string> GetAttributes()
        {
            List<string> attributes = new List<string>();
            attributes.Add("Скорость" + "/" + Convert.ToString(movespeed));
            attributes.Add("Пассажировместимость" + "/" + Convert.ToString(passengerCapacity));
            attributes.Add("Грузоподъемность" + "/" + Convert.ToString(cargoCapacity));
            attributes.Add("Водоизмещение" + "/" + Convert.ToString(displacement));
            attributes.Add("Ватерлиния" + "/" + Convert.ToString(waterLine));
            attributes.Add("Тип корпуса судна" + "/" + shipHullType);
            attributes.Add("Количество парусов" + "/" + Convert.ToString(numberOfSails));
            attributes.Add("Парусник");
            return attributes;
        }

        protected override void SetAttributes(List<string> attributes)
        {
            movespeed = Convert.ToInt32(attributes[0]);
            passengerCapacity = Convert.ToInt32(attributes[1]);
            cargoCapacity = Convert.ToInt32(attributes[2]);
            displacement = Convert.ToInt32(attributes[3]);
            waterLine = Convert.ToInt32(attributes[4]);
            shipHullType = attributes[5];
            numberOfSails = Convert.ToInt32(attributes[6]);
            name = attributes[7];
        }
    }
}
