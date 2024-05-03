using System.ComponentModel.DataAnnotations;
using FastEndpoints;
using FluentValidation;
using OneOfAKindSupreme.Backend.Infrastructure.Data.Config;

namespace OneOfAKindSupreme.Backend.Web.Api.Projects
{
    public class CreateProjectValidator : Validator<CreateProjectRequest>
    {
        public CreateProjectValidator() 
        {
            RuleFor(x => x.Name)
              .NotEmpty()
              .WithMessage("Name is required.")
              .MinimumLength(2)
              .MaximumLength(DataSchemaConstants.DEFAULT_NAME_LENGTH);
        }
    }
}
