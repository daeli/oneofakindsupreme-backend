using FastEndpoints;
using FluentValidation;

namespace OneOfAKindSupreme.Backend.Web.Api.Projects
{
    public class GetProjectValidator : Validator<GetProjectByIdRequest>
    {
        GetProjectValidator() 
        {
            RuleFor(x => x.ProjectId).GreaterThan(0);
        }
    }
}
