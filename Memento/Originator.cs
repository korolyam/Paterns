namespace MementoProject
{
    public class Originator
    {
        public string _state { get; private set; }

        public void SetState(string state)
        {
            _state = state;
            Console.WriteLine("State set to: " + _state);
        }

        public Memento Save()
        {
            Console.WriteLine("Saving state...");
            return new Memento(_state);
        }

        public void Restore(Memento memento)
        {
            _state = memento._state;
            Console.WriteLine("Restored to state: " + _state);
        }
    }
}