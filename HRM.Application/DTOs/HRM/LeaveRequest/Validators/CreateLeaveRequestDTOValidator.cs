using FluentValidation;
using HRM.Application.Contracts.Persistance.HRM;
using HRM.Application.DTOs.HRM.LeaveRequest;

namespace HRM.Application.DTOs.HRM.LeaveRequest.Validators
{
    public class CreateLeaveRequestDTOValidator : AbstractValidator<CreateLeaveRequestDTO>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public CreateLeaveRequestDTOValidator(ILeaveTypeRepository leaveTypeRepository)
        {
            _leaveTypeRepository = leaveTypeRepository;

            Include(new BaseLeaveRequestDTOValidator(_leaveTypeRepository));

        }
    }
}
