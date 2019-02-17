using Newtonsoft.Json;
using POEditor.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace POEditor.Body
{
    public class LanguagesListResponseResult
    {
        [JsonProperty("languages")]
        public List<Language> Languages { get; set; }
    }
}
