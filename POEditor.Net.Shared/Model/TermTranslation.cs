using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace POEditor.Model
{
    public class TermTranslation
    {
        [JsonProperty("content")]
        public TermTranslationContent Content { get; set; }

        [JsonProperty("fuzzy")]
        public long Fuzzy { get; set; }

        [JsonProperty("proofread")]
        public long Proofread { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }
    }
}
