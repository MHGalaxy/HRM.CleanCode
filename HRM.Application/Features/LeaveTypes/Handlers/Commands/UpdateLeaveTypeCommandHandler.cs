using AutoMapper;
using HRM.Application.DTOs.HRM.LeaveType.Validators;
using HRM.Application.Exceptions;
using HRM.Application.Features.LeaveTypes.Requests.Commands;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using HRM.Application.Contracts.Persistance.HRM;

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
            var validator = new UpdateLeaveTypeDTOValidator();
            var validationResult = validator.Validate(request.UpdateLeaveTypeDTO);

            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult);
            }

            var leaveType = await _leaveTypeRepository.Get(request.UpdateLeaveTypeDTO.Id); // for calling change tracker in EF
            _mapper.Map(request.UpdateLeaveTypeDTO, leaveType);
            await _leaveTypeRepository.Update(leaveType);

            return Unit.Value;
        }
    }
}
