using AutoMapper;
using HRM.Application.Features.LeaveTypes.Requests.Commands;
using HRM.Application.Persistance.Contracts;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace HRM.Application.Features.LeaveTypes.Handlers.Commands
{
    public class DeleteLeaveTypeCommandHandler : IRequestHandler<DeleteLeaveTypeCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public DeleteLeaveTypeCommandHandler(IMapper mapper, ILeaveTypeRepository leaveTypeRepository)
        {
            _mapper = mapper;
            _leaveTypeRepository = leaveTypeRepository;
        }

        public async Task<Unit> Handle(DeleteLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            var leaveType = await _leaveTypeRepository.Get(request.Id);
            await _leaveTypeRepository.Delete(leaveType);
            return Unit.Value;
        }
    }
}
