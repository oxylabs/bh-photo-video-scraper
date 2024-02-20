using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace OxyApi
{
    class Program
    {
        static async Task Main()
        {
            const string Username = "YOUR_USERNAME";
            const string Password = "YOUR_PASSWORD";

            var parameters = new Dictionary<string, string>()
            {
                { "source", "universal_ecommerce" },
                { "url", "https://www.bhphotovideo.com/c/browse/photography/ci/989/n/4294538916?usource=lc&lc_aid=155352&gad_source=1&gclid=cjwkcaiaungubhakeiwagid4asfe6eo7ztftj_7yirnqc0yembejfvvhmjow87_7xwmaenz4vpjibboc_ysqavd_bwe" },
            };


            var client = new HttpClient();

            Uri baseUri = new Uri("https://realtime.oxylabs.io");
            client.BaseAddress = baseUri;

            var requestMessage = new HttpRequestMessage(HttpMethod.Post, "/v1/queries");
            requestMessage.Content = JsonContent.Create(parameters);

            var authenticationString = $"{Username}:{Password}";
            var base64EncodedAuthenticationString = Convert.ToBase64String(System.Text.ASCIIEncoding.UTF8.GetBytes(authenticationString));
            requestMessage.Headers.Add("Authorization", "Basic " + base64EncodedAuthenticationString);

            var response = await client.SendAsync(requestMessage);
            var contents = await response.Content.ReadAsStringAsync();

            Console.WriteLine(contents);
        }
    }
}