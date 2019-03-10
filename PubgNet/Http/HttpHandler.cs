#define DEBUG_HTTP_HANDLER // Use this to print http requests and responses to console

using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace PubgNet.Http
{
    // Simple Http Handler for making requests to the PUBG api.
    //
    // The base url for PUBG at the moment is 'https://api.pubg.com/'.
    // Use this unless there are other versions available and you'd like 
    // to use that instead.
    //
    // Specify your authentication key and keep in mind the amount of requests
    // that are available to your key.
    //
    // The accepted content type can be specified to use 'application/json'
    // but it is recommended to use 'application/vnd.api+json'.
    // 
    public class HttpHandler
    {
        private readonly System.Net.Http.HttpClient m_Client;

        // Create a new http client with base url, authentication key, and content type.
        public HttpHandler(string base_url, string auth_key, string content_type)
        {
            // Create a new http client
            m_Client = new System.Net.Http.HttpClient();

            // Set up http client
            m_Client.BaseAddress = new Uri(base_url);
            m_Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", auth_key);
            m_Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(content_type));

#if DEBUG_HTTP_HANDLER
            Console.WriteLine($"Http Client Created: {DateTime.Now.ToString("hh:mm:ss")}\nBase Url: {m_Client.BaseAddress}\n{m_Client.DefaultRequestHeaders}");
#endif
        }

        // Simple request using the base address and endpoint
        public async Task<string> RequestAsync(string endpoint)
        {
            try
            {
                HttpResponseMessage http_response = await m_Client.GetAsync(m_Client.BaseAddress + endpoint);
                if (http_response.IsSuccessStatusCode)
                {
                    HttpContent http_content = http_response.Content;
                    string string_content = await http_content.ReadAsStringAsync();
#if DEBUG_HTTP_HANDLER
                    Console.WriteLine($"Http Request Success: {endpoint}\nContent: {string_content}");
#endif
                    return string_content;
                }
                else
                {
                    throw new Exception($"Http Request Failed: {endpoint}");
                }
            }
            catch (Exception e)
            {
#if DEBUG_HTTP_HANDLER
                Console.WriteLine(string.Format("Http Exception: {0}", e));
#endif
            }
            return ""; // Blank
        }
    }
}
