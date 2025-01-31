using AutoMapper;
using HRM.Application.DTOs.HRM.LeaveAllocation.Validators;
using HRM.Application.Exceptions;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using HRM.Application.Contracts.Persistance.HRM;
using HRM.Application.Features.HRM.LeaveAllocations.Requests.Commands;

namespace HRM.Application.Features.HRM.LeaveAllocations.Handlers.Commands
{
    public class UpdateLeaveAllocationCommandHandler : IRequestHandler<UpdateLeaveAllocationCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        public UpdateLeaveAllocationCommandHandler(IMapper mapper,
            ILeaveAllocationRepository leaveAllocationRepository,
            ILeaveTypeRepository leaveTypeRepository)
        {
            _mapper = mapper;
            _leaveAllocationRepository = leaveAllocationRepository;
            _leaveTypeRepository = leaveTypeRepository;
        }

        public async Task<Unit> Handle(UpdateLeaveAllocationCommand request, CancellationToken cancellationToken)
        {
            var validator = new UpdateLeaveAllocationDTOValidator(_leaveTypeRepository);
            var validationResult = validator.Validate(request.UpdateLeaveAllocationDTO);

            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult);
            }

            var leaveAllocation = await _leaveAllocationRepository.Get(request.UpdateLeaveAllocationDTO.Id); // for calling change tracker in EF
            _mapper.Map(request.UpdateLeaveAllocationDTO, leaveAllocation);
            await _leaveAllocationRepository.Update(leaveAllocation);

            return Unit.Value;
        }
    }
}
