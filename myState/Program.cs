using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myState
{
    class Program
    {
        
    static void Main(string[] args)
        {
            TrafficLight trafficLight = new TrafficLight(new GreenState());
            trafficLight.TurnOff();
            trafficLight.TurnOn();
            trafficLight.TurnOff();
            trafficLight.TurnOff();
            trafficLight.TurnOn();
            trafficLight.TurnOff();
            trafficLight.TurnOn();
            Console.Read();
        }
    }
  

 

    
    
    
}
