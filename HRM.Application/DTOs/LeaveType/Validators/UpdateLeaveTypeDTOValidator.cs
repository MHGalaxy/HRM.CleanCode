using FluentValidation;

namespace HRM.Application.DTOs.LeaveType.Validators
{
    public class UpdateLeaveTypeDTOValidator : AbstractValidator<UpdateLeaveTypeDTO>
    {
        public UpdateLeaveTypeDTOValidator()
        {
            Include(new BaseLeaveTypeDTOValidator());

            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull().WithMessage("{PropertyName} can't be null.");
        }
    }
}
