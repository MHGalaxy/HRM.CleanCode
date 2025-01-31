using FluentValidation;
using HRM.Application.DTOs.HRM.LeaveType;

namespace HRM.Application.DTOs.HRM.LeaveType.Validators
{
    public class BaseLeaveTypeDTOValidator : AbstractValidator<ILeaveTypeDTO>
    {
        public BaseLeaveTypeDTOValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull().WithMessage("{PropertyName} can't be null.")
                .MaximumLength(100).WithMessage("{PropertyName} must be shorter than 100 character.");

            RuleFor(x => x.DefaultDay)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .GreaterThan(0).WithMessage("{PropertyName} must be greater than 0.")
                .LessThan(0).WithMessage("{PropertyName} must be smaller than 10.");
        }
    }
}
