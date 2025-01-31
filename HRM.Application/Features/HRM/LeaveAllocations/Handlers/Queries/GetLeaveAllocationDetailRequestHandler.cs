using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using HRM.Application.DTOs.HRM.LeaveAllocation;
using HRM.Application.Contracts.Persistance.HRM;
using HRM.Application.Features.HRM.LeaveAllocations.Requests.Queries;

namespace HRM.Application.Features.HRM.LeaveAllocations.Handlers.Queries
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
