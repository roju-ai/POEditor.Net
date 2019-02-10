using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace POEditor.Model
{
    public class ResponseBasic
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
