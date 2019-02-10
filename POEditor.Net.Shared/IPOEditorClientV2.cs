using POEditor.Body;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace POEditor
{
    public interface IPOEditorClientV2
    {
        [Post("/v2/projects/list")]
        Task<ProjectsListResponse> ProjectsList([Body(BodySerializationMethod.UrlEncoded)] ProjectsListRequest requestBody);
    }
}
