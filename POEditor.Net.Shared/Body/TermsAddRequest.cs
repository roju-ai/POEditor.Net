using Newtonsoft.Json;
using POEditor.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace POEditor.Body
{
    public class TermsAddRequest : BaseRequest
    {
        [JsonProperty("id")]
        public string Id { get; set; } = "";

        [JsonProperty("data")]
        public string DataToSend => JsonConvert.SerializeObject(Data);

        [JsonIgnore]
        public List<TermDefinition> Data { get; set; }
    }
}
