using FluentValidation;

namespace JouveManager.Application.Features.SemiTrailers.Commands.UpdateSemiTrailer;

public class UpdateSemiTrailerCommandValidator : AbstractValidator<UpdateSemiTrailerCommand>
{
    public UpdateSemiTrailerCommandValidator()
    {
        RuleFor(x => x.LicensePlate)
            .NotEmpty().WithMessage("License plate is required");
        RuleFor(x => x.Brand)
            .NotEmpty().WithMessage("Brand is required");
        RuleFor(x => x.Model)
            .NotEmpty().WithMessage("Model is required");
        RuleFor(x => x.Type)
            .NotEmpty().WithMessage("Type is required");
    }
}
