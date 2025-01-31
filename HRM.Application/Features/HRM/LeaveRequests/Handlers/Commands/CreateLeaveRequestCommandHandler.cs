using AutoMapper;
using HRM.Application.DTOs.HRM.LeaveRequest.Validators;
using HRM.Application.Exceptions;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using HRM.Domain.Entities.HRM;
using HRM.Application.Contracts.Persistance.HRM;
using HRM.Application.Features.HRM.LeaveRequests.Requests.Commands;

namespace HRM.Application.Features.HRM.LeaveRequests.Handlers.Commands
{
    public class CreateLeaveRequestCommandHandler : IRequestHandler<CreateLeaveRequestCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        public CreateLeaveRequestCommandHandler(IMapper mapper,
            ILeaveRequestRepository leaveRequestRepository,
            ILeaveTypeRepository leaveTypeRepository)
        {
            _mapper = mapper;
            _leaveRequestRepository = leaveRequestRepository;
            _leaveTypeRepository = leaveTypeRepository;
        }

        public async Task<int> Handle(CreateLeaveRequestCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateLeaveRequestDTOValidator(_leaveTypeRepository);
            var validationResult = validator.Validate(request.CreateLeaveRequestDTO);

            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult);
            }

            var leaveRequest = _mapper.Map<LeaveRequest>(request.CreateLeaveRequestDTO);
            leaveRequest = await _leaveRequestRepository.Add(leaveRequest);
            return leaveRequest.Id;
        }
    }
}
