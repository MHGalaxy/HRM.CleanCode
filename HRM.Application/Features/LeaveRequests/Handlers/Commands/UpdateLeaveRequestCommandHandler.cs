using AutoMapper;
using HRM.Application.Features.LeaveRequests.Requests.Commands;
using HRM.Application.Persistance.Contracts;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace HRM.Application.Features.LeaveRequests.Handlers.Commands
{
    public class UpdateLeaveRequestCommandHandler : IRequestHandler<UpdateLeaveRequestCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveRequestRepository _leaveRequestRepository;

        public UpdateLeaveRequestCommandHandler(IMapper mapper, ILeaveRequestRepository leaveRequestRepository)
        {
            _mapper = mapper;
            _leaveRequestRepository = leaveRequestRepository;
        }

        public async Task<Unit> Handle(UpdateLeaveRequestCommand request, CancellationToken cancellationToken)
        {
            var leaveRequest = await _leaveRequestRepository.Get(request.Id); // for calling change tracker in EF

            if (request.UpdateLeaveRequestDTO != null)
            {
                _mapper.Map(request.UpdateLeaveRequestDTO, leaveRequest);
                await _leaveRequestRepository.Update(leaveRequest);
            }
            else if (request.ChangeLeaveRequestAprovedDTO != null) 
            {
                _mapper.Map(request.UpdateLeaveRequestDTO, leaveRequest);
                await _leaveRequestRepository.ChangeApprovedStatus(leaveRequest, request.ChangeLeaveRequestAprovedDTO.Aproved);
            }

            return Unit.Value;
        }
    }
}
