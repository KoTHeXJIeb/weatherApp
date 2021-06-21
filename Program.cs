using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows.Forms;

namespace weatherApp
{
    static class Program
    {   

        static HttpClient httpClient = new HttpClient();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainForm());
        }

        static async void getWeather(string cityName)
        {

            string weatherApiKey = "f106fd17e4da4959a2781757212106";
            string requestLink = "http://api.weatherapi.com/v1/forecast.json?key=" + weatherApiKey + "&q=" + cityName + "&days=7";

            using (httpClient)
            {
                using (HttpResponseMessage message = await httpClient.GetAsync(requestLink))
                {
                    using (HttpContent content = message.Content) 
                    {

                        string data = await content.ReadAsStringAsync();
                        if (data == null)
                        {
                            return;
                        } else
                        {
                            
                        }
                    }
                }
            }
        
        }
    }
}
