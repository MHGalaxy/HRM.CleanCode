using AutoMapper;
using HRM.Application.Features.LeaveAllocations.Requests.Commands;
using HRM.Application.Persistance.Contracts;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace HRM.Application.Features.LeaveAllocations.Handlers.Commands
{
    public class UpdateLeaveAllocationCommandHandler : IRequestHandler<UpdateLeaveAllocationCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        public UpdateLeaveAllocationCommandHandler(IMapper mapper, ILeaveAllocationRepository leaveAllocationRepository)
        {
            _mapper = mapper;
            _leaveAllocationRepository = leaveAllocationRepository;
        }

        public async Task<Unit> Handle(UpdateLeaveAllocationCommand request, CancellationToken cancellationToken)
        {
            var leaveAllocation = await _leaveAllocationRepository.Get(request.UpdateLeaveAllocationDTO.Id); // for calling change tracker in EF
            _mapper.Map(request.UpdateLeaveAllocationDTO, leaveAllocation);
            await _leaveAllocationRepository.Update(leaveAllocation);

            return Unit.Value;
        }
    }
}
