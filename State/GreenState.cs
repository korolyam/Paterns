using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class GreenState : ITrafficLightState
    {
        public ITrafficLightState Handle(TrafficLight context)
        {
            return new YellowState();
        }

        public string GetColor()
        {
            return "Зеленый";
        }
    }
}