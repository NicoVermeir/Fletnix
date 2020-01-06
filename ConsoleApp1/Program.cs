using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string foo = await DoSomeStuff();
            Console.WriteLine(foo);
            Console.Read();
        }

        static Task<string> DoSomeStuff()
        {
            return DoSomeMoreStuff();
        }

        static Task<string> DoSomeMoreStuff()
        {
            return DoEvenMoreStuff();
        }

        static async Task<string> DoEvenMoreStuff()
        {
            return "Hello async";
        }

        static async Task DoStuff()
        {
            var client = new HttpClient();
            string result = await client.GetStringAsync(new Uri("https://localhost:44335/weatherforecast"));

            JsonSerializerOptions options = new JsonSerializerOptions();
            options.PropertyNameCaseInsensitive = true;

            var temperatures = JsonSerializer.Deserialize<List<Temperature>>(result, options);

            foreach (Temperature temp in temperatures)
            {
                Console.WriteLine($"{temp.Date.ToShortDateString()} - {temp.TemperatureC} DEGR C");
            }

            Console.Read();
        }
    }

   

    public class Temperature
    {
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public int TemperatureF { get; set; }
        public string Summary { get; set; }
    }

}
