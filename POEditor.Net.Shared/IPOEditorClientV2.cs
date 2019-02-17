using POEditor.Body;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace POEditor
{
    public interface IPOEditorClientV2
    {
        [Post("/v2/projects/list")]
        Task<ProjectsListResponse> ProjectsList([Body(BodySerializationMethod.UrlEncoded)] ProjectsListRequest requestBody, CancellationToken cancellationToken);

        [Post("/v2/terms/list")]
        Task<TermsListResponse> TermsList([Body(BodySerializationMethod.UrlEncoded)] TermsListRequest requestBody, CancellationToken cancellationToken);

        [Post("/v2/terms/add")]
        Task<TermsAddResponse> TermsAdd([Body(BodySerializationMethod.UrlEncoded)] TermsAddRequest requestBody, CancellationToken cancellationToken);

        [Post("/v2/languages/list")]
        Task<LanguagesListResponse> LanguagesList([Body(BodySerializationMethod.UrlEncoded)] LanguagesListRequest requestBody, CancellationToken cancellationToken);

        [Post("/v2/languages/update")]
        Task<LanguagesUpdateResponse> LanguagesUpdate([Body(BodySerializationMethod.UrlEncoded)] LanguagesUpdateRequest requestBody, CancellationToken cancellationToken);
    }
}
