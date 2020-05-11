using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myState
{
    interface ITrafficLightState //интерфейс состояний светофора
    {
        void TurnOff(TrafficLight s);
        void TurnOn(TrafficLight s);
    }
}
