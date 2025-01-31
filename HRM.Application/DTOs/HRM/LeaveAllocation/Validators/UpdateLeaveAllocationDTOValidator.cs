using FluentValidation;
using HRM.Application.Contracts.Persistance.HRM;
using HRM.Application.DTOs.HRM.LeaveAllocation;

namespace HRM.Application.DTOs.HRM.LeaveAllocation.Validators
{
    public class UpdateLeaveAllocationDTOValidator : AbstractValidator<UpdateLeaveAllocationDTO>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        public UpdateLeaveAllocationDTOValidator(ILeaveTypeRepository leaveTypeRepository)
        {
            _leaveTypeRepository = leaveTypeRepository;

            Include(new BaseLeaveAllocationDTOValidator(_leaveTypeRepository));

            RuleFor(x => x.Id)
               .NotEmpty().WithMessage("{PropertyName} is required.")
               .NotNull().WithMessage("{PropertyName} can't be null.");
        }
    }
}
