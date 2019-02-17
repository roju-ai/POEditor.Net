using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace POEditor.Model
{
    public class TermTranslation
    {
        [JsonProperty("content")]
        [JsonConverter(typeof(TermTranslationContentJsonConverter))]
        public TermTranslationContent Content { get; set; }

        [JsonProperty("fuzzy")]
        public int? Fuzzy { get; set; }

        [JsonProperty("proofread")]
        public int? Proofread { get; set; }

        [JsonProperty("updated")]
        public DateTime? Updated { get; set; }
    }
}
