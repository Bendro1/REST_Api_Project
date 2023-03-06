

using Courseproject.Common.Dtos.Address;
using Courseproject.Common.Dtos.Job;
using Courseproject.Common.Dtos.Teams;
using FluentValidation;

namespace Courseproject.Business.Validation;

public class TeamUpdateValidator : AbstractValidator<TeamUpdate>
{
    public TeamUpdateValidator()
    {
        RuleFor(teamUpdate => teamUpdate.Name).NotEmpty().MaximumLength(50);




    }
}
