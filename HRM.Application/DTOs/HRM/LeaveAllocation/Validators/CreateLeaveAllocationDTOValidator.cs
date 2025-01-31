using FluentValidation;
using HRM.Application.Contracts.Persistance.HRM;
using HRM.Application.DTOs.HRM.LeaveAllocation;

namespace HRM.Application.DTOs.HRM.LeaveAllocation.Validators
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
