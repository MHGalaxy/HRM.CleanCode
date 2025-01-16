using AutoMapper;
using HRM.Domain.DTOs.LeaveRequest;
using HRM.Application.Features.LeaveRequests.Requests.Queries;
using HRM.Application.Persistance.Contracts;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace HRM.Application.Features.LeaveRequests.Handlers.Queries
{
    public class GetLeaveRequestDetailRequestHandler : IRequestHandler<GetLeaveRequestDetailRequest, LeaveRequestDTO>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveRequestRepository _leaveRequestRepository;

        public GetLeaveRequestDetailRequestHandler(IMapper mapper, ILeaveRequestRepository leaveRequestRepository)
        {
            _mapper = mapper;
            _leaveRequestRepository = leaveRequestRepository;
        }

        public async Task<LeaveRequestDTO> Handle(GetLeaveRequestDetailRequest request, CancellationToken cancellationToken)
        {
            var leaveRequest = await _leaveRequestRepository.GetLeaveRequestWithDetails(request.Id);
            var mappedLeaveRequest = _mapper.Map<LeaveRequestDTO>(leaveRequest);
            return mappedLeaveRequest;
        }
    }
}
