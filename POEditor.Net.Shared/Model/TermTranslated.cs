using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace POEditor.Model
{
    public class TermTranslated : TermDefinition
    {
        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("translation")]
        public TermTranslation Translation { get; set; }
    }
}
