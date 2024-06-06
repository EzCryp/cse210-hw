using System.Net.Http;

public class Gathering : Event
{
    public Gathering(string title, string description, string date, string time, Address address)
        : base(title, description, date, time, address)
    {
    }
    public override string GetFullDetails()
    {
        string apiKey = "API_KEY";
        using (HttpClient client = new HttpClient())
        {
            string cityState = $"{Address._City}, {Address._State}";
            string weatherData = client.GetStringAsync($"https://api.openweathermap.org/data/2.5/weather?q={cityState}&appid={apiKey}").Result;
            string weatherDescription = weatherData.Split("\"Description\":\"")[1].Split("\"")[0];

            return $"{base.GetFullDetails()}\nType: Outdoor Gathering\nWeather Forecast: {weatherDescription}";
        }
    }   
    
}