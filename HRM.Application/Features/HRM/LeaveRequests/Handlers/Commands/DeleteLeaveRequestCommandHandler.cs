﻿using AutoMapper;
using HRM.Application.Exceptions;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using HRM.Domain.Entities.HRM;
using HRM.Application.Contracts.Persistance.HRM;
using HRM.Application.Features.HRM.LeaveRequests.Requests.Commands;

namespace HRM.Application.Features.HRM.LeaveRequests.Handlers.Commands
{
    public class DeleteLeaveRequestCommandHandler : IRequestHandler<DeleteLeaveRequestCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveRequestRepository _leaveRequestRepository;

        public DeleteLeaveRequestCommandHandler(IMapper mapper, ILeaveRequestRepository leaveRequestRepository)
        {
            _mapper = mapper;
            _leaveRequestRepository = leaveRequestRepository;
        }

        public async Task<Unit> Handle(DeleteLeaveRequestCommand request, CancellationToken cancellationToken)
        {
            var leaveRequest = await _leaveRequestRepository.Get(request.Id);

            if (leaveRequest == null)
            {
                throw new NotFoundException(nameof(LeaveRequest), request.Id);
            }

            await _leaveRequestRepository.Delete(leaveRequest);
            return Unit.Value;
        }
    }
}
