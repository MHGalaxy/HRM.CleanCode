using FluentValidation;
using HRM.Application.DTOs.HRM.LeaveType;

namespace HRM.Application.DTOs.HRM.LeaveType.Validators
{
    public class CreateLeaveTypeDTOValidator : AbstractValidator<CreateLeaveTypeDTO>
    {
        public CreateLeaveTypeDTOValidator()
        {
            Include(new BaseLeaveTypeDTOValidator());
        }
    }
}
