using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class TrafficLight
    {
        public ITrafficLightState State { get; set; }

        public TrafficLight()
        {
            State = new RedState();
        }

        public void Change()
        {
            State = State.Handle(this);
        }

        public void ShowColor()
        {
            Console.WriteLine("Цвет сфетофора: " + State.GetColor());
        }
    }
}