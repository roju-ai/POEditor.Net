using Newtonsoft.Json;
using POEditor.Model;
using System.Collections.Generic;

namespace POEditor.Body
{
    public class ProjectsListResponseResult
    {
        [JsonProperty("projects")]
        public List<Project> Projects { get; set; }
    }
}
