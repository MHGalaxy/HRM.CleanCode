using FluentValidation;
using HRM.Application.Contracts.Persistance;
using System;

namespace HRM.Application.DTOs.LeaveAllocation.Validators
{
    public class BaseLeaveAllocationDTOValidator : AbstractValidator<ILeaveAllocationDTO>
    {

        private readonly ILeaveTypeRepository _leaveTypeRepository;
        public BaseLeaveAllocationDTOValidator(ILeaveTypeRepository leaveTypeRepository)
        {
            _leaveTypeRepository = leaveTypeRepository;

            RuleFor(x => x.NumberOfDays)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .GreaterThan(0).WithMessage("{PropertyName} must be greater than 0.")
                .LessThan(0).WithMessage("{PropertyName} must be smaller than 10.");

            RuleFor(x => x.Priod)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .GreaterThanOrEqualTo(DateTime.Now.Year).WithMessage("{PropertyName} must be after than {ComparisonValue}.");

            RuleFor(x => x.LeaveTypeId)
                .GreaterThan(0)
                .MustAsync(async (id, token) =>
                {
                    var leaveTypeExists = await _leaveTypeRepository.Exists(id);
                    return !leaveTypeExists;
                }).WithMessage("{PropertyName} doesn't exist.");

        }
    }
}
