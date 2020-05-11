using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myState
{
    class TrafficLight
    {
        public ITrafficLightState State { get; set; }

        public TrafficLight(ITrafficLightState ws)
        {
            State = ws;
        }

        public void TurnOff()
        {
            State.TurnOff(this);
        }
        public void TurnOn()
        {
            State.TurnOn(this);
        }
    }
}
