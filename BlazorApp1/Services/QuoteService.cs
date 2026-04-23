using BlazorApp1.Models;
using Newtonsoft.Json;
using RestSharp;

namespace BlazorApp1.Services
{
    public class QuoteService
    {

        private readonly RestClient _restClient;

        public QuoteService(RestClient restClient)
        {
            _restClient = restClient;
        }

        public async Task<QuoteModel?> GetAllQuotes(string url)
        {
            var request = new RestRequest(url,Method.Get);
            var response = await _restClient.ExecuteAsync(request);
            if (!response.IsSuccessful)
            {
                return default!;
            }
            var str =  response.Content;
            if (str is null)
            {
                return default!;
            }
            var quotes = JsonConvert.DeserializeObject<QuoteModel?>(str);
            return quotes;
        }
    }
}
