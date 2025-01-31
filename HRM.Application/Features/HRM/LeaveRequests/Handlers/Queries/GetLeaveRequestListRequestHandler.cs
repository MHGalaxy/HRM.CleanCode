using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using HRM.Application.DTOs.HRM.LeaveRequest;
using HRM.Application.Contracts.Persistance.HRM;
using HRM.Application.Features.HRM.LeaveRequests.Requests.Queries;

namespace HRM.Application.Features.HRM.LeaveRequests.Handlers.Queries
{
    public class GetLeaveRequestListRequestHandler : IRequestHandler<GetLeaveRequestListRequest, List<LeaveRequestDTO>>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        public GetLeaveRequestListRequestHandler(IMapper mapper, ILeaveRequestRepository leaveRequestRepository)
        {
            _mapper = mapper;
            _leaveRequestRepository = leaveRequestRepository;
        }

        public async Task<List<LeaveRequestDTO>> Handle(GetLeaveRequestListRequest request, CancellationToken cancellationToken)
        {
            var leaveRequestList = await _leaveRequestRepository.GetLeaveRequestsWithDetails();
            var mappedLeaveRequestList = _mapper.Map<List<LeaveRequestDTO>>(leaveRequestList);
            return mappedLeaveRequestList;
        }
    }
}
