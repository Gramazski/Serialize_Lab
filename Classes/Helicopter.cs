using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Serialize_Lab.Classes
{
    class Helicopter : AirTransport
    {
        public string rotorType;//тип несущего винта

        public void VerticalTakeoff()
        {

        }

        public void VerticalBoarding()
        {
            //..
        }

        protected override List<string> GetAttributes()
        {
            List<string> attributes = new List<string>();
            attributes.Add("Скорость" + "/" + Convert.ToString(movespeed));
            attributes.Add("Пассажировместимость" + "/" + Convert.ToString(passengerCapacity));
            attributes.Add("Грузоподъемность" + "/" + Convert.ToString(cargoCapacity));
            attributes.Add("Тип винта" + "/" + rotorType);
            attributes.Add("Тип двигателя" + "/" + engineType);
            attributes.Add("Максимальная высота подъема" + "/" + Convert.ToString(maxFlyingHeight));
            attributes.Add("Максимальная дальность полета" + "/" + Convert.ToString(flyingRange));
            attributes.Add("Вертолет");
            return attributes;
        }

        protected override void SetAttributes(List<string> attributes)
        {
            movespeed = Convert.ToInt32(attributes[0]);
            passengerCapacity = Convert.ToInt32(attributes[1]);
            cargoCapacity = Convert.ToInt32(attributes[2]);
            rotorType = attributes[3];
            engineType = attributes[4];
            maxFlyingHeight = Convert.ToInt32(attributes[5]);
            flyingRange = Convert.ToInt32(attributes[6]);
            name = attributes[7];
        }
    }
}
