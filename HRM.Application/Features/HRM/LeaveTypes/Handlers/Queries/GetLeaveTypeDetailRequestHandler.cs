using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using HRM.Application.DTOs.HRM.LeaveType;
using HRM.Application.Contracts.Persistance.HRM;
using HRM.Application.Features.HRM.LeaveTypes.Requests.Queries;

namespace HRM.Application.Features.HRM.LeaveTypes.Handlers.Queries
{
    public class GetLeaveTypeDetailRequestHandler : IRequestHandler<GetLeaveTypeDetailRequest, LeaveTypeDTO>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public GetLeaveTypeDetailRequestHandler(IMapper mapper, ILeaveTypeRepository leaveTypeRepository)
        {
            _mapper = mapper;
            _leaveTypeRepository = leaveTypeRepository;
        }

        public async Task<LeaveTypeDTO> Handle(GetLeaveTypeDetailRequest request, CancellationToken cancellationToken)
        {
            var leaveType = await _leaveTypeRepository.Get(request.Id);
            var mappedLeaveType = _mapper.Map<LeaveTypeDTO>(leaveType);
            return mappedLeaveType;
        }
    }
}
