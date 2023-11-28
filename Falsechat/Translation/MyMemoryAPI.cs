using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Falsechat.Translation
{
    public class MyMemoryAPI
    {
        private const string _url = "http://api.mymemory.translated.net";
        private HttpClient _httpClient;
        public MyMemoryAPI()
        {
            _httpClient = new HttpClient();
        }

        public async Task<string> TranslateAsync(string text, string targetLanguage)
        {
            string url = $"{_url}/get?q={Uri.EscapeDataString(text)}&langpair=AutoDetect|{targetLanguage}";
            HttpResponseMessage response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            string responseJson = await response.Content.ReadAsStringAsync();
            var translationResult = JsonConvert.DeserializeObject<TranslationResponse>(responseJson);

            if(translationResult.ResponseStatus == 200)
            {
                return translationResult.TranslatedText;
            }

            return text;
        }
    }
}
