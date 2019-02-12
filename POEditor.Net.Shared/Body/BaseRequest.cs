using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace POEditor.Body
{
    public class BaseRequest
    {
        [JsonProperty("api_token")]
        public string ApiToken { get; set; } = "";
    }
}
