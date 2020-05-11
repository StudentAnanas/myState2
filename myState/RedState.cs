using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myState
{
    class RedState : ITrafficLightState //состояние красный свет
    {
        /// <summary>
        /// Выключить свет
        /// </summary>
        /// <param name="s">передаем объект светофор</param>
        public void TurnOff(TrafficLight s)
        {
            Console.WriteLine("Включаем желтый свет");
            s.State = new YellowState();
        }
        /// <summary>
        /// Включить свет
        /// </summary>
        /// <param name="s">передаем объект светофор</param>
        public void TurnOn(TrafficLight s)
        {
            Console.WriteLine("Включаем Красный свет");
        }
    }
}
