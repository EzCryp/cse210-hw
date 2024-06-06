public class Reception : Event
{
    public string RSPVEmail {get;}

    public Reception(string title, string description, string date, string time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        RSPVEmail = rsvpEmail;
    }
    public override string GetFullDetails()
    { 
        return $"{base.GetFullDetails()}\nType: Reception\nRSVP Email: {RSPVEmail}";
    }
}