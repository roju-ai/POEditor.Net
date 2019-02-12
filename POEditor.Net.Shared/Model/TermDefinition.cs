using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace POEditor.Model
{
    public class TermDefinition
    {
        [JsonProperty("term")]
        public string Term { get; set; }

        [JsonProperty("context")]
        public string Context { get; set; }

        [JsonProperty("plural")]
        public string Plural { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("tags")]
        public List<string> Tags { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }
    }
}
