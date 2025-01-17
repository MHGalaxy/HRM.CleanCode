using AutoMapper;
using HRM.Application.Features.LeaveTypes.Requests.Commands;
using HRM.Application.Persistance.Contracts;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace HRM.Application.Features.LeaveTypes.Handlers.Commands
{
    public class UpdateLeaveTypeCommandHandler : IRequestHandler<UpdateLeaveTypeCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public UpdateLeaveTypeCommandHandler(IMapper mapper, ILeaveTypeRepository leaveTypeRepository)
        {
            _mapper = mapper;
            _leaveTypeRepository = leaveTypeRepository;
        }

        public async Task<Unit> Handle(UpdateLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            var leaveType = await _leaveTypeRepository.Get(request.UpdateLeaveTypeDTO.Id); // for calling change tracker in EF
            _mapper.Map(request.UpdateLeaveTypeDTO, leaveType);
            await _leaveTypeRepository.Update(leaveType);

            return Unit.Value;
        }
    }
}
