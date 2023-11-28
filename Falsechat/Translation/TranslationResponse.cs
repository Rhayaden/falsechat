using Newtonsoft.Json;

namespace Falsechat.Translation
{
    public class TranslationResponse
    {
        [JsonProperty("responseStatus")]
        public int ResponseStatus { get; set; }

        [JsonProperty("responseData")]
        public TranslationData ResponseData { get; set; }
        public string TranslatedText => ResponseData?.TranslationText;
    }
}
