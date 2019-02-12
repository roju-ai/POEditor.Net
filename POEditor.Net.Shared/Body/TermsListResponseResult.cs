using Newtonsoft.Json;
using POEditor.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace POEditor.Body
{
    public class TermsListResponseResult
    {
        [JsonProperty("terms")]
        public List<TermTranslated> Terms { get; set; }
    }
}
