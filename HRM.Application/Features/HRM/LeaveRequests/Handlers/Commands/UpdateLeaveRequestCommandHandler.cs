﻿using AutoMapper;
using HRM.Application.DTOs.HRM.LeaveRequest.Validators;
using HRM.Application.Exceptions;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using HRM.Application.Contracts.Persistance.HRM;
using HRM.Application.Features.HRM.LeaveRequests.Requests.Commands;

namespace HRM.Application.Features.HRM.LeaveRequests.Handlers.Commands
{
    public class UpdateLeaveRequestCommandHandler : IRequestHandler<UpdateLeaveRequestCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public UpdateLeaveRequestCommandHandler(IMapper mapper,
            ILeaveRequestRepository leaveRequestRepository,
            ILeaveTypeRepository leaveTypeRepository)
        {
            _mapper = mapper;
            _leaveRequestRepository = leaveRequestRepository;
            _leaveTypeRepository = leaveTypeRepository;
        }

        public async Task<Unit> Handle(UpdateLeaveRequestCommand request, CancellationToken cancellationToken)
        {
            var validator = new UpdateLeaveRequestDTOValidator(_leaveTypeRepository);
            var validationResult = validator.Validate(request.UpdateLeaveRequestDTO);

            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult);
            }

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
