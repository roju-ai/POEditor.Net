using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace POEditor.Model
{
    public class Project
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("public")]
        public long Public { get; set; }

        [JsonProperty("open")]
        public long Open { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }
    }
}
