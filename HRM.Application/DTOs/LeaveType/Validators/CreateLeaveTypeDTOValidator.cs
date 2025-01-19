using FluentValidation;

namespace HRM.Application.DTOs.LeaveType.Validators
{
    public class CreateLeaveTypeDTOValidator : AbstractValidator<CreateLeaveTypeDTO>
    {
        public CreateLeaveTypeDTOValidator() 
        {
            Include(new BaseLeaveTypeDTOValidator());
        }
    }
}
