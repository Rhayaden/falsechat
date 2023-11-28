using Newtonsoft.Json;

namespace Falsechat.Translation
{
    public class TranslationData
    {
        [JsonProperty("translatedText")]
        public string TranslationText { get; set; }
    }
}
