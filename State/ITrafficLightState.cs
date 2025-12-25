namespace State
{
    public interface ITrafficLightState
    {
        ITrafficLightState Handle(TrafficLight context);
        string GetColor();
    }
}