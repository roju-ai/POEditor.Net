using Newtonsoft.Json;
using POEditor.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace POEditor.Body
{
    public class LanguagesUpdateRequest : BaseRequest
    {
        [JsonProperty("id")]
        public string Id { get; set; } = "";

        [JsonProperty("language")]
        public string Language { get; set; } = null;

        [JsonIgnore]
        public bool? FuzzyTrigger { get; set; } = null;

        [JsonProperty("fuzzy_trigger")]
        public int? FuzzyTriggerToSend => FuzzyTrigger == null ? null : (int?)(FuzzyTrigger == true ? 1 : 0);

        [JsonIgnore]
        public List<TermTranslated> Data { get; set; }

        [JsonProperty("data")]
        public string DataToSend => JsonConvert.SerializeObject(Data);

    }
}
