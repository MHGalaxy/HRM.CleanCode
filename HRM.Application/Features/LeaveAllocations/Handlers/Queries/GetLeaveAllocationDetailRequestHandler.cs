using AutoMapper;
using HRM.Application.Features.LeaveAllocations.Requests.Queries;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using HRM.Application.DTOs.HRM.LeaveAllocation;
using HRM.Application.Contracts.Persistance.HRM;

namespace HRM.Application.Features.LeaveAllocations.Handlers.Queries
{
    public class GetLeaveAllocationDetailRequestHandler : IRequestHandler<GetLeaveAllocationDetailRequest, LeaveAllocationDTO>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;

        public GetLeaveAllocationDetailRequestHandler(IMapper mapper, ILeaveAllocationRepository leaveAllocationRepository)
        {
            _mapper = mapper;
            _leaveAllocationRepository = leaveAllocationRepository;
        }

        public async Task<LeaveAllocationDTO> Handle(GetLeaveAllocationDetailRequest request, CancellationToken cancellationToken)
        {
            var leaveAllocation = await _leaveAllocationRepository.GetLeaveAllocationWithDetails(request.Id);
            var mappedLeaveAllocation = _mapper.Map<LeaveAllocationDTO>(leaveAllocation);
            return mappedLeaveAllocation;
        }
    }
}
