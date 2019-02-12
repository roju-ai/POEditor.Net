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

        [Post("/v2/terms/list")]
        Task<TermsListResponse> TermsList([Body(BodySerializationMethod.UrlEncoded)] TermsListRequest requestBody);

        [Post("/v2/terms/add")]
        Task<TermsAddResponse> TermsAdd([Body(BodySerializationMethod.UrlEncoded)] TermsAddRequest requestBody);
    }
}
