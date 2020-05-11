using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myState
{

    class GreenState : ITrafficLightState //состояние зеленый свет
    {
        /// <summary>
        /// Выключить свет
        /// </summary>
        /// <param name="s">передаем объект светофор</param>
        public void TurnOff(TrafficLight s)
        {
            Console.WriteLine("Выключаем зеленый свет");
            s.State = new RedState();
        }
        /// <summary>
        /// Включить свет
        /// </summary>
        /// <param name="s">передаем объект светофор</param>
        public void TurnOn(TrafficLight s)
        {
            Console.WriteLine("Включаем зеленый свет");

        }
    }
}
