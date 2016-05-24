using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Serialize_Lab.Classes
{
    class Plane : AirTransport
    {
        //Объеденить в одну структуру
        public string turbineType;
        public int turbineCount;
        public int turbinePower;

        public void Rise()
        {
            //..
        }

        public void Boarding()
        {
            //..
        }

        protected override List<string> GetAttributes()
        {
            List<string> attributes = new List<string>();
            attributes.Add("Скорость" + "/" + Convert.ToString(movespeed));
            attributes.Add("Пассажировместимость" + "/" + Convert.ToString(passengerCapacity));
            attributes.Add("Грузоподъемность" + "/" + Convert.ToString(cargoCapacity));
            attributes.Add("Тип турбин" + "/" + turbineType);
            attributes.Add("Тип двигателя" + "/" + engineType);
            attributes.Add("Максимальная высота подъема" + "/" + Convert.ToString(maxFlyingHeight));
            attributes.Add("Максимальная дальность полета" + "/" + Convert.ToString(flyingRange));
            attributes.Add("Количество турбин" + "/" + Convert.ToString(turbineCount));
            attributes.Add("Мощность турбины" + "/" + Convert.ToString(turbinePower));
            attributes.Add("Самолет");
            return attributes;
        }

        protected override void SetAttributes(List<string> attributes)
        {
            movespeed = Convert.ToInt32(attributes[0]);
            passengerCapacity = Convert.ToInt32(attributes[1]);
            cargoCapacity = Convert.ToInt32(attributes[2]);
            turbineType = attributes[3];
            engineType = attributes[4];
            maxFlyingHeight = Convert.ToInt32(attributes[5]);
            flyingRange = Convert.ToInt32(attributes[6]);
            turbineCount = Convert.ToInt32(attributes[7]);
            turbinePower = Convert.ToInt32(attributes[8]);
            name = attributes[9];
        }
    }
}
