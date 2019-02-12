using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace POEditor.Model
{
    public class TermsProcessSummary
    {
        [JsonProperty("parsed")]
        public long? Parsed { get; set; } = null;

        [JsonProperty("added")]
        public long? Added { get; set; } = null;

        [JsonProperty("updated")]
        public long? Updated { get; set; } = null;

        [JsonProperty("with_added_comment")]
        public long? WithAddedComment { get; set; } = null;
    }
}
