using FastEndpoints;
using FluentValidation;
using OneOfAKindSupreme.Backend.Infrastructure.Data.Config;

namespace OneOfAKindSupreme.Backend.Web.Api.Projects
{
    public class UpdateProjectValidator : Validator<UpdateProjectRequest>
    {
        public UpdateProjectValidator() 
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Name is required.")
                .MinimumLength(2)
                .MaximumLength(DataSchemaConstants.DEFAULT_NAME_LENGTH);
            RuleFor(x => x.ProjectId)
                .Must((args, projectId) => args.Id == projectId)
                .WithMessage("Invalid project id.");
        }
    }
}
