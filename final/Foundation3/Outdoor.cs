using System;
class Outdoor : Event
{
    private string _weather;
    public Outdoor(string title, string description, DateTime date, TimeSpan time, string address, string weather) : base (title, description, date, time, address)
    {
        _weather = weather;
    }
    public override string GetFullDetails()
    {
        return StandardDetails() + $"\n Outdoor evnt forecast: {_weather}";
    }
    public override string GetShortDescription()
    {
        return "Outdoor \n " + ShortDescription();
    }
}