using System;
class Lecture : Event
{
    private string _speaker;
    private int _capacity;
    public Lecture(string title, string description, DateTime date, TimeSpan time, string address, string speaker, int capacity) : base (title, description, date, time, address)
    {
        _capacity = capacity;
        _speaker = speaker;
    }
    public override string GetFullDetails()
    {
        return StandardDetails() + $"\n Lecture Event \n Speaker:{_speaker} \n Capacity: {_capacity.ToString()}";
    }
    public override string GetShortDescription()
    {
        return"Lecture - "+ ShortDescription();
    }

}