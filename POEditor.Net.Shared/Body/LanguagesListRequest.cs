using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace POEditor.Body
{
    public class LanguagesListRequest : BaseRequest
    {
        [JsonProperty("id")]
        public string Id { get; set; } = "";
    }
}
