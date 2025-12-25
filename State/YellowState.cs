using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class YellowState : ITrafficLightState
    {
        public ITrafficLightState Handle(TrafficLight context)
        {
            return new RedState();
        }

        public string GetColor()
        {
            return "Желтый";
        }
    }
}