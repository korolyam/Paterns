using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class RedState : ITrafficLightState
    {
        public ITrafficLightState Handle(TrafficLight context)
        {
            return new GreenState();
        }

        public string GetColor()
        {
            return "Красный";
        }
    }
}