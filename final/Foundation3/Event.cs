using System;
abstract class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private TimeSpan _time;
    private string _address;

    public Event(string title, string description, DateTime date, TimeSpan time, string address)
    {
        _title = title;
        _description = description;
        _date = date;
        _address = address;
    }
    public string StandardDetails()
    {
        return($"{_title} \n {_address} \n {_date} {_time} \n {_description}");
    }
    protected string ShortDescription()
    {
        return $"{_title} \n {_date} \n {_time}";
    }
    public abstract string GetFullDetails();
    public abstract string GetShortDescription();

}