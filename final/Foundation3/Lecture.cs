public class Lecture : Event
{
    public string _Speaker {get;}
    public int _Capacity {get;}

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        _Speaker = speaker;
        _Capacity = capacity;
    }
    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Lecture\nSpeaker: {_Speaker}\nCapacity: {_Capacity}";
    }

}