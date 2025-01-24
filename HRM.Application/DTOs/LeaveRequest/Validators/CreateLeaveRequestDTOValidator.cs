using FluentValidation;
using HRM.Application.Contracts.Persistance;

namespace HRM.Application.DTOs.LeaveRequest.Validators
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
