using AutoMapper;
using HRM.Domain.Entities;
using HRM.Application.Features.LeaveTypes.Requests.Commands;
using HRM.Application.Contracts.Persistance;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using HRM.Application.DTOs.LeaveType.Validators;
using System;
using HRM.Application.Exceptions;

namespace HRM.Application.Features.LeaveTypes.Handlers.Commands
{
    public class CreateLeaveTypeCommandHandler : IRequestHandler<CreateLeaveTypeCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public CreateLeaveTypeCommandHandler(IMapper mapper, ILeaveTypeRepository leaveTypeRepository)
        {
            _mapper = mapper;
            _leaveTypeRepository = leaveTypeRepository;
        }

        public async Task<int> Handle(CreateLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateLeaveTypeDTOValidator();
            var validationResult = validator.Validate(request.CreateLeaveTypeDTO);

            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult);
            }

            var leaveType = _mapper.Map<LeaveType>(request.CreateLeaveTypeDTO);
            leaveType = await _leaveTypeRepository.Add(leaveType);
            return leaveType.Id;
        }
    }
}
