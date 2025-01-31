

using FluentValidation;
using HRM.Application.Contracts.Persistance.HRM;
using HRM.Application.DTOs.HRM.LeaveRequest;

namespace HRM.Application.DTOs.HRM.LeaveRequest.Validators
{
    public class UpdateLeaveRequestDTOValidator : AbstractValidator<UpdateLeaveRequestDTO>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public UpdateLeaveRequestDTOValidator(ILeaveTypeRepository leaveTypeRepository)
        {
            _leaveTypeRepository = leaveTypeRepository;

            Include(new BaseLeaveRequestDTOValidator(_leaveTypeRepository));

            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull().WithMessage("{PropertyName} can't be null.");
        }
    }
}
