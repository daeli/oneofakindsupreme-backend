using FastEndpoints;
using FluentValidation;

namespace OneOfAKindSupreme.Backend.Web.Api.Projects
{
    public class GetProjectValidator : Validator<GetProjectByIdRequest>
    {
        public GetProjectValidator() 
        {
            RuleFor(x => x.ProjectId).NotNull().NotEmpty().NotEqual(Guid.Empty);
        }
    }
}
