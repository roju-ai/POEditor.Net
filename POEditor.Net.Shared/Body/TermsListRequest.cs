using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace POEditor.Body
{
    public class TermsListRequest : BaseRequest
    {
        [JsonProperty("id")]
        public string Id { get; set; } = "";

        [JsonProperty("language")]
        public string Language { get; set; } = null;

    }
}
