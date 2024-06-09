using FastEndpoints;
using FluentValidation;
using OneOfAKindSupreme.Backend.Infrastructure.Data.Config;

namespace OneOfAKindSupreme.Backend.Web.Api.Projects
{
    public class DeleteProjectValidator : Validator<DeleteProjectRequest>
    {
        public DeleteProjectValidator()
        {
            RuleFor(x => x.ProjectId)
                .Must((args, projectId) => args.ProjectId == projectId)
                .WithMessage("Invalid project id.");
        }
    }
}
