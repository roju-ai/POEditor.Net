using Newtonsoft.Json;
using POEditor.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace POEditor.Body
{
    public class TermsAddResponseResult
    {
        [JsonProperty("terms")]
        public TermsProcessSummary Terms { get; set; }
    }
}
