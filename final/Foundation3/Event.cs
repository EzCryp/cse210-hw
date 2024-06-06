
public class Event
{
    public string _Title {get;}
    public string _Description {get;}
    public string _Date {get;}
    public string _Time {get;}
    public Address Address {get;}

    public Event(string title, string description, string date, string time, Address address)
    {
        _Title = title;
        _Description = description;
        _Date = date;
        _Time = time;
        Address = address;
    }

    public string GetStandardDetails()
    {
        return $"Title: {_Title}\nDescription: {_Description}\nDate: {_Date}\nTime: {_Time}\nAddress: {Address._Street}, {Address._City}, {Address._State} {Address._ZipCode}";
    }

    public virtual string GetFullDetails()
    {
        return $"{GetStandardDetails()}";
    }

    public string GetShortDescription()
    {
        return $"Type: {GetType().Name}\nTitle: {_Title}\nDate: {_Date}";
    }
    
}