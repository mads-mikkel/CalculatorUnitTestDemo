using Newtonsoft.Json;

namespace Services
{
    /// <summary>
    /// Can call a specific exchange rates web service API.
    /// </summary>
    public class ExchangeRatesWebService
    {
        // Fields to hold standard URL parts:
        private string baseUrl = "https://openexchangerates.org/api/";
        private string apiKey = "3ba8a7d170114d4fa007cc98342fe73c";

        /// <summary>
        /// Gets the current value of DKK in relation to the USD.
        /// </summary>
        /// <returns>A double with the DKK/USD value.</returns>
        public double GetUsdInDkk()
        {
            // Build the URL:
            string url = $"{baseUrl}latest.json?app_id={apiKey}&symbols=DKK";

            // The variable to hold the HTTP (text, that is) response from the server:
            string json;

            // Make a client object, that will call the server:
            using (HttpClient client = new())
            {
                // call the server and save the response in hte json variable:
                json = client.GetStringAsync(url).Result;   
            }

            // Convert the json to Root object:
            Root root = JsonConvert.DeserializeObject<Root>(json);

            // Get the exchange rate, by "dotting" in the Root object:
            return root.rates.DKK;
        }
    }

    public class Rates
    {
        public double DKK { get; set; }
    }

    public class Root
    {
        public string disclaimer { get; set; }
        public string license { get; set; }
        public int timestamp { get; set; }
        public string @base { get; set; }
        public Rates rates { get; set; }
    }
}