using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace FCMPushNotification
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            using (var client = new HttpClient())
            {
                ////giving the base address of our API and setting the response header.
                client.BaseAddress = new Uri("https://localhost:44382/api/Notes/sendMessage");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                //HTTP GET method
                MyAPIGet(client).Wait();
            }
        }
        static async Task MyAPIGet(HttpClient cons)
        {
            using (cons)
            {
                ////Sends a GET request to the specified Uri as an asynchronous operation.
                var response = await cons.GetAsync("https://localhost:44382/api/Notes/sendMessage");
                response.EnsureSuccessStatusCode();

                ////Read the content of the result using ReadAsStringAsync() method.
                string result = await response.Content.ReadAsStringAsync();

                Console.WriteLine(result);
                
            }
        }
    }
}