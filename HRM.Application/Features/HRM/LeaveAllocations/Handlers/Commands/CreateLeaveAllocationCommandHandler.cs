using AutoMapper;
using HRM.Application.DTOs.HRM.LeaveAllocation.Validators;
using HRM.Application.Exceptions;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using HRM.Domain.Entities.HRM;
using HRM.Application.Contracts.Persistance.HRM;
using HRM.Application.Features.HRM.LeaveAllocations.Requests.Commands;

namespace HRM.Application.Features.HRM.LeaveAllocations.Handlers.Commands
{
    public class CreateLeaveAllocationCommandHandler : IRequestHandler<CreateLeaveAllocationCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        public CreateLeaveAllocationCommandHandler(IMapper mapper,
            ILeaveAllocationRepository leaveAllocationRepository,
            ILeaveTypeRepository leaveTypeRepository)
        {
            _mapper = mapper;
            _leaveAllocationRepository = leaveAllocationRepository;
            _leaveTypeRepository = leaveTypeRepository;
        }

        public async Task<int> Handle(CreateLeaveAllocationCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateLeaveAllocationDTOValidator(_leaveTypeRepository);
            var validationResult = validator.Validate(request.CreateLeaveAllocationDTO);

            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult);
            }

            var leaveAllocation = _mapper.Map<LeaveAllocation>(request.CreateLeaveAllocationDTO);
            leaveAllocation = await _leaveAllocationRepository.Add(leaveAllocation);
            return leaveAllocation.Id;
        }
    }
}
