using FluentValidation;

namespace Application.Features.EducationPrograms.Commands.Update;

public class UpdateEducationProgramCommandValidator : AbstractValidator<UpdateEducationProgramCommand>
{
    public UpdateEducationProgramCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
        RuleFor(c => c.CollegeId).NotEmpty();
        RuleFor(c => c.Name).NotEmpty().MaximumLength(70);
        RuleFor(c => c.Visibility).NotEmpty();
    }
}