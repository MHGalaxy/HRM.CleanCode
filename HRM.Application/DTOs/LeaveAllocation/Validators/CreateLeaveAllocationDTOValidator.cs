using FluentValidation;
using HRM.Application.Contracts.Persistance;

namespace HRM.Application.DTOs.LeaveAllocation.Validators
{
    public class CreateLeaveAllocationDTOValidator : AbstractValidator<CreateLeaveAllocationDTO>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        public CreateLeaveAllocationDTOValidator(ILeaveTypeRepository leaveTypeRepository)
        {
            _leaveTypeRepository = leaveTypeRepository;

            Include(new BaseLeaveAllocationDTOValidator(_leaveTypeRepository));
        }
    }
}
