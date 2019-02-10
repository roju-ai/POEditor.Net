using Newtonsoft.Json;
using POEditor.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace POEditor.Body
{
    public class BaseResponse
    {
        [JsonProperty("response")]
        public ResponseBasic Response { get; set; }
    }
}
