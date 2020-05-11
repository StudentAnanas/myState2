using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myState
{
    class YellowState : ITrafficLightState //состояние желтый свет
    {
    /// <summary>
    /// Выключить свет
    /// </summary>
    /// <param name="s">передаем объект светофор</param>
        public void TurnOff(TrafficLight s)
        {
            Console.WriteLine("Выключаем желтый и красный свет");
            s.State = new GreenState();
        }
        /// <summary>
        /// Включить свет
        /// </summary>
        /// <param name="s"></param>
        public void TurnOn(TrafficLight s)
        {
            Console.WriteLine("Включаем мигающий желтый");

        }
    }
}
